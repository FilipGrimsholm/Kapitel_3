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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.krypteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängestextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFärg = new System.Windows.Forms.Button();
            this.btnMapp = new System.Windows.Forms.Button();
            this.btnTeckensnitt = new System.Windows.Forms.Button();
            this.revealTheTruthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mnsChoose.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.lblTruth.Location = new System.Drawing.Point(32, 58);
            this.lblTruth.Name = "lblTruth";
            this.lblTruth.Size = new System.Drawing.Size(441, 73);
            this.lblTruth.TabIndex = 1;
            this.lblTruth.Text = "Hah, Felix gay";
            this.lblTruth.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krypteraToolStripMenuItem,
            this.baklängestextToolStripMenuItem,
            this.taBortToolStripMenuItem,
            this.revealTheTruthToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 92);
            // 
            // krypteraToolStripMenuItem
            // 
            this.krypteraToolStripMenuItem.Name = "krypteraToolStripMenuItem";
            this.krypteraToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.krypteraToolStripMenuItem.Text = "Kryptera";
            // 
            // baklängestextToolStripMenuItem
            // 
            this.baklängestextToolStripMenuItem.Name = "baklängestextToolStripMenuItem";
            this.baklängestextToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.baklängestextToolStripMenuItem.Text = "Baklängestext";
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            // 
            // btnFärg
            // 
            this.btnFärg.ContextMenuStrip = this.contextMenuStrip1;
            this.btnFärg.Location = new System.Drawing.Point(45, 157);
            this.btnFärg.Name = "btnFärg";
            this.btnFärg.Size = new System.Drawing.Size(96, 23);
            this.btnFärg.TabIndex = 3;
            this.btnFärg.Text = "Välj färg";
            this.toolTip1.SetToolTip(this.btnFärg, "Choose a colour");
            this.btnFärg.UseVisualStyleBackColor = true;
            // 
            // btnMapp
            // 
            this.btnMapp.ContextMenuStrip = this.contextMenuStrip1;
            this.btnMapp.Location = new System.Drawing.Point(45, 187);
            this.btnMapp.Name = "btnMapp";
            this.btnMapp.Size = new System.Drawing.Size(96, 23);
            this.btnMapp.TabIndex = 4;
            this.btnMapp.Text = "Välj mapp";
            this.toolTip1.SetToolTip(this.btnMapp, "Choose a mapp");
            this.btnMapp.UseVisualStyleBackColor = true;
            // 
            // btnTeckensnitt
            // 
            this.btnTeckensnitt.ContextMenuStrip = this.contextMenuStrip1;
            this.btnTeckensnitt.Location = new System.Drawing.Point(45, 217);
            this.btnTeckensnitt.Name = "btnTeckensnitt";
            this.btnTeckensnitt.Size = new System.Drawing.Size(96, 23);
            this.btnTeckensnitt.TabIndex = 5;
            this.btnTeckensnitt.Text = "Välj teckensnitt";
            this.toolTip1.SetToolTip(this.btnTeckensnitt, "Choose a font");
            this.btnTeckensnitt.UseVisualStyleBackColor = true;
            // 
            // revealTheTruthToolStripMenuItem1
            // 
            this.revealTheTruthToolStripMenuItem1.Name = "revealTheTruthToolStripMenuItem1";
            this.revealTheTruthToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.revealTheTruthToolStripMenuItem1.Text = "Reveal the truth";
            this.revealTheTruthToolStripMenuItem1.Click += new System.EventHandler(this.RevealTheTruthToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(70, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 364);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTruth);
            this.tabPage1.Controls.Add(this.btnMapp);
            this.tabPage1.Controls.Add(this.btnFärg);
            this.tabPage1.Controls.Add(this.btnTeckensnitt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Musik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(647, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Film";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(647, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ljudböcker";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(647, 338);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Podradio";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(647, 338);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Appar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnsChoose);
            this.MainMenuStrip = this.mnsChoose;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnsChoose.ResumeLayout(false);
            this.mnsChoose.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem krypteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baklängestextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.Button btnFärg;
        private System.Windows.Forms.Button btnMapp;
        private System.Windows.Forms.Button btnTeckensnitt;
        private System.Windows.Forms.ToolStripMenuItem revealTheTruthToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}

