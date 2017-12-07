namespace Testing_features
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
            this.ReadImg_button = new System.Windows.Forms.Button();
            this.HOG_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadImg_button
            // 
            this.ReadImg_button.Location = new System.Drawing.Point(13, 13);
            this.ReadImg_button.Name = "ReadImg_button";
            this.ReadImg_button.Size = new System.Drawing.Size(75, 23);
            this.ReadImg_button.TabIndex = 0;
            this.ReadImg_button.Text = "Read Img";
            this.ReadImg_button.UseVisualStyleBackColor = true;
            this.ReadImg_button.Click += new System.EventHandler(this.ReadImg_button_Click);
            // 
            // HOG_button
            // 
            this.HOG_button.Location = new System.Drawing.Point(13, 43);
            this.HOG_button.Name = "HOG_button";
            this.HOG_button.Size = new System.Drawing.Size(75, 23);
            this.HOG_button.TabIndex = 1;
            this.HOG_button.Text = "HOG";
            this.HOG_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HOG_button);
            this.Controls.Add(this.ReadImg_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadImg_button;
        private System.Windows.Forms.Button HOG_button;
        private System.Windows.Forms.Label label1;
    }
}

