namespace LatinTranslator2
{
    partial class FormLatinTranslator
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
            this.leftButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.titleLatinTran = new System.Windows.Forms.Label();
            this.labelLeftLatin = new System.Windows.Forms.Label();
            this.labelLatinCenter = new System.Windows.Forms.Label();
            this.labelLatinRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.White;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(64, 168);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(86, 37);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "left";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.BackColor = System.Drawing.Color.White;
            this.centerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerButton.Location = new System.Drawing.Point(180, 168);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(86, 37);
            this.centerButton.TabIndex = 1;
            this.centerButton.Text = "center";
            this.centerButton.UseVisualStyleBackColor = false;
            this.centerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.White;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(294, 168);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(86, 37);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "right";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // titleLatinTran
            // 
            this.titleLatinTran.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLatinTran.Location = new System.Drawing.Point(64, 79);
            this.titleLatinTran.Name = "titleLatinTran";
            this.titleLatinTran.Size = new System.Drawing.Size(316, 39);
            this.titleLatinTran.TabIndex = 3;
            this.titleLatinTran.Text = "Latin Translator";
            this.titleLatinTran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeftLatin
            // 
            this.labelLeftLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftLatin.Location = new System.Drawing.Point(64, 243);
            this.labelLeftLatin.Name = "labelLeftLatin";
            this.labelLeftLatin.Size = new System.Drawing.Size(86, 23);
            this.labelLeftLatin.TabIndex = 4;
            this.labelLeftLatin.Text = "sinister";
            this.labelLeftLatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeftLatin.Visible = false;
            // 
            // labelLatinCenter
            // 
            this.labelLatinCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatinCenter.Location = new System.Drawing.Point(177, 243);
            this.labelLatinCenter.Name = "labelLatinCenter";
            this.labelLatinCenter.Size = new System.Drawing.Size(86, 23);
            this.labelLatinCenter.TabIndex = 5;
            this.labelLatinCenter.Text = "dexter";
            this.labelLatinCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLatinCenter.Visible = false;
            // 
            // labelLatinRight
            // 
            this.labelLatinRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatinRight.Location = new System.Drawing.Point(291, 243);
            this.labelLatinRight.Name = "labelLatinRight";
            this.labelLatinRight.Size = new System.Drawing.Size(86, 23);
            this.labelLatinRight.TabIndex = 6;
            this.labelLatinRight.Text = "medium";
            this.labelLatinRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLatinRight.Visible = false;
            // 
            // FormLatinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(455, 352);
            this.Controls.Add(this.labelLatinRight);
            this.Controls.Add(this.labelLatinCenter);
            this.Controls.Add(this.labelLeftLatin);
            this.Controls.Add(this.titleLatinTran);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.leftButton);
            this.Name = "FormLatinTranslator";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.FormLatinTranslator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label titleLatinTran;
        private System.Windows.Forms.Label labelLeftLatin;
        private System.Windows.Forms.Label labelLatinCenter;
        private System.Windows.Forms.Label labelLatinRight;
    }
}

