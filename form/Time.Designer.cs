namespace therapyDB.form
{
    partial class Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time));
            this.delete_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(235, 71);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(181, 23);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date and Time";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(23, 71);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(181, 23);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(118, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 117);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Time";
            this.Text = "TMS - Time";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Time_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}