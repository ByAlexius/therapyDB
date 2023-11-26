namespace therapyDB.form
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.Patients_datagrid = new System.Windows.Forms.DataGridView();
            this.create_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Patients_datagrid
            // 
            this.Patients_datagrid.AllowUserToAddRows = false;
            this.Patients_datagrid.AllowUserToDeleteRows = false;
            this.Patients_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Patients_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patients_datagrid.Location = new System.Drawing.Point(12, 48);
            this.Patients_datagrid.Name = "Patients_datagrid";
            this.Patients_datagrid.ReadOnly = true;
            this.Patients_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Patients_datagrid.TabIndex = 0;
            this.Patients_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Patients_datagrid_CellMouseDoubleClick);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(294, 19);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(214, 23);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "New Patient";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Patients_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patients";
            this.Text = "TMS - Patients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Patients_FormClosed);
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patients_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Patients_datagrid;
        private System.Windows.Forms.Button create_button;
    }
}