using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapyDB.form
{
    public partial class RoomTime : Form
    {
        public event EventHandler<bool> RoomTimeClosed;

        private int rt_id;

        public RoomTime(int id)
        {
            InitializeComponent();
        }

        private void RoomTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoomTimeClosed?.Invoke(this, true);

            Dispose();
            GC.Collect();
        }
    }
}
