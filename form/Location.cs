using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Location : Form
    {
        public event EventHandler<bool> LocationClosed;

        private int localId;

        private locations location;

        private int address_id = 0;

        public Location(int id)
        {
            localId = id;

            InitializeComponent();

            if (id == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void Location_FormClosed(object sender, FormClosedEventArgs e)
        {
            LocationClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    location = db.locations.Where(x => x.loc_id == localId).First();
                }

                if (location == null)
                {
                    MessageBox.Show("The select treatment wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                address_id = location.address_id;

                name_text.Text = location.name;
                loadAddress();
            }
            else
            {
                location = new locations();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (address_id == 0)
            {
                MessageBox.Show("Please select a valid address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            location.name = name_text.Text;
            location.address_id = address_id;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.locations.AddOrUpdate(location);

                db.SaveChanges();
            }

            Close();
            Dispose();
            GC.Collect();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (localId <= 0)
            {
                return;
            }

            if (!delete_button.Enabled)
            {
                return;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.locations.Remove(db.locations.Where(x => x.loc_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }

        private void address_change_button_Click(object sender, EventArgs e)
        {
            AddressSelector selector = new AddressSelector();

            selector.PatientAddressSelectorClosed += selectorClosedHandle;

            selector.ShowDialog();
        }

        private void selectorClosedHandle(object sender, int id)
        {
            if (sender is AddressSelector selector)
            {
                selector.PatientAddressSelectorClosed -= selectorClosedHandle;
            }

            address_id = id;

            if (address_id == 0)
            {
                return;
            }

            loadAddress();
        }

        private void loadAddress()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                addresses adr = db.addresses.Where(x => x.add_id == address_id).First();

                if (adr == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                address_text.Text = $"{adr.postal} {adr.city}, {adr.street} {adr.nr}";
            }
        }
    }
}
