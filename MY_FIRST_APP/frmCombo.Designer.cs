namespace First_application
{
    partial class frmCombo
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
            this.btnShowSelected1 = new System.Windows.Forms.Button();
            this.btnShowSelected2 = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnRemove2ndLast = new System.Windows.Forms.Button();
            this.btnRemoveByIndex = new System.Windows.Forms.Button();
            this.btnRemoveByName = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnShowSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowSelected1
            // 
            this.btnShowSelected1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSelected1.Location = new System.Drawing.Point(87, 37);
            this.btnShowSelected1.Name = "btnShowSelected1";
            this.btnShowSelected1.Size = new System.Drawing.Size(152, 73);
            this.btnShowSelected1.TabIndex = 0;
            this.btnShowSelected1.Text = "Show Selected method 1";
            this.btnShowSelected1.UseVisualStyleBackColor = false;
            this.btnShowSelected1.Click += new System.EventHandler(this.btnShowSelected1_Click);
            // 
            // btnShowSelected2
            // 
            this.btnShowSelected2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSelected2.Location = new System.Drawing.Point(266, 37);
            this.btnShowSelected2.Name = "btnShowSelected2";
            this.btnShowSelected2.Size = new System.Drawing.Size(157, 73);
            this.btnShowSelected2.TabIndex = 0;
            this.btnShowSelected2.Text = "Show  Selected method 2";
            this.btnShowSelected2.UseVisualStyleBackColor = false;
            this.btnShowSelected2.Click += new System.EventHandler(this.btnShowSelected2_Click);
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(121, 161);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(138, 24);
            this.cmbDays.TabIndex = 1;
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveLast.Location = new System.Drawing.Point(544, 127);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(152, 73);
            this.btnRemoveLast.TabIndex = 0;
            this.btnRemoveLast.Text = "Remove Last Iteam ";
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnRemove2ndLast
            // 
            this.btnRemove2ndLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove2ndLast.Location = new System.Drawing.Point(544, 232);
            this.btnRemove2ndLast.Name = "btnRemove2ndLast";
            this.btnRemove2ndLast.Size = new System.Drawing.Size(152, 73);
            this.btnRemove2ndLast.TabIndex = 0;
            this.btnRemove2ndLast.Text = "Remove 2nd Last Iteam ";
            this.btnRemove2ndLast.UseVisualStyleBackColor = false;
            this.btnRemove2ndLast.Click += new System.EventHandler(this.btnRemove2ndLast_Click);
            // 
            // btnRemoveByIndex
            // 
            this.btnRemoveByIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRemoveByIndex.Location = new System.Drawing.Point(87, 274);
            this.btnRemoveByIndex.Name = "btnRemoveByIndex";
            this.btnRemoveByIndex.Size = new System.Drawing.Size(152, 73);
            this.btnRemoveByIndex.TabIndex = 0;
            this.btnRemoveByIndex.Text = "Remove By Index";
            this.btnRemoveByIndex.UseVisualStyleBackColor = false;
            this.btnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // btnRemoveByName
            // 
            this.btnRemoveByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRemoveByName.Location = new System.Drawing.Point(285, 274);
            this.btnRemoveByName.Name = "btnRemoveByName";
            this.btnRemoveByName.Size = new System.Drawing.Size(157, 73);
            this.btnRemoveByName.TabIndex = 0;
            this.btnRemoveByName.Text = "Remove By Name";
            this.btnRemoveByName.UseVisualStyleBackColor = false;
            this.btnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(883, 400);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(152, 73);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnShowSelected3
            // 
            this.btnShowSelected3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSelected3.Location = new System.Drawing.Point(438, 37);
            this.btnShowSelected3.Name = "btnShowSelected3";
            this.btnShowSelected3.Size = new System.Drawing.Size(157, 73);
            this.btnShowSelected3.TabIndex = 0;
            this.btnShowSelected3.Text = "Show  Selected method 3";
            this.btnShowSelected3.UseVisualStyleBackColor = false;
            this.btnShowSelected3.Click += new System.EventHandler(this.btnShowSelected3_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 505);
            this.Controls.Add(this.btnShowSelected3);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.btnRemoveByIndex);
            this.Controls.Add(this.btnRemoveByName);
            this.Controls.Add(this.btnShowSelected2);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnRemove2ndLast);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnShowSelected1);
            this.Name = "frmCombo";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowSelected1;
        private System.Windows.Forms.Button btnShowSelected2;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnRemove2ndLast;
        private System.Windows.Forms.Button btnRemoveByIndex;
        private System.Windows.Forms.Button btnRemoveByName;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnShowSelected3;
    }
}