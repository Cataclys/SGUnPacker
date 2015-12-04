namespace SGunpacker
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dump_dir = new System.Windows.Forms.Label();
            this.data_dir = new System.Windows.Forms.Label();
            this.list_btn = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.file_count = new System.Windows.Forms.Label();
            this.dump_a = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3
            // 
            this.dgv3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv3.EnableHeadersVisualStyles = false;
            this.dgv3.Location = new System.Drawing.Point(12, 69);
            this.dgv3.MultiSelect = false;
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(1002, 331);
            this.dgv3.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hash";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "size";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "offset";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dump_dir
            // 
            this.dump_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dump_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dump_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dump_dir.Location = new System.Drawing.Point(12, 44);
            this.dump_dir.Name = "dump_dir";
            this.dump_dir.Size = new System.Drawing.Size(897, 15);
            this.dump_dir.TabIndex = 9;
            this.dump_dir.Text = "...";
            this.dump_dir.Click += new System.EventHandler(this.dump_dir_Click);
            // 
            // data_dir
            // 
            this.data_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_dir.Location = new System.Drawing.Point(12, 14);
            this.data_dir.Name = "data_dir";
            this.data_dir.Size = new System.Drawing.Size(897, 16);
            this.data_dir.TabIndex = 8;
            this.data_dir.Text = "...";
            this.data_dir.Click += new System.EventHandler(this.data_dir_Click);
            // 
            // list_btn
            // 
            this.list_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_btn.Location = new System.Drawing.Point(915, 9);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(99, 24);
            this.list_btn.TabIndex = 18;
            this.list_btn.Text = "Load";
            this.list_btn.UseVisualStyleBackColor = true;
            this.list_btn.Click += new System.EventHandler(this.list_btn_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(12, 419);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(1002, 12);
            this.progressBar3.TabIndex = 20;
            // 
            // file_count
            // 
            this.file_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.file_count.AutoSize = true;
            this.file_count.Location = new System.Drawing.Point(12, 403);
            this.file_count.Name = "file_count";
            this.file_count.Size = new System.Drawing.Size(66, 13);
            this.file_count.TabIndex = 19;
            this.file_count.Text = "File Count: 0";
            // 
            // dump_a
            // 
            this.dump_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dump_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dump_a.Location = new System.Drawing.Point(915, 39);
            this.dump_a.Name = "dump_a";
            this.dump_a.Size = new System.Drawing.Size(99, 24);
            this.dump_a.TabIndex = 21;
            this.dump_a.Text = "Dump All";
            this.dump_a.UseVisualStyleBackColor = true;
            this.dump_a.Click += new System.EventHandler(this.dump_a_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 443);
            this.Controls.Add(this.dump_a);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.file_count);
            this.Controls.Add(this.list_btn);
            this.Controls.Add(this.dump_dir);
            this.Controls.Add(this.data_dir);
            this.Controls.Add(this.dgv3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SG unpacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label dump_dir;
        private System.Windows.Forms.Label data_dir;
        private System.Windows.Forms.Button list_btn;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label file_count;
        private System.Windows.Forms.Button dump_a;
        private System.Windows.Forms.FolderBrowserDialog FBD;
    }
}

