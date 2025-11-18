namespace P6_1_714240024
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
            this.judul = new System.Windows.Forms.Label();
            this.vbButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(124, 47);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(461, 24);
            this.judul.TabIndex = 0;
            this.judul.Text = "Which do you think is better, Visual Basic or C#?";
            // 
            // vbButton
            // 
            this.vbButton.ForeColor = System.Drawing.Color.Green;
            this.vbButton.Location = new System.Drawing.Point(181, 152);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(81, 31);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = true;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.ForeColor = System.Drawing.Color.Red;
            this.csButton.Location = new System.Drawing.Point(446, 152);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(81, 31);
            this.csButton.TabIndex = 2;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = true;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(91, 285);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 31);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(696, 369);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.judul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
    }
}

