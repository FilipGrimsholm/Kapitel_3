namespace Övning_3_1
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
            this.btnVäljFärg = new System.Windows.Forms.Button();
            this.btnBrowserDialog = new System.Windows.Forms.Button();
            this.btnVäljTeckensnitt = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnVäljFärg
            // 
            this.btnVäljFärg.Location = new System.Drawing.Point(322, 122);
            this.btnVäljFärg.Name = "btnVäljFärg";
            this.btnVäljFärg.Size = new System.Drawing.Size(103, 23);
            this.btnVäljFärg.TabIndex = 0;
            this.btnVäljFärg.Text = "Välj en färg";
            this.btnVäljFärg.UseVisualStyleBackColor = true;
            this.btnVäljFärg.Click += new System.EventHandler(this.btnVäljFärg_Click);
            // 
            // btnBrowserDialog
            // 
            this.btnBrowserDialog.Location = new System.Drawing.Point(322, 152);
            this.btnBrowserDialog.Name = "btnBrowserDialog";
            this.btnBrowserDialog.Size = new System.Drawing.Size(103, 23);
            this.btnBrowserDialog.TabIndex = 1;
            this.btnBrowserDialog.Text = "Välj mapp";
            this.btnBrowserDialog.UseVisualStyleBackColor = true;
            this.btnBrowserDialog.Click += new System.EventHandler(this.btnBrowserDialog_Click);
            // 
            // btnVäljTeckensnitt
            // 
            this.btnVäljTeckensnitt.Location = new System.Drawing.Point(322, 181);
            this.btnVäljTeckensnitt.Name = "btnVäljTeckensnitt";
            this.btnVäljTeckensnitt.Size = new System.Drawing.Size(103, 23);
            this.btnVäljTeckensnitt.TabIndex = 2;
            this.btnVäljTeckensnitt.Text = "Välj teckensnitt";
            this.btnVäljTeckensnitt.UseVisualStyleBackColor = true;
            this.btnVäljTeckensnitt.Click += new System.EventHandler(this.btnVäljTeckensnitt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVäljTeckensnitt);
            this.Controls.Add(this.btnBrowserDialog);
            this.Controls.Add(this.btnVäljFärg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVäljFärg;
        private System.Windows.Forms.Button btnBrowserDialog;
        private System.Windows.Forms.Button btnVäljTeckensnitt;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowser;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

