namespace ProjetTello
{
    partial class Controle_Drone
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
            this.droite = new System.Windows.Forms.Button();
            this.reculer = new System.Windows.Forms.Button();
            this.avancer = new System.Windows.Forms.Button();
            this.gauche = new System.Windows.Forms.Button();
            this.monter = new System.Windows.Forms.Button();
            this.descendre = new System.Windows.Forms.Button();
            this.decollerAtterrir = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.TurnClockwise = new System.Windows.Forms.Button();
            this.TurnPasClockwise = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.lbletat = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.Button();
            this.distanceNumber = new System.Windows.Forms.NumericUpDown();
            this.rotationLeft = new System.Windows.Forms.NumericUpDown();
            this.rotationRight = new System.Windows.Forms.NumericUpDown();
            this.hauteurDist = new System.Windows.Forms.NumericUpDown();
            this.DescendreDist = new System.Windows.Forms.NumericUpDown();
            this.batteryLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hauteurDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescendreDist)).BeginInit();
            this.SuspendLayout();
            // 
            // droite
            // 
            this.droite.Location = new System.Drawing.Point(509, 190);
            this.droite.Name = "droite";
            this.droite.Size = new System.Drawing.Size(75, 23);
            this.droite.TabIndex = 0;
            this.droite.Text = "Droite";
            this.droite.UseVisualStyleBackColor = true;
            this.droite.Click += new System.EventHandler(this.droite_Click);
            // 
            // reculer
            // 
            this.reculer.Location = new System.Drawing.Point(367, 260);
            this.reculer.Name = "reculer";
            this.reculer.Size = new System.Drawing.Size(75, 23);
            this.reculer.TabIndex = 1;
            this.reculer.Text = "Reculer";
            this.reculer.UseVisualStyleBackColor = true;
            this.reculer.Click += new System.EventHandler(this.reculer_Click);
            // 
            // avancer
            // 
            this.avancer.Location = new System.Drawing.Point(367, 122);
            this.avancer.Name = "avancer";
            this.avancer.Size = new System.Drawing.Size(75, 23);
            this.avancer.TabIndex = 2;
            this.avancer.Text = "Avancer";
            this.avancer.UseVisualStyleBackColor = true;
            this.avancer.Click += new System.EventHandler(this.avancer_Click);
            // 
            // gauche
            // 
            this.gauche.Location = new System.Drawing.Point(222, 190);
            this.gauche.Name = "gauche";
            this.gauche.Size = new System.Drawing.Size(75, 23);
            this.gauche.TabIndex = 3;
            this.gauche.Text = "Gauche";
            this.gauche.UseVisualStyleBackColor = true;
            this.gauche.Click += new System.EventHandler(this.gauche_Click);
            // 
            // monter
            // 
            this.monter.Location = new System.Drawing.Point(165, 26);
            this.monter.Name = "monter";
            this.monter.Size = new System.Drawing.Size(75, 23);
            this.monter.TabIndex = 4;
            this.monter.Text = "Monter";
            this.monter.UseVisualStyleBackColor = true;
            this.monter.Click += new System.EventHandler(this.monter_Click);
            // 
            // descendre
            // 
            this.descendre.Location = new System.Drawing.Point(165, 92);
            this.descendre.Name = "descendre";
            this.descendre.Size = new System.Drawing.Size(75, 23);
            this.descendre.TabIndex = 5;
            this.descendre.Text = "Descendre";
            this.descendre.UseVisualStyleBackColor = true;
            this.descendre.Click += new System.EventHandler(this.descendre_Click);
            // 
            // decollerAtterrir
            // 
            this.decollerAtterrir.AutoEllipsis = true;
            this.decollerAtterrir.Location = new System.Drawing.Point(41, 387);
            this.decollerAtterrir.Name = "decollerAtterrir";
            this.decollerAtterrir.Size = new System.Drawing.Size(158, 23);
            this.decollerAtterrir.TabIndex = 6;
            this.decollerAtterrir.Text = "Décoller / Attérir";
            this.decollerAtterrir.UseVisualStyleBackColor = true;
            this.decollerAtterrir.Click += new System.EventHandler(this.decollerAtterrir_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(685, 387);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 7;
            this.end.Text = "Quitter";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // TurnClockwise
            // 
            this.TurnClockwise.Location = new System.Drawing.Point(41, 260);
            this.TurnClockwise.Name = "TurnClockwise";
            this.TurnClockwise.Size = new System.Drawing.Size(108, 23);
            this.TurnClockwise.TabIndex = 8;
            this.TurnClockwise.Text = "Tourner Gauche";
            this.TurnClockwise.UseVisualStyleBackColor = true;
            this.TurnClockwise.Click += new System.EventHandler(this.TurnClockwise_Click);
            // 
            // TurnPasClockwise
            // 
            this.TurnPasClockwise.Location = new System.Drawing.Point(635, 260);
            this.TurnPasClockwise.Name = "TurnPasClockwise";
            this.TurnPasClockwise.Size = new System.Drawing.Size(126, 23);
            this.TurnPasClockwise.TabIndex = 9;
            this.TurnPasClockwise.Text = "Tourner Droite";
            this.TurnPasClockwise.UseVisualStyleBackColor = true;
            this.TurnPasClockwise.Click += new System.EventHandler(this.TurnPasClockwise_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(621, 7);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(114, 23);
            this.connect.TabIndex = 10;
            this.connect.Text = "Mise à jour Batterie";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // lbletat
            // 
            this.lbletat.AutoSize = true;
            this.lbletat.Location = new System.Drawing.Point(231, 392);
            this.lbletat.Name = "lbletat";
            this.lbletat.Size = new System.Drawing.Size(35, 13);
            this.lbletat.TabIndex = 12;
            this.lbletat.Text = "label1";
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(528, 386);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(75, 23);
            this.auto.TabIndex = 16;
            this.auto.Text = "Mode Auto";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // distanceNumber
            // 
            this.distanceNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.distanceNumber.Location = new System.Drawing.Point(347, 190);
            this.distanceNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distanceNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.distanceNumber.Name = "distanceNumber";
            this.distanceNumber.Size = new System.Drawing.Size(120, 20);
            this.distanceNumber.TabIndex = 17;
            this.distanceNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.distanceNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rotationLeft
            // 
            this.rotationLeft.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rotationLeft.Location = new System.Drawing.Point(166, 260);
            this.rotationLeft.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationLeft.Name = "rotationLeft";
            this.rotationLeft.Size = new System.Drawing.Size(120, 20);
            this.rotationLeft.TabIndex = 18;
            this.rotationLeft.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.rotationLeft.ValueChanged += new System.EventHandler(this.rotationLeft_ValueChanged);
            // 
            // rotationRight
            // 
            this.rotationRight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rotationRight.Location = new System.Drawing.Point(509, 260);
            this.rotationRight.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationRight.Name = "rotationRight";
            this.rotationRight.Size = new System.Drawing.Size(120, 20);
            this.rotationRight.TabIndex = 19;
            this.rotationRight.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.rotationRight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // hauteurDist
            // 
            this.hauteurDist.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hauteurDist.Location = new System.Drawing.Point(28, 29);
            this.hauteurDist.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.hauteurDist.Name = "hauteurDist";
            this.hauteurDist.Size = new System.Drawing.Size(120, 20);
            this.hauteurDist.TabIndex = 20;
            this.hauteurDist.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // DescendreDist
            // 
            this.DescendreDist.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DescendreDist.Location = new System.Drawing.Point(28, 95);
            this.DescendreDist.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.DescendreDist.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DescendreDist.Name = "DescendreDist";
            this.DescendreDist.Size = new System.Drawing.Size(120, 20);
            this.DescendreDist.TabIndex = 21;
            this.DescendreDist.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DescendreDist.ValueChanged += new System.EventHandler(this.DescendreDist_ValueChanged);
            // 
            // batteryLevel
            // 
            this.batteryLevel.AutoSize = true;
            this.batteryLevel.Location = new System.Drawing.Point(742, 12);
            this.batteryLevel.Name = "batteryLevel";
            this.batteryLevel.Size = new System.Drawing.Size(0, 13);
            this.batteryLevel.TabIndex = 22;
            this.batteryLevel.Click += new System.EventHandler(this.batteryLevel_Click);
            // 
            // Controle_Drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.batteryLevel);
            this.Controls.Add(this.DescendreDist);
            this.Controls.Add(this.hauteurDist);
            this.Controls.Add(this.rotationRight);
            this.Controls.Add(this.rotationLeft);
            this.Controls.Add(this.distanceNumber);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.lbletat);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.TurnPasClockwise);
            this.Controls.Add(this.TurnClockwise);
            this.Controls.Add(this.end);
            this.Controls.Add(this.decollerAtterrir);
            this.Controls.Add(this.descendre);
            this.Controls.Add(this.monter);
            this.Controls.Add(this.gauche);
            this.Controls.Add(this.avancer);
            this.Controls.Add(this.reculer);
            this.Controls.Add(this.droite);
            this.Name = "Controle_Drone";
            this.Text = "Controle Drone";
            this.Load += new System.EventHandler(this.Controle_Drone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hauteurDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescendreDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button droite;
        private System.Windows.Forms.Button reculer;
        private System.Windows.Forms.Button avancer;
        private System.Windows.Forms.Button gauche;
        private System.Windows.Forms.Button monter;
        private System.Windows.Forms.Button descendre;
        private System.Windows.Forms.Button decollerAtterrir;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button TurnClockwise;
        private System.Windows.Forms.Button TurnPasClockwise;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label lbletat;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.NumericUpDown distanceNumber;
        private System.Windows.Forms.NumericUpDown rotationLeft;
        private System.Windows.Forms.NumericUpDown rotationRight;
        private System.Windows.Forms.NumericUpDown hauteurDist;
        private System.Windows.Forms.NumericUpDown DescendreDist;
        private System.Windows.Forms.Label batteryLevel;
    }
}