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
    public partial class Therapists : Form
    {
        public Therapists()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Therapists_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.therapists.OrderBy(e => e.the_id).Select(e => new
                {
                    e.the_id,
                    e.firstname,
                    e.lastname,
                    e.phone,
                    e.email
                }).ToList();

                Therapists_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Therapists_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Therapists_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Therapists_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Therapist therapist = new Therapist(id ?? 0);

                therapist.TherapistClosed += TherapistFormClosedHandle;

                therapist.ShowDialog();
            }
        }

        private void TherapistFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Therapist therapist = new Therapist(0);

            therapist.TherapistClosed += TherapistFormClosedHandle;

            therapist.ShowDialog();
        }

        private void Therapists_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }
    }
}
