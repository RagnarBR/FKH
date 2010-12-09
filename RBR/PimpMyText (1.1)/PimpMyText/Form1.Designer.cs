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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPimpMyText = new System.Windows.Forms.Button();
            this.buttonMorePimpin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 191);
            this.textBox1.TabIndex = 0;
            // 
            // buttonPimpMyText
            // 
            this.buttonPimpMyText.Location = new System.Drawing.Point(12, 209);
            this.buttonPimpMyText.Name = "buttonPimpMyText";
            this.buttonPimpMyText.Size = new System.Drawing.Size(85, 23);
            this.buttonPimpMyText.TabIndex = 1;
            this.buttonPimpMyText.Text = "Pimp my text!";
            this.buttonPimpMyText.UseVisualStyleBackColor = true;
            this.buttonPimpMyText.Click += new System.EventHandler(this.buttonPimpMyText_Click);
            // 
            // buttonMorePimpin
            // 
            this.buttonMorePimpin.Enabled = false;
            this.buttonMorePimpin.Location = new System.Drawing.Point(12, 238);
            this.buttonMorePimpin.Name = "buttonMorePimpin";
            this.buttonMorePimpin.Size = new System.Drawing.Size(122, 23);
            this.buttonMorePimpin.TabIndex = 2;
            this.buttonMorePimpin.Text = "Do some more pimpin\'";
            this.buttonMorePimpin.UseVisualStyleBackColor = true;
            this.buttonMorePimpin.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "After each character",
            "After each sentence",
            "After each word",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(159, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonMorePimpin);
            this.Controls.Add(this.buttonPimpMyText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Pimp my text ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPimpMyText;
        private System.Windows.Forms.Button buttonMorePimpin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

