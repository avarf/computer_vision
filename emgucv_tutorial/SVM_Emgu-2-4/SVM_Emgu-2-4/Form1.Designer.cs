namespace SVM_Emgu_2_4
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
            this.SVMDef_button = new System.Windows.Forms.Button();
            this.SVMTrain_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MySVMTrain_button = new System.Windows.Forms.Button();
            this.LoadImges_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SVMDef_button
            // 
            this.SVMDef_button.Location = new System.Drawing.Point(13, 13);
            this.SVMDef_button.Name = "SVMDef_button";
            this.SVMDef_button.Size = new System.Drawing.Size(75, 23);
            this.SVMDef_button.TabIndex = 0;
            this.SVMDef_button.Text = "SVM Def";
            this.SVMDef_button.UseVisualStyleBackColor = true;
            this.SVMDef_button.Click += new System.EventHandler(this.SVMDef_button_Click);
            // 
            // SVMTrain_button
            // 
            this.SVMTrain_button.Location = new System.Drawing.Point(95, 13);
            this.SVMTrain_button.Name = "SVMTrain_button";
            this.SVMTrain_button.Size = new System.Drawing.Size(75, 23);
            this.SVMTrain_button.TabIndex = 1;
            this.SVMTrain_button.Text = "SVM Train";
            this.SVMTrain_button.UseVisualStyleBackColor = true;
            this.SVMTrain_button.Click += new System.EventHandler(this.SVMTrain_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 400);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(987, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MySVMTrain_button
            // 
            this.MySVMTrain_button.Location = new System.Drawing.Point(177, 13);
            this.MySVMTrain_button.Name = "MySVMTrain_button";
            this.MySVMTrain_button.Size = new System.Drawing.Size(87, 23);
            this.MySVMTrain_button.TabIndex = 3;
            this.MySVMTrain_button.Text = "My SVM Train";
            this.MySVMTrain_button.UseVisualStyleBackColor = true;
            this.MySVMTrain_button.Click += new System.EventHandler(this.MySVMTrain_button_Click);
            // 
            // LoadImges_button
            // 
            this.LoadImges_button.Location = new System.Drawing.Point(271, 13);
            this.LoadImges_button.Name = "LoadImges_button";
            this.LoadImges_button.Size = new System.Drawing.Size(75, 23);
            this.LoadImges_button.TabIndex = 4;
            this.LoadImges_button.Text = "Load Imges";
            this.LoadImges_button.UseVisualStyleBackColor = true;
            this.LoadImges_button.Click += new System.EventHandler(this.LoadImges_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 446);
            this.Controls.Add(this.LoadImges_button);
            this.Controls.Add(this.MySVMTrain_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SVMTrain_button);
            this.Controls.Add(this.SVMDef_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SVMDef_button;
        private System.Windows.Forms.Button SVMTrain_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MySVMTrain_button;
        private System.Windows.Forms.Button LoadImges_button;
    }
}

