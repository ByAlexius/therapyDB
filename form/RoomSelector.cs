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
    public partial class RoomSelector : Form
    {
        public event EventHandler<int> RoomSelectorClosed;

        private int room_id = 0;

        public RoomSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.rooms.OrderBy(e => e.room_id).Select(e => new
                {
                    e.room_id,
                    e.room
                }).ToList();

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void RoomSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoomSelectorClosed?.Invoke(this, room_id);

            this.Dispose();
            GC.Collect();
        }

        private void new_room_button_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room(0);

            newRoom.RoomClosed += RoomClosedHandle;

            newRoom.ShowDialog();
        }

        private void RoomClosedHandle(object sender, bool e)
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

                room_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }
    }
}
