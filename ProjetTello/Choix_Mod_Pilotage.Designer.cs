namespace ProjetTello
{
    partial class Choix_Mod_Pilotage
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
            this.modeManuel = new System.Windows.Forms.Button();
            this.modeAutomatique = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modeManuel
            // 
            this.modeManuel.Location = new System.Drawing.Point(137, 93);
            this.modeManuel.Name = "modeManuel";
            this.modeManuel.Size = new System.Drawing.Size(75, 23);
            this.modeManuel.TabIndex = 0;
            this.modeManuel.Text = "Manuel";
            this.modeManuel.UseVisualStyleBackColor = true;
            this.modeManuel.Click += new System.EventHandler(this.modeManuel_Click);
            // 
            // modeAutomatique
            // 
            this.modeAutomatique.Location = new System.Drawing.Point(347, 93);
            this.modeAutomatique.Name = "modeAutomatique";
            this.modeAutomatique.Size = new System.Drawing.Size(75, 23);
            this.modeAutomatique.TabIndex = 1;
            this.modeAutomatique.Text = "Automatique";
            this.modeAutomatique.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez choisir un mode pour le drone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Choix_Mod_Pilotage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeAutomatique);
            this.Controls.Add(this.modeManuel);
            this.Name = "Choix_Mod_Pilotage";
            this.Text = "Choix mode";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modeManuel;
        private System.Windows.Forms.Button modeAutomatique;
        private System.Windows.Forms.Label label1;
    }
}