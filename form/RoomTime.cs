using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class RoomTime : Form
    {
        public event EventHandler<bool> RoomTimeClosed;

        private int localId;

        private room_times roomTime;

        private int room_id;

        private int time_id;

        public RoomTime(int id)
        {
            localId = id;
            InitializeComponent();

            if (localId == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void RoomTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoomTimeClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }

        private void RoomTime_Load(object sender, EventArgs e)
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    roomTime = db.room_times.Where(x => x.rti_id == localId).First();
                }

                if (roomTime == null)
                {
                    MessageBox.Show("The select roomTime wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                room_id = roomTime.room_id;
                time_id = roomTime.time_id;
            }
            else
            {
                roomTime = new room_times();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (room_id == 0)
            {
                MessageBox.Show("Please select a room!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (time_id == 0)
            {
                MessageBox.Show("Please select a time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomTime.room_id = room_id;
            roomTime.time_id = time_id;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.room_times.AddOrUpdate(roomTime);

                db.SaveChanges();
            }

            Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (localId <= 0)
            {
                return;
            }

            if (!delete_button.Enabled)
            {
                return;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.room_times.Remove(db.room_times.Where(x => x.rti_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }

        private void room_change_button_Click(object sender, EventArgs e)
        {
            RoomSelector selector = new RoomSelector();

            selector.RoomSelectorClosed += roomSelectorClosedHandle;

            selector.ShowDialog();
        }

        private void roomSelectorClosedHandle(object sender, int id)
        {
            room_id = id;

            if (room_id == 0)
            {
                return;
            }

            loadRoom();
        }

        private void loadRoom()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                rooms room = db.rooms.Where(x => x.room_id == room_id).First();

                if (room == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                room_text.Text = $"{room.room}";
            }
        }

        private void time_change_button_Click(object sender, EventArgs e)
        {
            TimeSelector selector = new TimeSelector();

            selector.TimeSelectorClosed += timeSelectorClosedHandle;

            selector.ShowDialog();
        }

        private void timeSelectorClosedHandle(object sender, int id)
        {
            time_id = id;

            if (time_id == 0)
            {
                return;
            }

            loadTime();
        }

        private void loadTime()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                times time = db.times.Where(x => x.time_id == time_id).First();

                if (time == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                time_text.Text = $"{time.date:yyyy-MM-dd} {time.time:hh\\:mm}";
            }
        }
    }
}
