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
    public partial class AddressSelector : Form
    {
        public event EventHandler<int> PatientAddressSelectorClosed;

        private int address_id = 0;

        public AddressSelector()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PatientAddressSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientAddressSelectorClosed?.Invoke(this, address_id);

            this.Dispose();
            GC.Collect();
        }

        private void PopulateDataGridView()
        {
            dataGridView.Columns.Clear();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                var data = db.addresses.OrderBy(e => e.add_id).Select(e => new
                {
                    e.add_id,
                    e.city,
                    e.postal,
                    e.street,
                    e.nr
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

                address_id = id ?? 0; // won't ever be 0 but needs to be set because of C#'s stupid conversion of int? to int
                this.Close();
            }
        }

        private void new_address_button_Click(object sender, EventArgs e)
        {
            Address newAddress = new Address(0);

            newAddress.NewAddressClosed += newAddressClosedHandle;

            newAddress.ShowDialog();
        }

        private void newAddressClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }
    }
}
