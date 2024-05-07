namespace ProjetTello
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
            this.goLeft = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.goDown = new System.Windows.Forms.Button();
            this.goRight = new System.Windows.Forms.Button();
            this.advance = new System.Windows.Forms.Button();
            this.takeOff = new System.Windows.Forms.Button();
            this.goUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goLeft
            // 
            this.goLeft.Location = new System.Drawing.Point(248, 212);
            this.goLeft.Name = "goLeft";
            this.goLeft.Size = new System.Drawing.Size(75, 23);
            this.goLeft.TabIndex = 0;
            this.goLeft.Text = "Gauche";
            this.goLeft.UseVisualStyleBackColor = true;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(374, 287);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 1;
            this.goBack.Text = "Reculer";
            this.goBack.UseVisualStyleBackColor = true;
            // 
            // goDown
            // 
            this.goDown.Location = new System.Drawing.Point(41, 117);
            this.goDown.Name = "goDown";
            this.goDown.Size = new System.Drawing.Size(75, 23);
            this.goDown.TabIndex = 2;
            this.goDown.Text = "Descendre";
            this.goDown.UseVisualStyleBackColor = true;
            this.goDown.Click += new System.EventHandler(this.button3_Click);
            // 
            // goRight
            // 
            this.goRight.Location = new System.Drawing.Point(489, 212);
            this.goRight.Name = "goRight";
            this.goRight.Size = new System.Drawing.Size(75, 23);
            this.goRight.TabIndex = 3;
            this.goRight.Text = "Droite";
            this.goRight.UseVisualStyleBackColor = true;
            // 
            // advance
            // 
            this.advance.Location = new System.Drawing.Point(374, 156);
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(75, 23);
            this.advance.TabIndex = 4;
            this.advance.Text = "Avancer";
            this.advance.UseVisualStyleBackColor = true;
            // 
            // takeOff
            // 
            this.takeOff.Location = new System.Drawing.Point(12, 415);
            this.takeOff.Name = "takeOff";
            this.takeOff.Size = new System.Drawing.Size(136, 23);
            this.takeOff.TabIndex = 5;
            this.takeOff.Text = "Décoller / Attérir";
            this.takeOff.UseVisualStyleBackColor = true;
            // 
            // goUp
            // 
            this.goUp.Location = new System.Drawing.Point(41, 64);
            this.goUp.Name = "goUp";
            this.goUp.Size = new System.Drawing.Size(75, 23);
            this.goUp.TabIndex = 6;
            this.goUp.Text = "Monter";
            this.goUp.UseVisualStyleBackColor = true;
            this.goUp.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goUp);
            this.Controls.Add(this.takeOff);
            this.Controls.Add(this.advance);
            this.Controls.Add(this.goRight);
            this.Controls.Add(this.goDown);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.goLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goLeft;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button goDown;
        private System.Windows.Forms.Button goRight;
        private System.Windows.Forms.Button advance;
        private System.Windows.Forms.Button takeOff;
        private System.Windows.Forms.Button goUp;
    }
}