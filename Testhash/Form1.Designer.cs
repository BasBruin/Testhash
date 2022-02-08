
namespace Testhash
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
            this.rtbxToBeHashed = new System.Windows.Forms.RichTextBox();
            this.rtbxHasedText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxToBeHashed
            // 
            this.rtbxToBeHashed.Location = new System.Drawing.Point(187, 155);
            this.rtbxToBeHashed.Name = "rtbxToBeHashed";
            this.rtbxToBeHashed.Size = new System.Drawing.Size(100, 96);
            this.rtbxToBeHashed.TabIndex = 0;
            this.rtbxToBeHashed.Text = "";
            // 
            // rtbxHasedText
            // 
            this.rtbxHasedText.Location = new System.Drawing.Point(401, 155);
            this.rtbxHasedText.Name = "rtbxHasedText";
            this.rtbxHasedText.Size = new System.Drawing.Size(100, 96);
            this.rtbxHasedText.TabIndex = 1;
            this.rtbxHasedText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbxHasedText);
            this.Controls.Add(this.rtbxToBeHashed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxToBeHashed;
        private System.Windows.Forms.RichTextBox rtbxHasedText;
        private System.Windows.Forms.Button button1;
    }
}

