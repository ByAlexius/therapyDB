using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.form;

namespace therapyDB
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ByAlexius");
        }

        private void patient_files_Click(object sender, EventArgs e)
        {
            new Patients().Show();
        }

        private void therapist_button_Click(object sender, EventArgs e)
        {
            new Therapists().Show();
        }

        private void locations_buttons_Click(object sender, EventArgs e)
        {
            new Locations().Show();
        }

        private void treatments_button_Click(object sender, EventArgs e)
        {
            new Treatments().Show();
        }

        private void times_button_Click(object sender, EventArgs e)
        {
            new Times().Show();
        }

        private void address_button_Click(object sender, EventArgs e)
        {
            new Addresses().Show();
        }

        private void meetings_button_Click(object sender, EventArgs e)
        {
            new Meetings().Show();
        }

        private void room_button_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
        }
    }
}
