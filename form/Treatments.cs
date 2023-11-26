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
    public partial class Treatments : Form
    {
        public Treatments()
        {
            InitializeComponent();
        }

        private void Treatments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Treatments_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.treatments.OrderBy(e => e.tre_id).Select(e => new
                {
                    e.tre_id,
                    e.name
                }).ToList();

                Treatments_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Treatments_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Treatments_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Treatments_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Treatment treatment = new Treatment(id ?? 0);

                treatment.NewTreatmentClosed += NewTreatmentFormClosedHandle;

                treatment.ShowDialog();
            }
        }

        private void NewTreatmentFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment(0);

            treatment.NewTreatmentClosed += NewTreatmentFormClosedHandle;

            treatment.ShowDialog();
        }
    }
}
