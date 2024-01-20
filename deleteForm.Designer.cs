
namespace carWing
{
    partial class deleteForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.productIdInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productMakeInput = new System.Windows.Forms.TextBox();
            this.makeDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(75, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productIdInput
            // 
            this.productIdInput.Location = new System.Drawing.Point(203, 172);
            this.productIdInput.Multiline = true;
            this.productIdInput.Name = "productIdInput";
            this.productIdInput.Size = new System.Drawing.Size(153, 40);
            this.productIdInput.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(78, 236);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(278, 44);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Confirm Delete";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delete Your Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(78, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delete By ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Chocolate;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(428, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Delete By Make";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Chocolate;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(425, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Make";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productMakeInput
            // 
            this.productMakeInput.Location = new System.Drawing.Point(553, 172);
            this.productMakeInput.Multiline = true;
            this.productMakeInput.Name = "productMakeInput";
            this.productMakeInput.Size = new System.Drawing.Size(153, 40);
            this.productMakeInput.TabIndex = 11;
            // 
            // makeDeleteButton
            // 
            this.makeDeleteButton.Location = new System.Drawing.Point(428, 236);
            this.makeDeleteButton.Name = "makeDeleteButton";
            this.makeDeleteButton.Size = new System.Drawing.Size(278, 44);
            this.makeDeleteButton.TabIndex = 10;
            this.makeDeleteButton.Text = "Confirm Delete";
            this.makeDeleteButton.UseVisualStyleBackColor = true;
            this.makeDeleteButton.Click += new System.EventHandler(this.makeDeleteButton_Click);
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productMakeInput);
            this.Controls.Add(this.makeDeleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productIdInput);
            this.Controls.Add(this.searchButton);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productIdInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productMakeInput;
        private System.Windows.Forms.Button makeDeleteButton;
    }
}