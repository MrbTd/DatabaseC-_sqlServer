namespace DataGrid
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.AddAllBtn = new System.Windows.Forms.Button();
            this.RmvAllBtn = new System.Windows.Forms.Button();
            this.finalizeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(32, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 244);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(493, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(279, 244);
            this.listBox2.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(347, 27);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(115, 33);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RmvBtn
            // 
            this.RmvBtn.Location = new System.Drawing.Point(347, 80);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(115, 33);
            this.RmvBtn.TabIndex = 1;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = true;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // AddAllBtn
            // 
            this.AddAllBtn.Location = new System.Drawing.Point(347, 139);
            this.AddAllBtn.Name = "AddAllBtn";
            this.AddAllBtn.Size = new System.Drawing.Size(115, 33);
            this.AddAllBtn.TabIndex = 1;
            this.AddAllBtn.Text = "Add All";
            this.AddAllBtn.UseVisualStyleBackColor = true;
            this.AddAllBtn.Click += new System.EventHandler(this.AddAllBtn_Click);
            // 
            // RmvAllBtn
            // 
            this.RmvAllBtn.Location = new System.Drawing.Point(347, 188);
            this.RmvAllBtn.Name = "RmvAllBtn";
            this.RmvAllBtn.Size = new System.Drawing.Size(115, 33);
            this.RmvAllBtn.TabIndex = 1;
            this.RmvAllBtn.Text = "Remove All";
            this.RmvAllBtn.UseVisualStyleBackColor = true;
            this.RmvAllBtn.Click += new System.EventHandler(this.RmvAllBtn_Click);
            // 
            // finalizeBtn
            // 
            this.finalizeBtn.Location = new System.Drawing.Point(347, 238);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Size = new System.Drawing.Size(115, 33);
            this.finalizeBtn.TabIndex = 1;
            this.finalizeBtn.Text = "Finalize";
            this.finalizeBtn.UseVisualStyleBackColor = true;
            this.finalizeBtn.Click += new System.EventHandler(this.finalizeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(731, 185);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.finalizeBtn);
            this.Controls.Add(this.RmvAllBtn);
            this.Controls.Add(this.AddAllBtn);
            this.Controls.Add(this.RmvBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.Button AddAllBtn;
        private System.Windows.Forms.Button RmvAllBtn;
        private System.Windows.Forms.Button finalizeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

