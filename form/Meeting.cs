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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace therapyDB.form
{
    public partial class Meeting : Form
    {
        public event EventHandler<bool> MeetingClosed;

        private int localId;

        private meetings meeting;

        private int patient_id = 0;

        private int room_time_id = 0;

        private int treatment_id = 0;

        public Meeting(int id)
        {
            localId = id;
            InitializeComponent();
        }

        private void Meeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeetingClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            if (localId > 0)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    meeting = db.meetings.Where(x => x.meet_id == localId).First();
                }

                if (meeting == null)
                {
                    MessageBox.Show("The select meeting wasn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Dispose();
                    GC.Collect();
                    return;
                }

                patient_id = meeting.patient_id;
                room_time_id = meeting.room_time_id;
                treatment_id = meeting.therapist_treatment_id;

                loadPatient();
                loadRoomTime();
                loadTreatment();
            }
            else
            {
                meeting = new meetings();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (patient_id == 0)
            {
                MessageBox.Show("Please select a valid patient!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (room_time_id == 0)
            {
                MessageBox.Show("Please select a valid Room Time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (treatment_id == 0)
            {
                MessageBox.Show("Please select a valid Treatment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            meeting.patient_id = patient_id;
            meeting.room_time_id = room_time_id;
            meeting.therapist_treatment_id = treatment_id;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.meetings.AddOrUpdate(meeting);

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
                db.meetings.Remove(db.meetings.Where(x => x.meet_id == localId).First());

                db.SaveChanges();
            }

            Close();
        }

        private void patient_change_button_Click(object sender, EventArgs e)
        {
            PatientSelector selector = new PatientSelector();

            selector.PatientSelectorClosed += patientSelectorClosedHandle;

            selector.ShowDialog();
        }

        private void patientSelectorClosedHandle(object sender, int id)
        {
            patient_id = id;

            if (patient_id == 0)
            {
                return;
            }

            loadPatient();
        }

        private void loadPatient()
        {
           using (DatabaseEntities db = new DatabaseEntities())
            {
                patients patient = db.patients.Where(x => x.pat_id == patient_id).First();

                if (patient == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected patient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                patient_text.Text = $"{patient.firstname} {patient.lastname}";
            }
        }

        private void room_time_change_button_Click(object sender, EventArgs e)
        {
            RoomTimeSelector selector = new RoomTimeSelector();

            selector.RoomTimeSelectorClosed += roomTimeSelectorClosedHandle;

            selector.ShowDialog();
        }

        private void roomTimeSelectorClosedHandle(object sender, int id)
        {
            room_time_id = id;

            if (room_time_id == 0)
            {
                return;
            }

            loadRoomTime();
        }

        private void loadRoomTime()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                room_times rt = db.room_times.Where(x => x.rti_id == room_time_id).First();

                if (rt == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected room_times!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                patient_text.Text = $"RoomId: {rt.room_id}, TimeId: {rt.time_id}";
            }
        }

        private void treatment_button_Click(object sender, EventArgs e)
        {
            TreatmentSelector selector = new TreatmentSelector();

            selector.TreatmentSelectorClosed += treatmentSelectorClosedHandle;

            selector.ShowDialog();
        }

        private void treatmentSelectorClosedHandle(object sender, int id)
        {
            treatment_id = id;

            if (treatment_id == 0)
            {
                return;
            }

            loadTreatment();
        }

        private void loadTreatment()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                therapist_treatments tr = db.therapist_treatments.Where(x => x.ttr_id == treatment_id).First();

                if (tr == null)
                {
                    MessageBox.Show("There was an error loading the data from the selected therapist_treatments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                patient_text.Text = $"TherapistId: {tr.therapist_id}, TreatmentId: {tr.treatment_id}";
            }
        }
    }
}
