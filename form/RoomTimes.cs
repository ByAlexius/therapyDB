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
    public partial class RoomTimes : Form
    {
        public RoomTimes()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            RoomTime_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.room_times.OrderBy(e => e.rti_id).Select(e => new
                {
                    e.rti_id,
                    e.room_id,
                    e.time_id
                }).ToList();

                RoomTime_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in RoomTime_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void RoomTimes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void RoomTime_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)RoomTime_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RoomTime roomTime = new RoomTime(id ?? 0);

                roomTime.RoomTimeClosed += RoomTimeFormClosedHandle;

                roomTime.ShowDialog();
            }
        }

        private void RoomTimeFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            RoomTime roomTime = new RoomTime(0);

            roomTime.RoomTimeClosed += RoomTimeFormClosedHandle;

            roomTime.ShowDialog();
        }
    }
}
