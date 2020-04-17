﻿namespace First_application
{
    partial class FrmPic
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImageFromFile = new System.Windows.Forms.Button();
            this.btnImageFromResource = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(354, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnImageFromFile.Location = new System.Drawing.Point(24, 48);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(152, 86);
            this.btnImageFromFile.TabIndex = 3;
            this.btnImageFromFile.Text = "Image From File";
            this.btnImageFromFile.UseVisualStyleBackColor = false;
            this.btnImageFromFile.Click += new System.EventHandler(this.btnImageFromFile_Click);
            // 
            // btnImageFromResource
            // 
            this.btnImageFromResource.BackColor = System.Drawing.Color.Silver;
            this.btnImageFromResource.Location = new System.Drawing.Point(24, 214);
            this.btnImageFromResource.Name = "btnImageFromResource";
            this.btnImageFromResource.Size = new System.Drawing.Size(152, 86);
            this.btnImageFromResource.TabIndex = 4;
            this.btnImageFromResource.Text = "Image From Resource";
            this.btnImageFromResource.UseVisualStyleBackColor = false;
            this.btnImageFromResource.Click += new System.EventHandler(this.btnImageFromResource_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(781, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 53);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnImageFromResource);
            this.Controls.Add(this.btnImageFromFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPic";
            this.Text = "FrmPic";
            this.Load += new System.EventHandler(this.FrmPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImageFromFile;
        private System.Windows.Forms.Button btnImageFromResource;
        private System.Windows.Forms.Button btnBack;
    }
}