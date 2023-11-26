namespace therapyDB.form
{
    partial class Therapists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Therapists));
            this.create_button = new System.Windows.Forms.Button();
            this.Therapists_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Therapists_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(294, 16);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(214, 23);
            this.create_button.TabIndex = 3;
            this.create_button.Text = "New Therapist";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Therapists_datagrid
            // 
            this.Therapists_datagrid.AllowUserToAddRows = false;
            this.Therapists_datagrid.AllowUserToDeleteRows = false;
            this.Therapists_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Therapists_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Therapists_datagrid.Location = new System.Drawing.Point(12, 45);
            this.Therapists_datagrid.Name = "Therapists_datagrid";
            this.Therapists_datagrid.ReadOnly = true;
            this.Therapists_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Therapists_datagrid.TabIndex = 2;
            this.Therapists_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Therapists_datagrid_CellContentClick);
            // 
            // Therapists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Therapists_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Therapists";
            this.Text = "TMS - Therapists";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Therapists_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Therapists_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Therapists_datagrid;
    }
}