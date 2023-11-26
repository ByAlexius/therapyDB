namespace therapyDB.form
{
    partial class Times
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Times));
            this.create_button = new System.Windows.Forms.Button();
            this.Times_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Times_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(295, 12);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(226, 23);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "New Time Record";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Times_datagrid
            // 
            this.Times_datagrid.AllowUserToAddRows = false;
            this.Times_datagrid.AllowUserToDeleteRows = false;
            this.Times_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Times_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Times_datagrid.Location = new System.Drawing.Point(12, 48);
            this.Times_datagrid.Name = "Times_datagrid";
            this.Times_datagrid.ReadOnly = true;
            this.Times_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Times_datagrid.TabIndex = 5;
            this.Times_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Times_datagrid_CellMouseDoubleClick);
            // 
            // Times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Times_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Times";
            this.Text = "TMS - Times";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Times_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Times_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Times_datagrid;
    }
}