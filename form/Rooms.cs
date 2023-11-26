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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Rooms_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.rooms.OrderBy(e => e.room_id).Select(e => new
                {
                    e.room_id,
                    e.room
                }).ToList();

                Rooms_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Rooms_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Rooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Room room = new Room(0);

            room.RoomClosed += RoomFormClosedHandle;

            room.Show();
        }

        private void Rooms_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Rooms_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Room room = new Room(id ?? 0);

                room.RoomClosed += RoomFormClosedHandle;

                room.Show();
            }
        }

        private void RoomFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void room_times_button_Click(object sender, EventArgs e)
        {
            new RoomTimes().Show();
        }
    }
}
