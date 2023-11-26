namespace therapyDB.form
{
    partial class Treatments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treatments));
            this.create_button = new System.Windows.Forms.Button();
            this.Treatments_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Treatments_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(295, 12);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(226, 23);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "New Treatment";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Treatments_datagrid
            // 
            this.Treatments_datagrid.AllowUserToAddRows = false;
            this.Treatments_datagrid.AllowUserToDeleteRows = false;
            this.Treatments_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Treatments_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Treatments_datagrid.Location = new System.Drawing.Point(12, 48);
            this.Treatments_datagrid.Name = "Treatments_datagrid";
            this.Treatments_datagrid.ReadOnly = true;
            this.Treatments_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Treatments_datagrid.TabIndex = 3;
            this.Treatments_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Treatments_datagrid_CellMouseDoubleClick);
            // 
            // Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Treatments_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Treatments";
            this.Text = "TMS - Treatments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Treatments_FormClosed);
            this.Load += new System.EventHandler(this.Treatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Treatments_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Treatments_datagrid;
    }
}