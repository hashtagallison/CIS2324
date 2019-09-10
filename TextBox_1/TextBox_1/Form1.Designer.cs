namespace TextBox_1
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
            this.readinputButton = new System.Windows.Forms.Button();
            this.yourNameLabel = new System.Windows.Forms.Label();
            this.yourNameTextBox = new System.Windows.Forms.TextBox();
            this.enteredLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readinputButton
            // 
            this.readinputButton.Location = new System.Drawing.Point(24, 163);
            this.readinputButton.Name = "readinputButton";
            this.readinputButton.Size = new System.Drawing.Size(186, 37);
            this.readinputButton.TabIndex = 0;
            this.readinputButton.Text = "Read input";
            this.readinputButton.UseVisualStyleBackColor = true;
            this.readinputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // yourNameLabel
            // 
            this.yourNameLabel.AutoSize = true;
            this.yourNameLabel.Location = new System.Drawing.Point(21, 30);
            this.yourNameLabel.Name = "yourNameLabel";
            this.yourNameLabel.Size = new System.Drawing.Size(91, 13);
            this.yourNameLabel.TabIndex = 1;
            this.yourNameLabel.Text = "Enter Your Name:";
            this.yourNameLabel.Click += new System.EventHandler(this.yourNameLabel_Click);
            // 
            // yourNameTextBox
            // 
            this.yourNameTextBox.Location = new System.Drawing.Point(115, 27);
            this.yourNameTextBox.Name = "yourNameTextBox";
            this.yourNameTextBox.Size = new System.Drawing.Size(95, 20);
            this.yourNameTextBox.TabIndex = 2;
            this.yourNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enteredLabel
            // 
            this.enteredLabel.AutoSize = true;
            this.enteredLabel.Location = new System.Drawing.Point(43, 64);
            this.enteredLabel.Name = "enteredLabel";
            this.enteredLabel.Size = new System.Drawing.Size(69, 13);
            this.enteredLabel.TabIndex = 3;
            this.enteredLabel.Text = "You Entered:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 227);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enteredLabel);
            this.Controls.Add(this.yourNameTextBox);
            this.Controls.Add(this.yourNameLabel);
            this.Controls.Add(this.readinputButton);
            this.Name = "Form1";
            this.Text = "Name Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readinputButton;
        private System.Windows.Forms.Label yourNameLabel;
        private System.Windows.Forms.TextBox yourNameTextBox;
        private System.Windows.Forms.Label enteredLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

