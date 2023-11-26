using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Therapist : Form
    {
        public event EventHandler<bool> TherapistClosed;

        private int localId;

        private therapists therapist;

        public Therapist(int id)
        {
            localId = id;
            InitializeComponent();

            if (id == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void Therapist_FormClosed(object sender, FormClosedEventArgs e)
        {
            TherapistClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (firstname_text.Text == "" || lastname_text.Text == "")
            {
                MessageBox.Show("Please enter a first and lastname!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex regex = new Regex(@"^\+?[0-9\s]+$");

            if (!regex.IsMatch(phone_text.Text))
            {
                MessageBox.Show("Please format your phone number in the format +43 664 345345345 or 06645645609!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            therapist.firstname = firstname_text.Text;
            therapist.lastname = lastname_text.Text;
            therapist.phone = phone_text.Text;
            therapist.email = email_text.Text;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.therapists.AddOrUpdate(therapist);

                db.SaveChanges();
            }

            Close();
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
                db.therapists.Remove(db.therapists.Where(x => x.the_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }

        private void Therapist_Load(object sender, EventArgs e)
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    therapist = db.therapists.Where(x => x.the_id == localId).First();
                }

                if (therapist == null)
                {
                    MessageBox.Show("The select therapist wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                firstname_text.Text = therapist.firstname;
                lastname_text.Text = therapist.lastname;
                phone_text.Text = therapist.phone;
                email_text.Text = therapist.email;
            }
            else
            {
                therapist = new therapists();
            }
        }
    }
}
