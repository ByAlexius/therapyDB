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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            search_box.Text = string.Empty;
            search_box.Text = "Search...";
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Patients_datagrid.Columns.Clear();

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

                Patients_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Patients_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Patients_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) 
            {
                int? id = (int)Patients_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Patient patient = new Patient(id ?? 0);

                patient.PatientClosed += PatientFormClosedHandle;

                patient.Show();
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(0);

            patient.PatientClosed += PatientFormClosedHandle;

            patient.Show();
        }

        private void PatientFormClosedHandle(object sender, bool closed)
        {
            PopulateDataGridView();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_box.Text.ToLower();

            if (search_box.Text.Trim() == "Search...")
            {
                return;
            }

            foreach (DataGridViewRow row in Patients_datagrid.Rows)
            {
                bool matchFound = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        matchFound = true;
                        break;
                    }
                }

                row.Visible = matchFound;
            }
        }
    }
}
