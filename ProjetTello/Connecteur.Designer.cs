namespace ProjetTello
{
    partial class Connecteur
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
            this.submit = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(243, 68);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Connecter";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(115, 68);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 1;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "adresse ip :";
            // 
            // Connecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.submit);
            this.Name = "Connecteur";
            this.Text = "Connecteur";
            this.Load += new System.EventHandler(this.Connecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
    }
}