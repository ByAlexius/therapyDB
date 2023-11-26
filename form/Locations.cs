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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Locations_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.locations.OrderBy(e => e.loc_id).Select(e => new
                {
                    e.loc_id,
                    e.name,
                    e.address_id
                }).ToList();

                Locations_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Locations_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Locations_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void Locations_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Locations_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Location location = new Location(id ?? 0);

                location.LocationClosed += LocationFormClosedHandle;

                location.ShowDialog();
            }
        }

        private void LocationFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Location location = new Location(0);

            location.LocationClosed += LocationFormClosedHandle;

            location.ShowDialog();
        }
    }
}
