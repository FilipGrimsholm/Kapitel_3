namespace Övning_3_7__2_
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
            this.tbxMålrikast = new System.Windows.Forms.TextBox();
            this.btnMålrikast = new System.Windows.Forms.Button();
            this.dgvMatcher = new System.Windows.Forms.DataGridView();
            this.DGVtbxHemmalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbxBortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbxMålhemma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVthxMålborta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMålskillnad = new System.Windows.Forms.Button();
            this.tbxMålskillnad = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMålrikast
            // 
            this.tbxMålrikast.Location = new System.Drawing.Point(127, 440);
            this.tbxMålrikast.Name = "tbxMålrikast";
            this.tbxMålrikast.Size = new System.Drawing.Size(625, 20);
            this.tbxMålrikast.TabIndex = 5;
            // 
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(45, 438);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(75, 23);
            this.btnMålrikast.TabIndex = 4;
            this.btnMålrikast.Text = "Målrikast";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            this.btnMålrikast.Click += new System.EventHandler(this.btnMålrikast_Click);
            // 
            // dgvMatcher
            // 
            this.dgvMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVtbxHemmalag,
            this.DGVtbxBortalag,
            this.DGVtbxMålhemma,
            this.DGVthxMålborta});
            this.dgvMatcher.Location = new System.Drawing.Point(45, 34);
            this.dgvMatcher.Name = "dgvMatcher";
            this.dgvMatcher.Size = new System.Drawing.Size(707, 386);
            this.dgvMatcher.TabIndex = 3;
            this.dgvMatcher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellContentClick);
            this.dgvMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellEndEdit);
            this.dgvMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMatcher_UserAddedRow);
            this.dgvMatcher.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMatcher_UserDeletingRow);
            // 
            // DGVtbxHemmalag
            // 
            this.DGVtbxHemmalag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVtbxHemmalag.HeaderText = "Hemmalag";
            this.DGVtbxHemmalag.Name = "DGVtbxHemmalag";
            // 
            // DGVtbxBortalag
            // 
            this.DGVtbxBortalag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVtbxBortalag.HeaderText = "Bortalag";
            this.DGVtbxBortalag.Name = "DGVtbxBortalag";
            // 
            // DGVtbxMålhemma
            // 
            this.DGVtbxMålhemma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVtbxMålhemma.HeaderText = "Mål (H)";
            this.DGVtbxMålhemma.Name = "DGVtbxMålhemma";
            // 
            // DGVthxMålborta
            // 
            this.DGVthxMålborta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVthxMålborta.HeaderText = "Mål (B)";
            this.DGVthxMålborta.Name = "DGVthxMålborta";
            // 
            // btnMålskillnad
            // 
            this.btnMålskillnad.Location = new System.Drawing.Point(45, 468);
            this.btnMålskillnad.Name = "btnMålskillnad";
            this.btnMålskillnad.Size = new System.Drawing.Size(75, 23);
            this.btnMålskillnad.TabIndex = 6;
            this.btnMålskillnad.Text = "Målskillnad";
            this.btnMålskillnad.UseVisualStyleBackColor = true;
            this.btnMålskillnad.Click += new System.EventHandler(this.btnMålskillnad_Click);
            // 
            // tbxMålskillnad
            // 
            this.tbxMålskillnad.Location = new System.Drawing.Point(126, 470);
            this.tbxMålskillnad.Name = "tbxMålskillnad";
            this.tbxMålskillnad.Size = new System.Drawing.Size(626, 20);
            this.tbxMålskillnad.TabIndex = 7;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(110, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(84, 23);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(200, 5);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Move rows:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbxMålskillnad);
            this.Controls.Add(this.btnMålskillnad);
            this.Controls.Add(this.tbxMålrikast);
            this.Controls.Add(this.btnMålrikast);
            this.Controls.Add(this.dgvMatcher);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMålrikast;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.DataGridView dgvMatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxHemmalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxBortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxMålhemma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVthxMålborta;
        private System.Windows.Forms.Button btnMålskillnad;
        private System.Windows.Forms.TextBox tbxMålskillnad;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label1;
    }
}

