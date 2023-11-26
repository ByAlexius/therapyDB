namespace therapyDB.form
{
    partial class Addresses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addresses));
            this.create_button = new System.Windows.Forms.Button();
            this.Addresses_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Addresses_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(274, 16);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(251, 23);
            this.create_button.TabIndex = 9;
            this.create_button.Text = "New Address";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Addresses_datagrid
            // 
            this.Addresses_datagrid.AllowUserToAddRows = false;
            this.Addresses_datagrid.AllowUserToDeleteRows = false;
            this.Addresses_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Addresses_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Addresses_datagrid.Location = new System.Drawing.Point(12, 45);
            this.Addresses_datagrid.Name = "Addresses_datagrid";
            this.Addresses_datagrid.ReadOnly = true;
            this.Addresses_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Addresses_datagrid.TabIndex = 8;
            this.Addresses_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Addresses_datagrid_CellMouseDoubleClick);
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Addresses_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Addresses";
            this.Text = "TMS - Addresses";
            ((System.ComponentModel.ISupportInitialize)(this.Addresses_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Addresses_datagrid;
    }
}