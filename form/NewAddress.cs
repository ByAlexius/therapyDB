using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class NewAddress : Form
    {
        public event EventHandler<bool> NewAddressClosed;

        public NewAddress()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (city_text.Text == "" || postal_text.Text == "" || street_text.Text == "" || nr_text.Text == "")
            {
                MessageBox.Show("Please add a value to all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addresses newAddress = new addresses();

            newAddress.city = city_text.Text;
            newAddress.postal = postal_text.Text;
            newAddress.street = street_text.Text;

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(nr_text.Text))
            {
                MessageBox.Show("House Nr must be an Integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newAddress.nr = Convert.ToInt32(nr_text.Text);


            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.addresses.Add(newAddress);

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
    }
}
