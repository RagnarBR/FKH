namespace Craps
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxTeningur1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeningur2 = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelVannedaTapadi = new System.Windows.Forms.Label();
            this.pictureBoxTeningur4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeningur3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "teningur1.png");
            this.imageList1.Images.SetKeyName(1, "teningur2.png");
            this.imageList1.Images.SetKeyName(2, "teningur3.png");
            this.imageList1.Images.SetKeyName(3, "teningur4.png");
            this.imageList1.Images.SetKeyName(4, "teningur5.png");
            this.imageList1.Images.SetKeyName(5, "teningur6.png");
            // 
            // pictureBoxTeningur1
            // 
            this.pictureBoxTeningur1.Location = new System.Drawing.Point(29, 19);
            this.pictureBoxTeningur1.Name = "pictureBoxTeningur1";
            this.pictureBoxTeningur1.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxTeningur1.TabIndex = 0;
            this.pictureBoxTeningur1.TabStop = false;
            // 
            // pictureBoxTeningur2
            // 
            this.pictureBoxTeningur2.Location = new System.Drawing.Point(168, 19);
            this.pictureBoxTeningur2.Name = "pictureBoxTeningur2";
            this.pictureBoxTeningur2.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxTeningur2.TabIndex = 1;
            this.pictureBoxTeningur2.TabStop = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(90, 118);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Enabled = false;
            this.buttonRoll.Location = new System.Drawing.Point(90, 150);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 5;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTeningur2);
            this.groupBox1.Controls.Add(this.pictureBoxTeningur1);
            this.groupBox1.Location = new System.Drawing.Point(0, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stig";
            // 
            // labelVannedaTapadi
            // 
            this.labelVannedaTapadi.AutoSize = true;
            this.labelVannedaTapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVannedaTapadi.Location = new System.Drawing.Point(181, 134);
            this.labelVannedaTapadi.Name = "labelVannedaTapadi";
            this.labelVannedaTapadi.Size = new System.Drawing.Size(0, 20);
            this.labelVannedaTapadi.TabIndex = 7;
            // 
            // pictureBoxTeningur4
            // 
            this.pictureBoxTeningur4.Location = new System.Drawing.Point(168, 176);
            this.pictureBoxTeningur4.Name = "pictureBoxTeningur4";
            this.pictureBoxTeningur4.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxTeningur4.TabIndex = 8;
            this.pictureBoxTeningur4.TabStop = false;
            // 
            // pictureBoxTeningur3
            // 
            this.pictureBoxTeningur3.Location = new System.Drawing.Point(12, 176);
            this.pictureBoxTeningur3.Name = "pictureBoxTeningur3";
            this.pictureBoxTeningur3.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxTeningur3.TabIndex = 9;
            this.pictureBoxTeningur3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictureBoxTeningur3);
            this.Controls.Add(this.pictureBoxTeningur4);
            this.Controls.Add(this.labelVannedaTapadi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Name = "Form1";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeningur3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxTeningur1;
        private System.Windows.Forms.PictureBox pictureBoxTeningur2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelVannedaTapadi;
        private System.Windows.Forms.PictureBox pictureBoxTeningur4;
        private System.Windows.Forms.PictureBox pictureBoxTeningur3;
    }
}

