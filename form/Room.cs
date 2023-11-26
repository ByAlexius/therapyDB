using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Room : Form
    {
        public event EventHandler<bool> RoomClosed;

        private int localId;

        private rooms room;

        private int loc_id;

        public Room(int id)
        {
            localId = id;
            InitializeComponent();

            if (id == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void Room_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoomClosed?.Invoke(this, true);

            this.Dispose();
            GC.Collect();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (room_text.Text == "")
            {
                MessageBox.Show("Please enter a room number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex regex = new Regex(@"^[A-Za-z0-9]+(-[A-Za-z0-9]+)?$");

            if (!regex.IsMatch(room_text.Text))
            {
                MessageBox.Show("Please enter a valid room number for example 123, A101 or B-03!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            room.room = room_text.Text;
            room.location_id = loc_id;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.rooms.AddOrUpdate(room);

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
                db.rooms.Remove(db.rooms.Where(x => x.room_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }

        private void location_change_button_Click(object sender, EventArgs e)
        {
            LocationSelector locationSelector = new LocationSelector();

            locationSelector.LocationSelectorClosed += LocationSelectorClosedHandle;

            locationSelector.ShowDialog();
        }

        private void LocationSelectorClosedHandle(object sender, int id)
        {
            loc_id = id;

            if (loc_id == 0)
            {
                return;
            }

            loadLocationText();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    room = db.rooms.Where(x => x.room_id == localId).First();
                }

                if (room == null)
                {
                    MessageBox.Show("The select room wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                room_text.Text = room.room;
                loc_id = room.location_id;

                loadLocationText();
            }
            else
            {
                room = new rooms();
            }
        }

        private void loadLocationText()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                locations loc = db.locations.Where(x => x.loc_id == loc_id).First();

                if (loc == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                location_text.Text = $"{loc.name}";
            }
        }
    }
}
