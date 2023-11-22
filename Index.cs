using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapyDB
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            using (var context = new TherapyDBContext())
            {
                var patients = context.Patients.ToList();

                foreach (var patient in patients)
                {
                    Console.WriteLine($"Patient ID: {patient.Id}, Name: {patient.FirstName} {patient.LastName}");
                }
            }
        }

        private void copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ByAlexius");
        }
    }
}
