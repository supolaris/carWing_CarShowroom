
namespace carWing
{
    partial class buyForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedCarDetails = new System.Windows.Forms.TextBox();
            this.pdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(65, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(682, 40);
            this.label6.TabIndex = 25;
            this.label6.Text = "Buy Your Car";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(396, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Available Cars Are:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 247);
            this.dataGridView1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(193, 79);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(153, 40);
            this.searchInput.TabIndex = 29;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.searchButton.Location = new System.Drawing.Point(68, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(278, 44);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Select Car";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(421, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 44);
            this.button1.TabIndex = 31;
            this.button1.Text = "Show Available Cars";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(65, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 40);
            this.label3.TabIndex = 33;
            this.label3.Text = "Your Bill";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedCarDetails
            // 
            this.selectedCarDetails.Location = new System.Drawing.Point(68, 260);
            this.selectedCarDetails.Multiline = true;
            this.selectedCarDetails.Name = "selectedCarDetails";
            this.selectedCarDetails.Size = new System.Drawing.Size(267, 103);
            this.selectedCarDetails.TabIndex = 36;
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pdfButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdfButton.Location = new System.Drawing.Point(68, 380);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(267, 33);
            this.pdfButton.TabIndex = 37;
            this.pdfButton.Text = "Download Recipt";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // buyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.selectedCarDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "buyForm";
            this.Text = "buyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectedCarDetails;
        private System.Windows.Forms.Button pdfButton;
    }
}