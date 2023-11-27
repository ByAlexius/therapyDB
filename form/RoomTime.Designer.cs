namespace therapyDB.form
{
    partial class RoomTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTime));
            this.time_change_button = new System.Windows.Forms.Button();
            this.time_text = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.room_text = new System.Windows.Forms.TextBox();
            this.room_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.room_change_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time_change_button
            // 
            this.time_change_button.Location = new System.Drawing.Point(451, 38);
            this.time_change_button.Name = "time_change_button";
            this.time_change_button.Size = new System.Drawing.Size(75, 23);
            this.time_change_button.TabIndex = 28;
            this.time_change_button.Text = "Change";
            this.time_change_button.UseVisualStyleBackColor = true;
            this.time_change_button.Click += new System.EventHandler(this.time_change_button_Click);
            // 
            // time_text
            // 
            this.time_text.Enabled = false;
            this.time_text.Location = new System.Drawing.Point(298, 38);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(147, 20);
            this.time_text.TabIndex = 27;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(343, 22);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(30, 13);
            this.time_label.TabIndex = 26;
            this.time_label.Text = "Time";
            // 
            // room_text
            // 
            this.room_text.Enabled = false;
            this.room_text.Location = new System.Drawing.Point(36, 38);
            this.room_text.Name = "room_text";
            this.room_text.Size = new System.Drawing.Size(152, 20);
            this.room_text.TabIndex = 25;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Location = new System.Drawing.Point(83, 22);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(35, 13);
            this.room_label.TabIndex = 24;
            this.room_label.Text = "Room";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(298, 83);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(228, 23);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(36, 83);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(233, 23);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // room_change_button
            // 
            this.room_change_button.Location = new System.Drawing.Point(194, 35);
            this.room_change_button.Name = "room_change_button";
            this.room_change_button.Size = new System.Drawing.Size(75, 23);
            this.room_change_button.TabIndex = 29;
            this.room_change_button.Text = "Change";
            this.room_change_button.UseVisualStyleBackColor = true;
            this.room_change_button.Click += new System.EventHandler(this.room_change_button_Click);
            // 
            // RoomTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 134);
            this.Controls.Add(this.room_change_button);
            this.Controls.Add(this.time_change_button);
            this.Controls.Add(this.time_text);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.room_text);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomTime";
            this.Text = "TMS - Room Time";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomTime_FormClosed);
            this.Load += new System.EventHandler(this.RoomTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button time_change_button;
        private System.Windows.Forms.TextBox time_text;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.TextBox room_text;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button room_change_button;
    }
}