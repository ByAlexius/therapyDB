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
    public partial class LocationSelector : Form
    {
        public event EventHandler<int> LocationSelectorClosed;

        private int loc_id = 0;

        public LocationSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.locations.OrderBy(e => e.loc_id).Select(e => new
                {
                    e.loc_id,
                    e.name,
                    e.address_id
                }).ToList();

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
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

                loc_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }

        private void LocationSelector_Load(object sender, EventArgs e)
        {

        }

        private void LocationSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            LocationSelectorClosed?.Invoke(this, loc_id);
        }

        private void new_location_button_Click(object sender, EventArgs e)
        {
            Location location = new Location(0);

            location.LocationClosed += LocationClosedHandle;

            location.ShowDialog();
        }

        private void LocationClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }
    }
}
