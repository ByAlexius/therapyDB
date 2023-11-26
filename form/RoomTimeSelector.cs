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
    public partial class RoomTimeSelector : Form
    {
        public event EventHandler<int> RoomTimeSelectorClosed;

        private int rt_id = 0;

        public RoomTimeSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.room_times.OrderBy(e => e.rti_id).Select(e => new
                {
                    e.rti_id,
                    e.room_id,
                    e.time_id
                }).ToList();

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void RoomTimeSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoomTimeSelectorClosed?.Invoke(this, rt_id);

            this.Dispose();
            GC.Collect();
        }

        private void new_roomtime_button_Click(object sender, EventArgs e)
        {
            RoomTime roomTime = new RoomTime(0);

            roomTime.RoomTimeClosed += roomTimeClosedHandle;

            roomTime.ShowDialog();
        }

        private void roomTimeClosedHandle(object sender, bool e)
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

                rt_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }
    }
}
