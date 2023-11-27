namespace therapyDB.form
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.location_change_button = new System.Windows.Forms.Button();
            this.location_text = new System.Windows.Forms.TextBox();
            this.location_label = new System.Windows.Forms.Label();
            this.room_text = new System.Windows.Forms.TextBox();
            this.room_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // location_change_button
            // 
            this.location_change_button.Location = new System.Drawing.Point(432, 36);
            this.location_change_button.Name = "location_change_button";
            this.location_change_button.Size = new System.Drawing.Size(75, 23);
            this.location_change_button.TabIndex = 28;
            this.location_change_button.Text = "Change";
            this.location_change_button.UseVisualStyleBackColor = true;
            this.location_change_button.Click += new System.EventHandler(this.location_change_button_Click);
            // 
            // location_text
            // 
            this.location_text.Enabled = false;
            this.location_text.Location = new System.Drawing.Point(270, 36);
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(147, 20);
            this.location_text.TabIndex = 27;
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Location = new System.Drawing.Point(315, 20);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(48, 13);
            this.location_label.TabIndex = 26;
            this.location_label.Text = "Location";
            // 
            // room_text
            // 
            this.room_text.Location = new System.Drawing.Point(44, 36);
            this.room_text.Name = "room_text";
            this.room_text.Size = new System.Drawing.Size(152, 20);
            this.room_text.TabIndex = 25;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Location = new System.Drawing.Point(99, 20);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(35, 13);
            this.room_label.TabIndex = 24;
            this.room_label.Text = "Room";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(257, 81);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(194, 23);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(20, 81);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(194, 23);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 119);
            this.Controls.Add(this.location_change_button);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.location_label);
            this.Controls.Add(this.room_text);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Room";
            this.Text = "TMS - Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Room_FormClosed);
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button location_change_button;
        private System.Windows.Forms.TextBox location_text;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.TextBox room_text;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
    }
}