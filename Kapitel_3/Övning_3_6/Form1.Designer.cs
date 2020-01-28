namespace Övning_3_6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnTeckensnitt = new System.Windows.Forms.Button();
            this.radbtnLeft = new System.Windows.Forms.RadioButton();
            this.radbtnCenter = new System.Windows.Forms.RadioButton();
            this.radbtnRight = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeckensnitt
            // 
            this.btnTeckensnitt.Location = new System.Drawing.Point(13, 13);
            this.btnTeckensnitt.Name = "btnTeckensnitt";
            this.btnTeckensnitt.Size = new System.Drawing.Size(75, 23);
            this.btnTeckensnitt.TabIndex = 0;
            this.btnTeckensnitt.Text = "Teckensnitt";
            this.btnTeckensnitt.UseVisualStyleBackColor = true;
            // 
            // radbtnLeft
            // 
            this.radbtnLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.radbtnLeft.AutoSize = true;
            this.radbtnLeft.Location = new System.Drawing.Point(108, 13);
            this.radbtnLeft.Name = "radbtnLeft";
            this.radbtnLeft.Size = new System.Drawing.Size(35, 23);
            this.radbtnLeft.TabIndex = 1;
            this.radbtnLeft.TabStop = true;
            this.radbtnLeft.Text = "Left";
            this.radbtnLeft.UseVisualStyleBackColor = true;
            // 
            // radbtnCenter
            // 
            this.radbtnCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radbtnCenter.AutoSize = true;
            this.radbtnCenter.Location = new System.Drawing.Point(149, 13);
            this.radbtnCenter.Name = "radbtnCenter";
            this.radbtnCenter.Size = new System.Drawing.Size(48, 23);
            this.radbtnCenter.TabIndex = 2;
            this.radbtnCenter.TabStop = true;
            this.radbtnCenter.Text = "Center";
            this.radbtnCenter.UseVisualStyleBackColor = true;
            // 
            // radbtnRight
            // 
            this.radbtnRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.radbtnRight.AutoSize = true;
            this.radbtnRight.Location = new System.Drawing.Point(203, 13);
            this.radbtnRight.Name = "radbtnRight";
            this.radbtnRight.Size = new System.Drawing.Size(42, 23);
            this.radbtnRight.TabIndex = 3;
            this.radbtnRight.TabStop = true;
            this.radbtnRight.Text = "Right";
            this.radbtnRight.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(262, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 378);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radbtnRight);
            this.Controls.Add(this.radbtnCenter);
            this.Controls.Add(this.radbtnLeft);
            this.Controls.Add(this.btnTeckensnitt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnTeckensnitt;
        private System.Windows.Forms.RadioButton radbtnLeft;
        private System.Windows.Forms.RadioButton radbtnCenter;
        private System.Windows.Forms.RadioButton radbtnRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

