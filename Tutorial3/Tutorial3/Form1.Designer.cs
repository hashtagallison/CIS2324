namespace Tutorial3
{
    partial class FormCalcSalePrice
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
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxSale = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.buttonCalcSalePrice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOriginal
            // 
            this.labelOriginal.Location = new System.Drawing.Point(104, 109);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(209, 23);
            this.labelOriginal.TabIndex = 0;
            this.labelOriginal.Text = "Original Price";
            // 
            // labelDiscount
            // 
            this.labelDiscount.Location = new System.Drawing.Point(101, 162);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(212, 23);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "Discount Percentage";
            // 
            // labelSale
            // 
            this.labelSale.Location = new System.Drawing.Point(104, 214);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(209, 23);
            this.labelSale.TabIndex = 2;
            this.labelSale.Text = "Sale Price";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(319, 110);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(147, 22);
            this.textBoxOriginal.TabIndex = 3;
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // textBoxSale
            // 
            this.textBoxSale.Location = new System.Drawing.Point(319, 215);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.ReadOnly = true;
            this.textBoxSale.Size = new System.Drawing.Size(147, 22);
            this.textBoxSale.TabIndex = 4;
            this.textBoxSale.TextChanged += new System.EventHandler(this.textBoxSale_TextChanged);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(319, 163);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(147, 22);
            this.textBoxDiscount.TabIndex = 5;
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // buttonCalcSalePrice
            // 
            this.buttonCalcSalePrice.Location = new System.Drawing.Point(107, 310);
            this.buttonCalcSalePrice.Name = "buttonCalcSalePrice";
            this.buttonCalcSalePrice.Size = new System.Drawing.Size(158, 23);
            this.buttonCalcSalePrice.TabIndex = 6;
            this.buttonCalcSalePrice.Text = "Calculate Sale Price";
            this.buttonCalcSalePrice.UseVisualStyleBackColor = true;
            this.buttonCalcSalePrice.Click += new System.EventHandler(this.buttonCalcSalePrice_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(319, 310);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormCalcSalePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 419);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalcSalePrice);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxSale);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelOriginal);
            this.Name = "FormCalcSalePrice";
            this.Text = "Calculate the Sales Price";
            this.Load += new System.EventHandler(this.FormCalcSalePrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxSale;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button buttonCalcSalePrice;
        private System.Windows.Forms.Button buttonExit;
    }
}

