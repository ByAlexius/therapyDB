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
    public partial class Addresses : Form
    {
        public Addresses()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Addresses_datagrid.Columns.Clear();

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

                Addresses_datagrid.DataSource = data;

                foreach (DataGridViewTextBoxColumn item in Addresses_datagrid.Columns)
                {
                    item.ReadOnly = true;
                }
            }
        }

        private void Addresses_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int? id = (int)Addresses_datagrid.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == 0)
                {
                    MessageBox.Show("Please select an valid row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Address newAddress = new Address(id ?? 0);

                newAddress.NewAddressClosed += newAddressClosedHandle;

                newAddress.ShowDialog();
            }
        }

        private void newAddressClosedHandle(object sender, bool e)
        {
            PopulateDataGridView();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Address newAddress = new Address(0);

            newAddress.NewAddressClosed += newAddressClosedHandle;

            newAddress.ShowDialog();
        }
    }
}
