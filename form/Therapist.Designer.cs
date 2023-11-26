namespace therapyDB.form
{
    partial class Therapist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Therapist));
            this.lastname_text = new System.Windows.Forms.TextBox();
            this.lastname_label = new System.Windows.Forms.Label();
            this.firstname_text = new System.Windows.Forms.TextBox();
            this.firstname_label = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastname_text
            // 
            this.lastname_text.Location = new System.Drawing.Point(221, 33);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.Size = new System.Drawing.Size(152, 20);
            this.lastname_text.TabIndex = 15;
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(273, 17);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(53, 13);
            this.lastname_label.TabIndex = 14;
            this.lastname_label.Text = "Lastname";
            // 
            // firstname_text
            // 
            this.firstname_text.Location = new System.Drawing.Point(29, 33);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(152, 20);
            this.firstname_text.TabIndex = 13;
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(76, 17);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(52, 13);
            this.firstname_label.TabIndex = 12;
            this.firstname_label.Text = "Firstname";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(221, 103);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(152, 20);
            this.email_text.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "E-Mail";
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(29, 103);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(152, 20);
            this.phone_text.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phone";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(221, 153);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(152, 23);
            this.delete_button.TabIndex = 21;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(29, 153);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(152, 23);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Therapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 203);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastname_text);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.firstname_text);
            this.Controls.Add(this.firstname_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Therapist";
            this.Text = "TMS - Therapist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Therapist_FormClosed);
            this.Load += new System.EventHandler(this.Therapist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastname_text;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.TextBox firstname_text;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
    }
}