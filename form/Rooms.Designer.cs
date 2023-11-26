namespace therapyDB.form
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.create_button = new System.Windows.Forms.Button();
            this.Rooms_datagrid = new System.Windows.Forms.DataGridView();
            this.room_times_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(486, 16);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(214, 23);
            this.create_button.TabIndex = 5;
            this.create_button.Text = "New Room";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Rooms_datagrid
            // 
            this.Rooms_datagrid.AllowUserToAddRows = false;
            this.Rooms_datagrid.AllowUserToDeleteRows = false;
            this.Rooms_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Rooms_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rooms_datagrid.Location = new System.Drawing.Point(12, 45);
            this.Rooms_datagrid.Name = "Rooms_datagrid";
            this.Rooms_datagrid.ReadOnly = true;
            this.Rooms_datagrid.Size = new System.Drawing.Size(776, 390);
            this.Rooms_datagrid.TabIndex = 4;
            this.Rooms_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Rooms_datagrid_CellMouseDoubleClick);
            // 
            // room_times_button
            // 
            this.room_times_button.Location = new System.Drawing.Point(102, 16);
            this.room_times_button.Name = "room_times_button";
            this.room_times_button.Size = new System.Drawing.Size(214, 23);
            this.room_times_button.TabIndex = 6;
            this.room_times_button.Text = "Show Room Times";
            this.room_times_button.UseVisualStyleBackColor = true;
            this.room_times_button.Click += new System.EventHandler(this.room_times_button_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.room_times_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Rooms_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rooms";
            this.Text = "TMS - Rooms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rooms_FormClosed);
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView Rooms_datagrid;
        private System.Windows.Forms.Button room_times_button;
    }
}