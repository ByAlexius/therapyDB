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
    public partial class Times : Form
    {
        public Times()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Times_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.times.OrderBy(e => e.time_id).Select(e => new
                {
                    e.time_id,
                    e.time,
                    e.date
                }).ToList();

                Times_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Times_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Times_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Times_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Time time = new Time(id ?? 0);

                time.TimeClosed += TimeFormClosedHandle;

                time.ShowDialog();
            }
        }

        private void TimeFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Time time = new Time(0);

            time.TimeClosed += TimeFormClosedHandle;

            time.ShowDialog();
        }

        private void Times_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }
    }
}
