namespace therapyDB
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.patient_files = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.therapist_button = new System.Windows.Forms.Button();
            this.locations_buttons = new System.Windows.Forms.Button();
            this.times_button = new System.Windows.Forms.Button();
            this.treatments_button = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.meetings_button = new System.Windows.Forms.Button();
            this.address_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient_files
            // 
            this.patient_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_files.Location = new System.Drawing.Point(80, 211);
            this.patient_files.Name = "patient_files";
            this.patient_files.Size = new System.Drawing.Size(154, 51);
            this.patient_files.TabIndex = 0;
            this.patient_files.Text = "Patient files";
            this.patient_files.UseVisualStyleBackColor = true;
            this.patient_files.Click += new System.EventHandler(this.patient_files_Click);
            // 
            // copyright
            // 
            this.copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(12, 428);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(123, 13);
            this.copyright.TabIndex = 1;
            this.copyright.Text = "2023 © Alexander Rziha";
            this.copyright.Click += new System.EventHandler(this.copyright_Click);
            // 
            // therapist_button
            // 
            this.therapist_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.therapist_button.Location = new System.Drawing.Point(336, 211);
            this.therapist_button.Name = "therapist_button";
            this.therapist_button.Size = new System.Drawing.Size(154, 51);
            this.therapist_button.TabIndex = 2;
            this.therapist_button.Text = "Therapists";
            this.therapist_button.UseVisualStyleBackColor = true;
            this.therapist_button.Click += new System.EventHandler(this.therapist_button_Click);
            // 
            // locations_buttons
            // 
            this.locations_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locations_buttons.Location = new System.Drawing.Point(573, 211);
            this.locations_buttons.Name = "locations_buttons";
            this.locations_buttons.Size = new System.Drawing.Size(154, 51);
            this.locations_buttons.TabIndex = 3;
            this.locations_buttons.Text = "Locations";
            this.locations_buttons.UseVisualStyleBackColor = true;
            this.locations_buttons.Click += new System.EventHandler(this.locations_buttons_Click);
            // 
            // times_button
            // 
            this.times_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.times_button.Location = new System.Drawing.Point(453, 309);
            this.times_button.Name = "times_button";
            this.times_button.Size = new System.Drawing.Size(154, 51);
            this.times_button.TabIndex = 4;
            this.times_button.Text = "Times";
            this.times_button.UseVisualStyleBackColor = true;
            this.times_button.Click += new System.EventHandler(this.times_button_Click);
            // 
            // treatments_button
            // 
            this.treatments_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treatments_button.Location = new System.Drawing.Point(209, 309);
            this.treatments_button.Name = "treatments_button";
            this.treatments_button.Size = new System.Drawing.Size(154, 51);
            this.treatments_button.TabIndex = 5;
            this.treatments_button.Text = "Treatments";
            this.treatments_button.UseVisualStyleBackColor = true;
            this.treatments_button.Click += new System.EventHandler(this.treatments_button_Click);
            // 
            // welcome
            // 
            this.welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(314, 41);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(212, 25);
            this.welcome.TabIndex = 6;
            this.welcome.Text = "Welcome to the TMS";
            // 
            // meetings_button
            // 
            this.meetings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.meetings_button.Location = new System.Drawing.Point(209, 116);
            this.meetings_button.Name = "meetings_button";
            this.meetings_button.Size = new System.Drawing.Size(154, 51);
            this.meetings_button.TabIndex = 8;
            this.meetings_button.Text = "Meetings";
            this.meetings_button.UseVisualStyleBackColor = true;
            // 
            // address_button
            // 
            this.address_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.address_button.Location = new System.Drawing.Point(453, 116);
            this.address_button.Name = "address_button";
            this.address_button.Size = new System.Drawing.Size(154, 51);
            this.address_button.TabIndex = 7;
            this.address_button.Text = "Addresses";
            this.address_button.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meetings_button);
            this.Controls.Add(this.address_button);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.treatments_button);
            this.Controls.Add(this.times_button);
            this.Controls.Add(this.locations_buttons);
            this.Controls.Add(this.therapist_button);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.patient_files);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS - Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patient_files;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Button therapist_button;
        private System.Windows.Forms.Button locations_buttons;
        private System.Windows.Forms.Button times_button;
        private System.Windows.Forms.Button treatments_button;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button meetings_button;
        private System.Windows.Forms.Button address_button;
    }
}