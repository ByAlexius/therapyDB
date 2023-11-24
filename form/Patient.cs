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
        private patients localPatient = null;

        private int user_id;

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
        }

        private void saveDataIntoPatient()
        {
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

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (localPatient == null && !delete_button.Enabled)
            {
                return;
            }
        }
    }
}
