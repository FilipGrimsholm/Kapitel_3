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
            this.components = new System.ComponentModel.Container();
            this.mnsChoose = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revealTheTruthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.lblTruth = new System.Windows.Forms.Label();
            this.btnVäljfärg = new System.Windows.Forms.Button();
            this.btnVäljmapp = new System.Windows.Forms.Button();
            this.btnVäljteckensnitt = new System.Windows.Forms.Button();
            this.Contextmenustrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mnsChoose.SuspendLayout();
            this.Contextmenustrip1.SuspendLayout();
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
            // revealTheTruthToolStripMenuItem
            // 
            this.revealTheTruthToolStripMenuItem.Name = "revealTheTruthToolStripMenuItem";
            this.revealTheTruthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revealTheTruthToolStripMenuItem.Text = "Reveal the truth";
            this.revealTheTruthToolStripMenuItem.Click += new System.EventHandler(this.revealTheTruthToolStripMenuItem_Click);
            // 
            // lblTruth
            // 
            this.lblTruth.AutoSize = true;
            this.lblTruth.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruth.Location = new System.Drawing.Point(171, 119);
            this.lblTruth.Name = "lblTruth";
            this.lblTruth.Size = new System.Drawing.Size(441, 73);
            this.lblTruth.TabIndex = 1;
            this.lblTruth.Text = "Hah, Felix gay";
            this.lblTruth.Visible = false;
            // 
            // btnVäljfärg
            // 
            this.btnVäljfärg.ContextMenuStrip = this.Contextmenustrip1;
            this.btnVäljfärg.Location = new System.Drawing.Point(184, 211);
            this.btnVäljfärg.Name = "btnVäljfärg";
            this.btnVäljfärg.Size = new System.Drawing.Size(97, 23);
            this.btnVäljfärg.TabIndex = 2;
            this.btnVäljfärg.Text = "Välj färg";
            this.toolTip1.SetToolTip(this.btnVäljfärg, "Chooses a colour that paint the button in the selected colour.\r\n");
            this.btnVäljfärg.UseVisualStyleBackColor = true;
            // 
            // btnVäljmapp
            // 
            this.btnVäljmapp.ContextMenuStrip = this.Contextmenustrip1;
            this.btnVäljmapp.Location = new System.Drawing.Point(184, 241);
            this.btnVäljmapp.Name = "btnVäljmapp";
            this.btnVäljmapp.Size = new System.Drawing.Size(97, 23);
            this.btnVäljmapp.TabIndex = 3;
            this.btnVäljmapp.Text = "Välj mapp";
            this.btnVäljmapp.UseVisualStyleBackColor = true;
            // 
            // btnVäljteckensnitt
            // 
            this.btnVäljteckensnitt.ContextMenuStrip = this.Contextmenustrip1;
            this.btnVäljteckensnitt.Location = new System.Drawing.Point(184, 271);
            this.btnVäljteckensnitt.Name = "btnVäljteckensnitt";
            this.btnVäljteckensnitt.Size = new System.Drawing.Size(97, 23);
            this.btnVäljteckensnitt.TabIndex = 4;
            this.btnVäljteckensnitt.Text = "Välj teckensnitt";
            this.btnVäljteckensnitt.UseVisualStyleBackColor = true;
            // 
            // Contextmenustrip1
            // 
            this.Contextmenustrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.Contextmenustrip1.Name = "Contxtmnustrip1";
            this.Contextmenustrip1.Size = new System.Drawing.Size(158, 70);
            this.Contextmenustrip1.Opening += new System.ComponentModel.CancelEventHandler(this.Contextmenustrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem1.Text = "Ta bort";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem2.Text = "Reveal the truth";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Secret Secret";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVäljteckensnitt);
            this.Controls.Add(this.btnVäljmapp);
            this.Controls.Add(this.btnVäljfärg);
            this.Controls.Add(this.lblTruth);
            this.Controls.Add(this.mnsChoose);
            this.MainMenuStrip = this.mnsChoose;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnsChoose.ResumeLayout(false);
            this.mnsChoose.PerformLayout();
            this.Contextmenustrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnVäljfärg;
        private System.Windows.Forms.Button btnVäljmapp;
        private System.Windows.Forms.Button btnVäljteckensnitt;
        private System.Windows.Forms.ContextMenuStrip Contextmenustrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

