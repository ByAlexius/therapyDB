using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Treatment : Form
    {
        public event EventHandler<bool> NewTreatmentClosed;

        private int treatment_id;

        private treatments localTreatment;

        public Treatment(int id)
        {
            this.treatment_id = id;

            InitializeComponent();


            if (id == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void Treatment_FormClosed(object sender, FormClosedEventArgs e)
        {
            NewTreatmentClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            if (treatment_id > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    localTreatment = db.treatments.Where(x => x.tre_id == treatment_id).First();
                }

                if (localTreatment == null)
                {
                    MessageBox.Show("The select treatment wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                name_text.Text = localTreatment.name;
            } 
            else
            {
                localTreatment = new treatments();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "")
            {
                MessageBox.Show("Please enter a name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            localTreatment.name = name_text.Text;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.treatments.AddOrUpdate(localTreatment);

                db.SaveChanges();
            }

            Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (treatment_id <= 0)
            {
                return;
            }

            if (!delete_button.Enabled)
            {
                return;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.treatments.Remove(db.treatments.Where(x => x.tre_id == treatment_id).First());

                db.SaveChanges();
            }

            Close();
        }
    }
}
