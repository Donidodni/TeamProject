namespace TeamProject
{
    partial class form2
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
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(170, 676);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 39);
            button1.TabIndex = 1;
            button1.Text = "유닛 생성";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel1.Location = new System.Drawing.Point(170, 183);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(480, 373);
            panel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(170, 562);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(480, 45);
            progressBar1.TabIndex = 3;
            // 
            // form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 861);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "form2";
            Text = "form2";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}