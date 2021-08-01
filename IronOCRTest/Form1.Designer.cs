
namespace IronOCRTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtOCRText = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start OCR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOCRText
            // 
            this.txtOCRText.AcceptsReturn = true;
            this.txtOCRText.Location = new System.Drawing.Point(12, 66);
            this.txtOCRText.Multiline = true;
            this.txtOCRText.Name = "txtOCRText";
            this.txtOCRText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOCRText.Size = new System.Drawing.Size(684, 355);
            this.txtOCRText.TabIndex = 1;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(120, 20);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(576, 20);
            this.txtImagePath.TabIndex = 2;
            this.txtImagePath.Text = "d:\\do-ocr.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtOCRText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "IronOCR App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOCRText;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
    }
}

