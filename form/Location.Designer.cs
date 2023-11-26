namespace therapyDB.form
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.address_change_button = new System.Windows.Forms.Button();
            this.address_text = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address_change_button
            // 
            this.address_change_button.Location = new System.Drawing.Point(424, 37);
            this.address_change_button.Name = "address_change_button";
            this.address_change_button.Size = new System.Drawing.Size(75, 23);
            this.address_change_button.TabIndex = 21;
            this.address_change_button.Text = "Change";
            this.address_change_button.UseVisualStyleBackColor = true;
            this.address_change_button.Click += new System.EventHandler(this.address_change_button_Click);
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(262, 37);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(147, 20);
            this.address_text.TabIndex = 20;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(307, 21);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 19;
            this.address_label.Text = "Address";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(36, 37);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(152, 20);
            this.name_text.TabIndex = 18;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(83, 21);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Name";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(249, 82);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(194, 23);
            this.delete_button.TabIndex = 16;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 82);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(194, 23);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 137);
            this.Controls.Add(this.address_change_button);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location";
            this.Text = "TMS - Location";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Location_FormClosed);
            this.Load += new System.EventHandler(this.Location_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button address_change_button;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
    }
}