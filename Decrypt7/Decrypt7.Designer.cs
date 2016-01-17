namespace Decrypt7_CSharp
{
    partial class mainForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.DecryptBox1 = new System.Windows.Forms.TextBox();
            this.Start1 = new System.Windows.Forms.Button();
            this.CryptBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Crypted Password :";
            // 
            // DecryptBox1
            // 
            this.DecryptBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecryptBox1.Location = new System.Drawing.Point(84, 50);
            this.DecryptBox1.Name = "DecryptBox1";
            this.DecryptBox1.ReadOnly = true;
            this.DecryptBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DecryptBox1.Size = new System.Drawing.Size(198, 20);
            this.DecryptBox1.TabIndex = 6;
            this.DecryptBox1.WordWrap = false;
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(3, 47);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(75, 23);
            this.Start1.TabIndex = 5;
            this.Start1.Text = "Decrypt";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // CryptBox1
            // 
            this.CryptBox1.Location = new System.Drawing.Point(3, 21);
            this.CryptBox1.Name = "CryptBox1";
            this.CryptBox1.Size = new System.Drawing.Size(279, 20);
            this.CryptBox1.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 78);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DecryptBox1);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.CryptBox1);
            this.Name = "mainForm";
            this.Text = "Password 7 Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox DecryptBox1;
        internal System.Windows.Forms.Button Start1;
        internal System.Windows.Forms.TextBox CryptBox1;
    }
}

