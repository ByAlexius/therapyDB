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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patient_files
            // 
            this.patient_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_files.Location = new System.Drawing.Point(84, 146);
            this.patient_files.Name = "patient_files";
            this.patient_files.Size = new System.Drawing.Size(154, 51);
            this.patient_files.TabIndex = 0;
            this.patient_files.Text = "Patient files";
            this.patient_files.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(340, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Therapists";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(577, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Locations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(457, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Times";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(213, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Treatments";
            this.button4.UseVisualStyleBackColor = true;
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
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label welcome;
    }
}