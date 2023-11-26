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
    public partial class TreatmentSelector : Form
    {
        public event EventHandler<int> TreatmentSelectorClosed;

        private int treatment_id = 0;

        public TreatmentSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

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

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void new_treatment_button_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment(0);

            treatment.NewTreatmentClosed += NewTreatmentClosedHandle;

            treatment.ShowDialog();
        }

        private void NewTreatmentClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
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

                treatment_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }

        private void TherapistTreatmentSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreatmentSelectorClosed?.Invoke(this, treatment_id);

            this.Dispose();
            GC.Collect();
        }
    }
}
