namespace BinaryTree
{
    partial class MainGUI
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
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.addDeleteUpDwn = new System.Windows.Forms.NumericUpDown();
            this.editBtn = new System.Windows.Forms.Button();
            this.editFirstUpDownBx = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteUpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFirstUpDownBx)).BeginInit();
            this.SuspendLayout();
            // 
            // outputRTB
            // 
            this.outputRTB.Location = new System.Drawing.Point(160, 17);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(417, 346);
            this.outputRTB.TabIndex = 0;
            this.outputRTB.Text = "";
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Location = new System.Drawing.Point(23, 17);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(100, 31);
            this.addNodeBtn.TabIndex = 1;
            this.addNodeBtn.Text = "Add Node";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Location = new System.Drawing.Point(23, 81);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.Size = new System.Drawing.Size(100, 31);
            this.deleteNodeBtn.TabIndex = 4;
            this.deleteNodeBtn.Text = "Delete Node";
            this.deleteNodeBtn.UseVisualStyleBackColor = true;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // addDeleteUpDwn
            // 
            this.addDeleteUpDwn.Location = new System.Drawing.Point(12, 55);
            this.addDeleteUpDwn.Name = "addDeleteUpDwn";
            this.addDeleteUpDwn.Size = new System.Drawing.Size(120, 20);
            this.addDeleteUpDwn.TabIndex = 8;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(23, 214);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 31);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit Node";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // editFirstUpDownBx
            // 
            this.editFirstUpDownBx.Location = new System.Drawing.Point(12, 251);
            this.editFirstUpDownBx.Name = "editFirstUpDownBx";
            this.editFirstUpDownBx.Size = new System.Drawing.Size(120, 20);
            this.editFirstUpDownBx.TabIndex = 10;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 392);
            this.Controls.Add(this.editFirstUpDownBx);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addDeleteUpDwn);
            this.Controls.Add(this.deleteNodeBtn);
            this.Controls.Add(this.addNodeBtn);
            this.Controls.Add(this.outputRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainGUI";
            this.Text = "Binary Tree Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteUpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFirstUpDownBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.NumericUpDown addDeleteUpDwn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown editFirstUpDownBx;
    }
}

