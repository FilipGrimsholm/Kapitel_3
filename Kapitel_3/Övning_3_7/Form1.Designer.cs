namespace Övning_3_7
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
            this.dgvMatcher = new System.Windows.Forms.DataGridView();
            this.DGVtbxHemmalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbxBortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbxMålhemma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVthxMålborta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMålrikast = new System.Windows.Forms.Button();
            this.tbxMålrikast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatcher
            // 
            this.dgvMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVtbxHemmalag,
            this.DGVtbxBortalag,
            this.DGVtbxMålhemma,
            this.DGVthxMålborta});
            this.dgvMatcher.Location = new System.Drawing.Point(40, 35);
            this.dgvMatcher.Name = "dgvMatcher";
            this.dgvMatcher.Size = new System.Drawing.Size(707, 386);
            this.dgvMatcher.TabIndex = 0;
            this.dgvMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellEndEdit);
            this.dgvMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMatcher_UserAddedRow);
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
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(40, 439);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(75, 23);
            this.btnMålrikast.TabIndex = 1;
            this.btnMålrikast.Text = "Målrikast";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            this.btnMålrikast.Click += new System.EventHandler(this.btnMålrikast_Click);
            // 
            // tbxMålrikast
            // 
            this.tbxMålrikast.Location = new System.Drawing.Point(122, 441);
            this.tbxMålrikast.Name = "tbxMålrikast";
            this.tbxMålrikast.Size = new System.Drawing.Size(625, 20);
            this.tbxMålrikast.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
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

        private System.Windows.Forms.DataGridView dgvMatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxHemmalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxBortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbxMålhemma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVthxMålborta;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.TextBox tbxMålrikast;
    }
}

