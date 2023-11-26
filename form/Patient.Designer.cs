namespace therapyDB.form
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.save_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.firstname_label = new System.Windows.Forms.Label();
            this.firstname_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.lastname_text = new System.Windows.Forms.TextBox();
            this.lastname_label = new System.Windows.Forms.Label();
            this.meetings_label = new System.Windows.Forms.Label();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.open_button = new System.Windows.Forms.Button();
            this.address_change_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(66, 255);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(194, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(391, 255);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(194, 23);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(63, 55);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(52, 13);
            this.firstname_label.TabIndex = 2;
            this.firstname_label.Text = "Firstname";
            // 
            // firstname_text
            // 
            this.firstname_text.Location = new System.Drawing.Point(16, 71);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(152, 20);
            this.firstname_text.TabIndex = 3;
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(16, 163);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(232, 20);
            this.address_text.TabIndex = 5;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(63, 147);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // lastname_text
            // 
            this.lastname_text.Location = new System.Drawing.Point(260, 71);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.Size = new System.Drawing.Size(152, 20);
            this.lastname_text.TabIndex = 7;
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(307, 55);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(53, 13);
            this.lastname_label.TabIndex = 6;
            this.lastname_label.Text = "Lastname";
            // 
            // meetings_label
            // 
            this.meetings_label.AutoSize = true;
            this.meetings_label.Location = new System.Drawing.Point(480, 133);
            this.meetings_label.Name = "meetings_label";
            this.meetings_label.Size = new System.Drawing.Size(50, 13);
            this.meetings_label.TabIndex = 8;
            this.meetings_label.Text = "Meetings";
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(498, 71);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(152, 20);
            this.phone_text.TabIndex = 11;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(545, 55);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(38, 13);
            this.phone_label.TabIndex = 10;
            this.phone_label.Text = "Phone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(628, 160);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 13;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // address_change_button
            // 
            this.address_change_button.Location = new System.Drawing.Point(263, 163);
            this.address_change_button.Name = "address_change_button";
            this.address_change_button.Size = new System.Drawing.Size(75, 23);
            this.address_change_button.TabIndex = 14;
            this.address_change_button.Text = "Change";
            this.address_change_button.UseVisualStyleBackColor = true;
            this.address_change_button.Click += new System.EventHandler(this.address_change_button_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 296);
            this.Controls.Add(this.address_change_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.meetings_label);
            this.Controls.Add(this.lastname_text);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.firstname_text);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patient";
            this.Text = "PLACEHOLDER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Patient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.TextBox firstname_text;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox lastname_text;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label meetings_label;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button address_change_button;
    }
}