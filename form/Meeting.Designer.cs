namespace therapyDB.form
{
    partial class Meeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meeting));
            this.patient_change_button = new System.Windows.Forms.Button();
            this.room_time_change_button = new System.Windows.Forms.Button();
            this.room_time_text = new System.Windows.Forms.TextBox();
            this.room_time_label = new System.Windows.Forms.Label();
            this.patient_text = new System.Windows.Forms.TextBox();
            this.patient_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.treatment_button = new System.Windows.Forms.Button();
            this.treatment_text = new System.Windows.Forms.TextBox();
            this.treatment_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patient_change_button
            // 
            this.patient_change_button.Location = new System.Drawing.Point(179, 33);
            this.patient_change_button.Name = "patient_change_button";
            this.patient_change_button.Size = new System.Drawing.Size(75, 23);
            this.patient_change_button.TabIndex = 37;
            this.patient_change_button.Text = "Change";
            this.patient_change_button.UseVisualStyleBackColor = true;
            this.patient_change_button.Click += new System.EventHandler(this.patient_change_button_Click);
            // 
            // room_time_change_button
            // 
            this.room_time_change_button.Location = new System.Drawing.Point(436, 36);
            this.room_time_change_button.Name = "room_time_change_button";
            this.room_time_change_button.Size = new System.Drawing.Size(75, 23);
            this.room_time_change_button.TabIndex = 36;
            this.room_time_change_button.Text = "Change";
            this.room_time_change_button.UseVisualStyleBackColor = true;
            this.room_time_change_button.Click += new System.EventHandler(this.room_time_change_button_Click);
            // 
            // room_time_text
            // 
            this.room_time_text.Enabled = false;
            this.room_time_text.Location = new System.Drawing.Point(283, 36);
            this.room_time_text.Name = "room_time_text";
            this.room_time_text.Size = new System.Drawing.Size(147, 20);
            this.room_time_text.TabIndex = 35;
            // 
            // room_time_label
            // 
            this.room_time_label.AutoSize = true;
            this.room_time_label.Location = new System.Drawing.Point(334, 20);
            this.room_time_label.Name = "room_time_label";
            this.room_time_label.Size = new System.Drawing.Size(61, 13);
            this.room_time_label.TabIndex = 34;
            this.room_time_label.Text = "Room Time";
            // 
            // patient_text
            // 
            this.patient_text.Enabled = false;
            this.patient_text.Location = new System.Drawing.Point(21, 36);
            this.patient_text.Name = "patient_text";
            this.patient_text.Size = new System.Drawing.Size(152, 20);
            this.patient_text.TabIndex = 33;
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Location = new System.Drawing.Point(68, 20);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(40, 13);
            this.patient_label.TabIndex = 32;
            this.patient_label.Text = "Patient";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(283, 127);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(228, 23);
            this.delete_button.TabIndex = 31;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(21, 127);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(233, 23);
            this.save_button.TabIndex = 30;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // treatment_button
            // 
            this.treatment_button.Location = new System.Drawing.Point(337, 86);
            this.treatment_button.Name = "treatment_button";
            this.treatment_button.Size = new System.Drawing.Size(75, 23);
            this.treatment_button.TabIndex = 40;
            this.treatment_button.Text = "Change";
            this.treatment_button.UseVisualStyleBackColor = true;
            this.treatment_button.Click += new System.EventHandler(this.treatment_button_Click);
            // 
            // treatment_text
            // 
            this.treatment_text.Enabled = false;
            this.treatment_text.Location = new System.Drawing.Point(179, 89);
            this.treatment_text.Name = "treatment_text";
            this.treatment_text.Size = new System.Drawing.Size(152, 20);
            this.treatment_text.TabIndex = 39;
            // 
            // treatment_label
            // 
            this.treatment_label.AutoSize = true;
            this.treatment_label.Location = new System.Drawing.Point(232, 73);
            this.treatment_label.Name = "treatment_label";
            this.treatment_label.Size = new System.Drawing.Size(55, 13);
            this.treatment_label.TabIndex = 38;
            this.treatment_label.Text = "Treatment";
            // 
            // Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 162);
            this.Controls.Add(this.treatment_button);
            this.Controls.Add(this.treatment_text);
            this.Controls.Add(this.treatment_label);
            this.Controls.Add(this.patient_change_button);
            this.Controls.Add(this.room_time_change_button);
            this.Controls.Add(this.room_time_text);
            this.Controls.Add(this.room_time_label);
            this.Controls.Add(this.patient_text);
            this.Controls.Add(this.patient_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meeting";
            this.Text = "TMS - Meeting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Meeting_FormClosed);
            this.Load += new System.EventHandler(this.Meeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patient_change_button;
        private System.Windows.Forms.Button room_time_change_button;
        private System.Windows.Forms.TextBox room_time_text;
        private System.Windows.Forms.Label room_time_label;
        private System.Windows.Forms.TextBox patient_text;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button treatment_button;
        private System.Windows.Forms.TextBox treatment_text;
        private System.Windows.Forms.Label treatment_label;
    }
}