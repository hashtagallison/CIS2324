namespace HelloWorld
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
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.message1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayHelloButton
            // 
            this.sayHelloButton.BackColor = System.Drawing.Color.Maroon;
            this.sayHelloButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayHelloButton.ForeColor = System.Drawing.Color.White;
            this.sayHelloButton.Location = new System.Drawing.Point(579, 351);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(180, 56);
            this.sayHelloButton.TabIndex = 0;
            this.sayHelloButton.Text = "Say Hello";
            this.sayHelloButton.UseVisualStyleBackColor = false;
            this.sayHelloButton.Click += new System.EventHandler(this.message1_Click);
            // 
            // message1
            // 
            this.message1.BackColor = System.Drawing.Color.Transparent;
            this.message1.Font = new System.Drawing.Font("Bookman Old Style", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.message1.Location = new System.Drawing.Point(12, 37);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(786, 210);
            this.message1.TabIndex = 1;
            this.message1.Text = "HelloWorld";
            this.message1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message1.Click += new System.EventHandler(this.message1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = global::HelloWorld.Properties.Resources.Bobcats;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.sayHelloButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "HelloWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sayHelloButton;
        private System.Windows.Forms.Label message1;
    }
}

