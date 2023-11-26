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
    public partial class Meetings : Form
    {
        public Meetings()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            Meetings_datagrid.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.meetings.OrderBy(e => e.meet_id).Select(e => new
                {
                    e.meet_id,
                    e.patient_id,
                    e.room_time_id,
                    e.therapist_treatment_id
                }).ToList();

                Meetings_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Meetings_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Meetings_Load(object sender, EventArgs e)
        {

        }

        private void Meetings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void Meetings_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Meetings_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Meeting meeting = new Meeting(id ?? 0);

                meeting.MeetingClosed += MeetingFormClosedHandle;

                meeting.ShowDialog();
            }
        }

        private void MeetingFormClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Meeting meeting = new Meeting(0);

            meeting.MeetingClosed += MeetingFormClosedHandle;

            meeting.ShowDialog();
        }
    }
}
