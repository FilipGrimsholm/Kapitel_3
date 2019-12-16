namespace Övning_3_2
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
            this.mnsChoose = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.lblTruth = new System.Windows.Forms.Label();
            this.revealTheTruthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsChoose
            // 
            this.mnsChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigeraToolStripMenuItem});
            this.mnsChoose.Location = new System.Drawing.Point(0, 0);
            this.mnsChoose.Name = "mnsChoose";
            this.mnsChoose.Size = new System.Drawing.Size(800, 24);
            this.mnsChoose.TabIndex = 0;
            this.mnsChoose.Text = "Redigera";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem,
            this.revealTheTruthToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj Färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.väljFärgToolStripMenuItem_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljMappToolStripMenuItem.Text = "Välj Mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.väljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj Teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.väljTeckensnittToolStripMenuItem_Click);
            // 
            // lblTruth
            // 
            this.lblTruth.AutoSize = true;
            this.lblTruth.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruth.Location = new System.Drawing.Point(180, 178);
            this.lblTruth.Name = "lblTruth";
            this.lblTruth.Size = new System.Drawing.Size(441, 73);
            this.lblTruth.TabIndex = 1;
            this.lblTruth.Text = "Hah, Felix gay";
            this.lblTruth.Visible = false;
            // 
            // revealTheTruthToolStripMenuItem
            // 
            this.revealTheTruthToolStripMenuItem.Name = "revealTheTruthToolStripMenuItem";
            this.revealTheTruthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revealTheTruthToolStripMenuItem.Text = "Reveal the truth";
            this.revealTheTruthToolStripMenuItem.Click += new System.EventHandler(this.revealTheTruthToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTruth);
            this.Controls.Add(this.mnsChoose);
            this.MainMenuStrip = this.mnsChoose;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnsChoose.ResumeLayout(false);
            this.mnsChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsChoose;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowser;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.Label lblTruth;
        private System.Windows.Forms.ToolStripMenuItem revealTheTruthToolStripMenuItem;
    }
}

