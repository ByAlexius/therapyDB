namespace therapyDB.form
{
    partial class Locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locations));
            this.create_button = new System.Windows.Forms.Button();
            this.Locations_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Locations_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(274, 19);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(251, 23);
            this.create_button.TabIndex = 7;
            this.create_button.Text = "New Location";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Locations_datagrid
            // 
            this.Locations_datagrid.AllowUserToAddRows = false;
            this.Locations_datagrid.AllowUserToDeleteRows = false;
            this.Locations_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Locations_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Locations_datagrid.Location = new System.Drawing.Point(12, 48);
            this.Locations_datagrid.Name = "Locations_datagrid";
            this.Locations_datagrid.ReadOnly = true;
            this.Locations_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Locations_datagrid.TabIndex = 6;
            this.Locations_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Locations_datagrid_CellMouseDoubleClick);
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Locations_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Locations";
            this.Text = "TMS - Locations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Locations_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Locations_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Locations_datagrid;
    }
}