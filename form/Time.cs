using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class Time : Form
    {
        public event EventHandler<bool> TimeClosed;

        private times time;

        private int localId;

        public Time(int id)
        {
            localId = id;
            InitializeComponent();
            loadTime();

            if (localId == 0)
            {
                delete_button.Enabled = false;
            }
        }

        private void loadTime()
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    time = db.times.Where(x => x.time_id == localId).First();
                }

                dateTimePicker.Value = time.date + time.time;
            } 
            else
            {
                time = new times();
            }
        }

        private void Time_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeClosed?.Invoke(this, true);

            this.Dispose();
            GC.Collect();
        }

        private (DateTime Date, TimeSpan Time)? retreiveTimeAndDate()
        {
            if (dateTimePicker.Value == null)
            {
                return null;
            }

            return (dateTimePicker.Value.Date, dateTimePicker.Value.TimeOfDay);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Value == null)
            {
                MessageBox.Show("Please enter a date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = retreiveTimeAndDate();

            if (result == null)
            {
                MessageBox.Show("An error accoured while trying to retreive the data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            time.date = result.Value.Date;
            time.time = result.Value.Time;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.times.AddOrUpdate(time);

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
                db.times.Remove(db.times.Where(x => x.time_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }
    }
}
