using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB.form
{
    public partial class TimeSelector : Form
    {
        public event EventHandler<int> TimeSelectorClosed;

        private int time_id = 0;

        public TimeSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.times.OrderBy(e => e.time_id).Select(e => new
                {
                    e.time_id,
                    e.time,
                    e.date
                }).ToList();

                dataGridView.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
                {
                    item.ReadOnly = true;
                }
            }
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

                time_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }

        private void new_time_button_Click(object sender, EventArgs e)
        {
            Time time = new Time(0);
            time.TimeClosed += TimeClosedHandle;
            time.Show();
        }

        private void TimeClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void TimeSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeSelectorClosed?.Invoke(this, time_id);

            this.Dispose();
            GC.Collect();
        }
    }
}
