using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Patient : Form
    {
        public event EventHandler<bool> PatientClosed;

        private patients localPatient = null;

        private int user_id = 0;

        private int address_id = 0;

        public Patient(int patient_id)
        {
            user_id = patient_id;
            InitializeComponent();
            loadPatient();

            if (user_id == 0)
            {
                this.Text = $"TMS - New Patient";
                delete_button.Enabled = false;
            }
            else
            {
                this.Text = $"TMS - {localPatient.firstname} {localPatient.lastname}";
            }
        }

        private void loadPatient()
        {
            if (!(user_id >= 1))
            {
                localPatient = new patients();
                return;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                localPatient = db.patients.Where(x => x.pat_id == user_id).First();
            }

            if (localPatient == null)
            {
                MessageBox.Show("The select patient wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                Dispose();
                GC.Collect();
                return;
            }


            firstname_text.Text = localPatient.firstname;
            lastname_text.Text = localPatient.lastname;
            phone_text.Text = localPatient.phone;
            address_id = localPatient.address;
        }

        private void saveDataIntoPatient()
        {
            localPatient = new patients();

            localPatient.firstname = firstname_text.Text;
            localPatient.lastname = lastname_text.Text;
            localPatient.phone = phone_text.Text;
            localPatient.address = address_id;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                if (user_id >= 1)
                {
                    db.patients.Remove(db.patients.Where(x => x.pat_id == user_id).First());
                }

                db.patients.Add(localPatient);
                
                db.SaveChanges();
            }

            Close();
            Dispose();
            GC.Collect();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (address_id == 0)
            {
                MessageBox.Show("Please select a valid address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveDataIntoPatient();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (localPatient == null && !delete_button.Enabled)
            {
                return;
            }
        }

        private void address_change_button_Click(object sender, EventArgs e)
        {
            AddressSelector selector = new AddressSelector();

            selector.PatientAddressSelectorClosed += selectorClosedHandler;

            selector.ShowDialog();
        }

        private void selectorClosedHandler(object sender, int id)
        {
            if (sender is AddressSelector selector)
            {
                selector.PatientAddressSelectorClosed -= selectorClosedHandler;
            }

            address_id = id;

            if (address_id == 0)
            {
                return;
            }

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

        private void open_button_Click(object sender, EventArgs e)
        {

        }

        private void Patient_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientClosed?.Invoke(this, true);

            this.Dispose();
            GC.Collect();
        }
    }
}
