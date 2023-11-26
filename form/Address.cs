using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Address : Form
    {
        public event EventHandler<bool> NewAddressClosed;

        private int _addressId;

        private addresses localAddress;

        public Address(int id)
        {
            _addressId = id;
            InitializeComponent();

            if (id == 0)
            {
                delete_button.Enabled = false;
                localAddress = new addresses();
            }
            else
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    localAddress = db.addresses.Where(x => x.add_id == id).First();
                }

                city_text.Text = localAddress.city;
                postal_text.Text = localAddress.postal;
                street_text.Text = localAddress.street;
                nr_text.Text = Convert.ToString(localAddress.nr ?? 0);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (city_text.Text == "" || postal_text.Text == "" || street_text.Text == "" || nr_text.Text == "")
            {
                MessageBox.Show("Please add a value to all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            localAddress.city = city_text.Text;
            localAddress.postal = postal_text.Text;
            localAddress.street = street_text.Text;

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(nr_text.Text))
            {
                MessageBox.Show("House Nr must be an Integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            localAddress.nr = Convert.ToInt32(nr_text.Text);


            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.addresses.AddOrUpdate(localAddress);

                db.SaveChanges();
            }

            Close();
            Dispose();
            GC.Collect();
        }

        private void NewAddress_FormClosed(object sender, FormClosedEventArgs e)
        {
            NewAddressClosed?.Invoke(this, true);

            this.Dispose();
            GC.Collect();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (_addressId <= 0)
            {
                return;
            }

            if (!delete_button.Enabled)
            {
                return;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.addresses.Remove(db.addresses.Where(x => x.add_id == _addressId).First());

                db.SaveChanges();
            }

            Close();
        }
    }
}
