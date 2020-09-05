namespace SpeecSynthesiser
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
            this.SpeechBox = new System.Windows.Forms.RichTextBox();
            this.Copy_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpeechBox
            // 
            this.SpeechBox.Location = new System.Drawing.Point(13, 13);
            this.SpeechBox.Name = "SpeechBox";
            this.SpeechBox.Size = new System.Drawing.Size(504, 396);
            this.SpeechBox.TabIndex = 1;
            this.SpeechBox.Text = "";
            // 
            // Copy_Btn
            // 
            this.Copy_Btn.Location = new System.Drawing.Point(93, 415);
            this.Copy_Btn.Name = "Copy_Btn";
            this.Copy_Btn.Size = new System.Drawing.Size(75, 23);
            this.Copy_Btn.TabIndex = 2;
            this.Copy_Btn.Text = "Copy";
            this.Copy_Btn.UseVisualStyleBackColor = true;
            this.Copy_Btn.Click += new System.EventHandler(this.Copy_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.Copy_Btn);
            this.Controls.Add(this.SpeechBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox SpeechBox;
        private System.Windows.Forms.Button Copy_Btn;
    }
}

