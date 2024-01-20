
namespace carWing
{
    partial class searchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(47, 130);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(278, 44);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search By ID";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(172, 72);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(153, 40);
            this.searchInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(366, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available Cars Are:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allProductButton
            // 
            this.allProductButton.Location = new System.Drawing.Point(47, 196);
            this.allProductButton.Name = "allProductButton";
            this.allProductButton.Size = new System.Drawing.Size(278, 44);
            this.allProductButton.TabIndex = 6;
            this.allProductButton.Text = "Show All Available Products";
            this.allProductButton.UseVisualStyleBackColor = true;
            this.allProductButton.Click += new System.EventHandler(this.allProductButton_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button allProductButton;
    }
}