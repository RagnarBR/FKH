namespace PimpMyText
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPimpMyText = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(250, 191);
            this.txtInput.TabIndex = 0;
            // 
            // btnPimpMyText
            // 
            this.btnPimpMyText.Location = new System.Drawing.Point(275, 96);
            this.btnPimpMyText.Name = "btnPimpMyText";
            this.btnPimpMyText.Size = new System.Drawing.Size(92, 23);
            this.btnPimpMyText.TabIndex = 1;
            this.btnPimpMyText.Text = "Pimp My Text";
            this.btnPimpMyText.UseVisualStyleBackColor = true;
            this.btnPimpMyText.Click += new System.EventHandler(this.buttonPimpMyText_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(378, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(242, 191);
            this.txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 219);
            this.Controls.Add(this.btnPimpMyText);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPimpMyText;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

