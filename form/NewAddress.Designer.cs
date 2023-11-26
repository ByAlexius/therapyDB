namespace therapyDB.form
{
    partial class NewAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAddress));
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.city_text = new System.Windows.Forms.TextBox();
            this.postal_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nr_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.street_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(196, 222);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(181, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // city_text
            // 
            this.city_text.Location = new System.Drawing.Point(72, 70);
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(180, 20);
            this.city_text.TabIndex = 2;
            // 
            // postal_text
            // 
            this.postal_text.Location = new System.Drawing.Point(318, 70);
            this.postal_text.Name = "postal_text";
            this.postal_text.Size = new System.Drawing.Size(180, 20);
            this.postal_text.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Postal";
            // 
            // nr_text
            // 
            this.nr_text.Location = new System.Drawing.Point(318, 158);
            this.nr_text.Name = "nr_text";
            this.nr_text.Size = new System.Drawing.Size(180, 20);
            this.nr_text.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "House Nr";
            // 
            // street_text
            // 
            this.street_text.Location = new System.Drawing.Point(72, 158);
            this.street_text.Name = "street_text";
            this.street_text.Size = new System.Drawing.Size(180, 20);
            this.street_text.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street";
            // 
            // NewAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 266);
            this.Controls.Add(this.nr_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.street_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postal_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.city_text);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAddress";
            this.Text = "TMS - New Address";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewAddress_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox city_text;
        private System.Windows.Forms.TextBox postal_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nr_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox street_text;
        private System.Windows.Forms.Label label4;
    }
}