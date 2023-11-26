namespace therapyDB.form
{
    partial class RoomTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTimes));
            this.create_button = new System.Windows.Forms.Button();
            this.RoomTime_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTime_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(294, 16);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(214, 23);
            this.create_button.TabIndex = 5;
            this.create_button.Text = "New Room Time";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // RoomTime_datagrid
            // 
            this.RoomTime_datagrid.AllowUserToAddRows = false;
            this.RoomTime_datagrid.AllowUserToDeleteRows = false;
            this.RoomTime_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.RoomTime_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomTime_datagrid.Location = new System.Drawing.Point(12, 45);
            this.RoomTime_datagrid.Name = "RoomTime_datagrid";
            this.RoomTime_datagrid.ReadOnly = true;
            this.RoomTime_datagrid.Size = new System.Drawing.Size(776, 390);
            this.RoomTime_datagrid.TabIndex = 4;
            this.RoomTime_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomTime_datagrid_CellMouseDoubleClick);
            // 
            // RoomTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.RoomTime_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomTimes";
            this.Text = "TMS - Room Times";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomTimes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTime_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView RoomTime_datagrid;
    }
}