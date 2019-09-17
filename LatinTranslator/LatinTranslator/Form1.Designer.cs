namespace LatinTranslator
{
    partial class latinTranslatorForm
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
            this.leftLatin = new System.Windows.Forms.Label();
            this.centerLatin = new System.Windows.Forms.Label();
            this.rightLatin = new System.Windows.Forms.Label();
            this.titleLatinTranslator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.White;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(23, 103);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "left";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerButton
            // 
            this.centerButton.BackColor = System.Drawing.Color.White;
            this.centerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerButton.Location = new System.Drawing.Point(114, 103);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 23);
            this.centerButton.TabIndex = 1;
            this.centerButton.Text = "center";
            this.centerButton.UseVisualStyleBackColor = false;
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.White;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(205, 103);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "right";
            this.rightButton.UseVisualStyleBackColor = false;
            // 
            // leftLatin
            // 
            this.leftLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLatin.Location = new System.Drawing.Point(23, 147);
            this.leftLatin.Name = "leftLatin";
            this.leftLatin.Size = new System.Drawing.Size(75, 23);
            this.leftLatin.TabIndex = 3;
            this.leftLatin.Text = "sinister";
            this.leftLatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftLatin.Visible = false;
            this.leftLatin.Click += new System.EventHandler(this.label1_Click);
            // 
            // centerLatin
            // 
            this.centerLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerLatin.Location = new System.Drawing.Point(114, 147);
            this.centerLatin.Name = "centerLatin";
            this.centerLatin.Size = new System.Drawing.Size(75, 23);
            this.centerLatin.TabIndex = 4;
            this.centerLatin.Text = "medium";
            this.centerLatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerLatin.Visible = false;
            // 
            // rightLatin
            // 
            this.rightLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLatin.Location = new System.Drawing.Point(205, 146);
            this.rightLatin.Name = "rightLatin";
            this.rightLatin.Size = new System.Drawing.Size(75, 23);
            this.rightLatin.TabIndex = 5;
            this.rightLatin.Text = "dexter";
            this.rightLatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightLatin.Visible = false;
            // 
            // titleLatinTranslator
            // 
            this.titleLatinTranslator.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.titleLatinTranslator.Location = new System.Drawing.Point(23, 24);
            this.titleLatinTranslator.Name = "titleLatinTranslator";
            this.titleLatinTranslator.Size = new System.Drawing.Size(257, 47);
            this.titleLatinTranslator.TabIndex = 6;
            this.titleLatinTranslator.Text = "Latin Translator";
            this.titleLatinTranslator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latinTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.titleLatinTranslator);
            this.Controls.Add(this.rightLatin);
            this.Controls.Add(this.centerLatin);
            this.Controls.Add(this.leftLatin);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.leftButton);
            this.Name = "latinTranslatorForm";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.latinTranslatorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label leftLatin;
        private System.Windows.Forms.Label centerLatin;
        private System.Windows.Forms.Label rightLatin;
        private System.Windows.Forms.Label titleLatinTranslator;
    }
}

