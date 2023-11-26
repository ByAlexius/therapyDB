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
    public partial class PatientSelector : Form
    {
        public event EventHandler<int> PatientSelectorClosed;

        private int patient_id = 0;

        public PatientSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.patients.OrderBy(e => e.pat_id).Select(e => new
                {
                    e.pat_id,
                    e.firstname,
                    e.lastname,
                    e.phone,
                    e.address
                }).ToList();

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void PatientSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientSelectorClosed?.Invoke(this, patient_id);

            this.Dispose();
            GC.Collect();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                patient_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }

        private void new_patient_button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(0);

            patient.PatientClosed += PatientFormClosedHandle;

            patient.ShowDialog();
        }

        private void PatientFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }
    }
}
