﻿namespace First_application
{
    partial class frmRandomCombo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.RBLess500 = new System.Windows.Forms.RadioButton();
            this.RBGreater500 = new System.Windows.Forms.RadioButton();
            this.RBLess50 = new System.Windows.Forms.RadioButton();
            this.RBGreater50 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRandom1 = new System.Windows.Forms.ComboBox();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz03_AAF19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Count";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(487, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 55);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBLess500
            // 
            this.RBLess500.AutoSize = true;
            this.RBLess500.Location = new System.Drawing.Point(14, 179);
            this.RBLess500.Name = "RBLess500";
            this.RBLess500.Size = new System.Drawing.Size(119, 21);
            this.RBLess500.TabIndex = 2;
            this.RBLess500.TabStop = true;
            this.RBLess500.Text = "Less than 500";
            this.RBLess500.UseVisualStyleBackColor = true;
            // 
            // RBGreater500
            // 
            this.RBGreater500.AutoSize = true;
            this.RBGreater500.Location = new System.Drawing.Point(14, 218);
            this.RBGreater500.Name = "RBGreater500";
            this.RBGreater500.Size = new System.Drawing.Size(138, 21);
            this.RBGreater500.TabIndex = 2;
            this.RBGreater500.TabStop = true;
            this.RBGreater500.Text = "Greater than 500";
            this.RBGreater500.UseVisualStyleBackColor = true;
            // 
            // RBLess50
            // 
            this.RBLess50.AutoSize = true;
            this.RBLess50.Location = new System.Drawing.Point(336, 179);
            this.RBLess50.Name = "RBLess50";
            this.RBLess50.Size = new System.Drawing.Size(111, 21);
            this.RBLess50.TabIndex = 2;
            this.RBLess50.TabStop = true;
            this.RBLess50.Text = "Less than 50";
            this.RBLess50.UseVisualStyleBackColor = true;
            // 
            // RBGreater50
            // 
            this.RBGreater50.AutoSize = true;
            this.RBGreater50.Location = new System.Drawing.Point(336, 218);
            this.RBGreater50.Name = "RBGreater50";
            this.RBGreater50.Size = new System.Drawing.Size(130, 21);
            this.RBGreater50.TabIndex = 2;
            this.RBGreater50.TabStop = true;
            this.RBGreater50.Text = "Greater than 50";
            this.RBGreater50.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quiz03_EAF19";
            // 
            // cmbRandom1
            // 
            this.cmbRandom1.FormattingEnabled = true;
            this.cmbRandom1.Location = new System.Drawing.Point(14, 121);
            this.cmbRandom1.Name = "cmbRandom1";
            this.cmbRandom1.Size = new System.Drawing.Size(138, 24);
            this.cmbRandom1.TabIndex = 3;
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(336, 121);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(138, 24);
            this.cmbRandom2.TabIndex = 3;
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.Location = new System.Drawing.Point(195, 122);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(86, 23);
            this.btnGenerate1.TabIndex = 4;
            this.btnGenerate1.Text = "Generate";
            this.btnGenerate1.UseVisualStyleBackColor = true;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.Location = new System.Drawing.Point(518, 122);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(86, 23);
            this.btnGenerate2.TabIndex = 5;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = true;
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(31, 268);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(86, 23);
            this.btnReset1.TabIndex = 6;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(351, 268);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(86, 23);
            this.btnReset2.TabIndex = 7;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 384);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.btnGenerate2);
            this.Controls.Add(this.btnGenerate1);
            this.Controls.Add(this.cmbRandom2);
            this.Controls.Add(this.cmbRandom1);
            this.Controls.Add(this.RBGreater50);
            this.Controls.Add(this.RBLess50);
            this.Controls.Add(this.RBGreater500);
            this.Controls.Add(this.RBLess500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRandomCombo";
            this.Text = "RandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton RBLess500;
        private System.Windows.Forms.RadioButton RBGreater500;
        private System.Windows.Forms.RadioButton RBLess50;
        private System.Windows.Forms.RadioButton RBGreater50;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRandom1;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
    }
}