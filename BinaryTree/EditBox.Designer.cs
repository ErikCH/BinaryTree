namespace BinaryTree
{
    partial class EditBox
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
            this.edNodeLbl = new System.Windows.Forms.Label();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.edit2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edNodeLbl
            // 
            this.edNodeLbl.AutoSize = true;
            this.edNodeLbl.Location = new System.Drawing.Point(107, 24);
            this.edNodeLbl.Name = "edNodeLbl";
            this.edNodeLbl.Size = new System.Drawing.Size(69, 13);
            this.edNodeLbl.TabIndex = 0;
            this.edNodeLbl.Text = "New Number";
            // 
            // addEditBtn
            // 
            this.addEditBtn.Location = new System.Drawing.Point(101, 85);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(75, 23);
            this.addEditBtn.TabIndex = 2;
            this.addEditBtn.Text = "Edit";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // edit2TextBox
            // 
            this.edit2TextBox.Location = new System.Drawing.Point(91, 50);
            this.edit2TextBox.Name = "edit2TextBox";
            this.edit2TextBox.Size = new System.Drawing.Size(100, 20);
            this.edit2TextBox.TabIndex = 3;
            // 
            // EditBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 120);
            this.Controls.Add(this.edit2TextBox);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.edNodeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditBox";
            this.Text = "Edit Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label edNodeLbl;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.TextBox edit2TextBox;
    }
}