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
            search_box.Text = string.Empty;
            search_box.Text = "Search...";
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

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_box.Text.ToLower();

            if (search_box.Text.Trim() == "Search...")
            {
                return;
            }

            foreach (DataGridViewRow row in Treatments_datagrid.Rows)
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
