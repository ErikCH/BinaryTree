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
            this.editBtn = new System.Windows.Forms.Button();
            this.addDelTextBox = new System.Windows.Forms.TextBox();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.addNodeBtn.Location = new System.Drawing.Point(23, 105);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(100, 31);
            this.addNodeBtn.TabIndex = 1;
            this.addNodeBtn.Text = "Add Node";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Location = new System.Drawing.Point(23, 169);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.Size = new System.Drawing.Size(100, 31);
            this.deleteNodeBtn.TabIndex = 4;
            this.deleteNodeBtn.Text = "Delete Node";
            this.deleteNodeBtn.UseVisualStyleBackColor = true;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(23, 302);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 31);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit Node";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addDelTextBox
            // 
            this.addDelTextBox.Location = new System.Drawing.Point(23, 143);
            this.addDelTextBox.Name = "addDelTextBox";
            this.addDelTextBox.Size = new System.Drawing.Size(100, 20);
            this.addDelTextBox.TabIndex = 10;
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(23, 339);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(100, 20);
            this.editTextBox.TabIndex = 11;
            // 
            // formatComboBox
            // 
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "INT",
            "DOUBLE",
            "STRING"});
            this.formatComboBox.Location = new System.Drawing.Point(12, 48);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 21);
            this.formatComboBox.TabIndex = 12;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Format:";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.addDelTextBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteNodeBtn);
            this.Controls.Add(this.addNodeBtn);
            this.Controls.Add(this.outputRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainGUI";
            this.Text = "Binary Tree Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox addDelTextBox;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label label1;
    }
}

