﻿
namespace Outil_Mutation_Automate
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            HauteurProduitLabel = new Label();
            hauteur = new TextBox();
            label1 = new Label();
            BtnCalculer = new Button();
            moyenne = new TextBox();
            FreqLabel = new Label();
            frequence = new TextBox();
            label2 = new Label();
            hauteurG = new TextBox();
            bienvenue = new Label();
            label3 = new Label();
            label4 = new Label();
            cerp = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ligne4 = new Label();
            ligne3 = new Label();
            ligne2 = new Label();
            ligne1 = new Label();
            label5 = new Label();
            Conclusionlabel = new Label();
            groupBox3 = new GroupBox();
            ligne8 = new Label();
            ligne7 = new Label();
            ligne6 = new Label();
            ligne5 = new Label();
            process1 = new System.Diagnostics.Process();
            infobutton = new Button();
            btnEnregistrer = new Button();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // HauteurProduitLabel
            // 
            HauteurProduitLabel.AutoSize = true;
            HauteurProduitLabel.Location = new Point(31, 24);
            HauteurProduitLabel.Name = "HauteurProduitLabel";
            HauteurProduitLabel.Size = new Size(182, 24);
            HauteurProduitLabel.TabIndex = 0;
            HauteurProduitLabel.Text = "Hauteur produit (mm)";
            // 
            // hauteur
            // 
            hauteur.Cursor = Cursors.IBeam;
            hauteur.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hauteur.Location = new Point(31, 60);
            hauteur.Name = "hauteur";
            hauteur.Size = new Size(274, 31);
            hauteur.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 112);
            label1.Name = "label1";
            label1.Size = new Size(254, 24);
            label1.TabIndex = 2;
            label1.Text = "Moyenne des ventes (par mois)";
            // 
            // BtnCalculer
            // 
            BtnCalculer.FlatAppearance.BorderColor = SystemColors.Control;
            BtnCalculer.Location = new Point(722, 648);
            BtnCalculer.Name = "BtnCalculer";
            BtnCalculer.Size = new Size(112, 41);
            BtnCalculer.TabIndex = 3;
            BtnCalculer.Text = "Calculer";
            BtnCalculer.UseVisualStyleBackColor = true;
            BtnCalculer.Click += BtnCalculer_Click;
            // 
            // moyenne
            // 
            moyenne.Cursor = Cursors.IBeam;
            moyenne.Location = new Point(31, 152);
            moyenne.Name = "moyenne";
            moyenne.Size = new Size(274, 31);
            moyenne.TabIndex = 4;
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Location = new Point(484, 24);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(268, 24);
            FreqLabel.TabIndex = 5;
            FreqLabel.Text = "Fréquence picking mensuel (M-1)";
            // 
            // frequence
            // 
            frequence.Cursor = Cursors.IBeam;
            frequence.Location = new Point(484, 60);
            frequence.Name = "frequence";
            frequence.Size = new Size(274, 31);
            frequence.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 112);
            label2.Name = "label2";
            label2.Size = new Size(240, 24);
            label2.TabIndex = 7;
            label2.Text = "Hauteur du canal désiré (mm)";
            // 
            // hauteurG
            // 
            hauteurG.Cursor = Cursors.IBeam;
            hauteurG.Location = new Point(484, 152);
            hauteurG.Name = "hauteurG";
            hauteurG.Size = new Size(274, 31);
            hauteurG.TabIndex = 8;
            // 
            // bienvenue
            // 
            bienvenue.AutoSize = true;
            bienvenue.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bienvenue.Location = new Point(45, 105);
            bienvenue.Name = "bienvenue";
            bienvenue.Size = new Size(402, 24);
            bienvenue.TabIndex = 9;
            bienvenue.Text = "Bienvenue sur l'outil d'aide à la mutation automate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 130);
            label3.Name = "label3";
            label3.Size = new Size(200, 24);
            label3.TabIndex = 10;
            label3.Text = "Créé par Calvin N'Diaye ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(45, 158);
            label4.Name = "label4";
            label4.Size = new Size(47, 24);
            label4.TabIndex = 11;
            label4.Text = "v.2.0";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(614, 40);
            cerp.Name = "cerp";
            cerp.Size = new Size(220, 200);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 12;
            cerp.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hauteurG);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(frequence);
            groupBox1.Controls.Add(FreqLabel);
            groupBox1.Controls.Add(moyenne);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(hauteur);
            groupBox1.Controls.Add(HauteurProduitLabel);
            groupBox1.Location = new Point(45, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 202);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(ligne4);
            groupBox2.Controls.Add(ligne3);
            groupBox2.Controls.Add(ligne2);
            groupBox2.Controls.Add(ligne1);
            groupBox2.Location = new Point(45, 264);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(789, 174);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // ligne4
            // 
            ligne4.AutoSize = true;
            ligne4.ForeColor = Color.Black;
            ligne4.Location = new Point(19, 127);
            ligne4.Name = "ligne4";
            ligne4.Size = new Size(0, 24);
            ligne4.TabIndex = 3;
            // 
            // ligne3
            // 
            ligne3.AutoSize = true;
            ligne3.ForeColor = Color.Black;
            ligne3.Location = new Point(19, 94);
            ligne3.Name = "ligne3";
            ligne3.Size = new Size(0, 24);
            ligne3.TabIndex = 2;
            // 
            // ligne2
            // 
            ligne2.AutoSize = true;
            ligne2.ForeColor = Color.Black;
            ligne2.Location = new Point(19, 62);
            ligne2.Name = "ligne2";
            ligne2.Size = new Size(0, 24);
            ligne2.TabIndex = 1;
            // 
            // ligne1
            // 
            ligne1.AutoSize = true;
            ligne1.ForeColor = Color.Black;
            ligne1.Location = new Point(19, 30);
            ligne1.Name = "ligne1";
            ligne1.Size = new Size(0, 24);
            ligne1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(45, 248);
            label5.Name = "label5";
            label5.Size = new Size(101, 24);
            label5.TabIndex = 15;
            label5.Text = "Résultats : ";
            // 
            // Conclusionlabel
            // 
            Conclusionlabel.AutoSize = true;
            Conclusionlabel.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Conclusionlabel.ForeColor = Color.MidnightBlue;
            Conclusionlabel.Location = new Point(45, 673);
            Conclusionlabel.Name = "Conclusionlabel";
            Conclusionlabel.Size = new Size(126, 24);
            Conclusionlabel.TabIndex = 17;
            Conclusionlabel.Text = "Conclusions : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ligne8);
            groupBox3.Controls.Add(ligne7);
            groupBox3.Controls.Add(ligne6);
            groupBox3.Controls.Add(ligne5);
            groupBox3.Location = new Point(45, 689);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(789, 174);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // ligne8
            // 
            ligne8.AutoSize = true;
            ligne8.ForeColor = Color.Black;
            ligne8.Location = new Point(14, 129);
            ligne8.Name = "ligne8";
            ligne8.Size = new Size(0, 24);
            ligne8.TabIndex = 3;
            // 
            // ligne7
            // 
            ligne7.AutoSize = true;
            ligne7.ForeColor = Color.Black;
            ligne7.Location = new Point(14, 96);
            ligne7.Name = "ligne7";
            ligne7.Size = new Size(0, 24);
            ligne7.TabIndex = 2;
            // 
            // ligne6
            // 
            ligne6.AutoSize = true;
            ligne6.ForeColor = Color.Black;
            ligne6.Location = new Point(14, 64);
            ligne6.Name = "ligne6";
            ligne6.Size = new Size(0, 24);
            ligne6.TabIndex = 1;
            // 
            // ligne5
            // 
            ligne5.AutoSize = true;
            ligne5.ForeColor = Color.Black;
            ligne5.Location = new Point(14, 32);
            ligne5.Name = "ligne5";
            ligne5.Size = new Size(0, 24);
            ligne5.TabIndex = 0;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // infobutton
            // 
            infobutton.BackgroundImage = (Image)resources.GetObject("infobutton.BackgroundImage");
            infobutton.BackgroundImageLayout = ImageLayout.Stretch;
            infobutton.Location = new Point(3, 3);
            infobutton.Name = "infobutton";
            infobutton.Size = new Size(45, 44);
            infobutton.TabIndex = 18;
            infobutton.UseVisualStyleBackColor = true;
            infobutton.Click += infobutton_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.FlatAppearance.BorderColor = SystemColors.Control;
            btnEnregistrer.Location = new Point(588, 648);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(112, 41);
            btnEnregistrer.TabIndex = 19;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += enregistrement_Click;
            // 
            // MenuPrincipal
            // 
            AcceptButton = BtnCalculer;
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 911);
            Controls.Add(btnEnregistrer);
            Controls.Add(infobutton);
            Controls.Add(Conclusionlabel);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cerp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bienvenue);
            Controls.Add(BtnCalculer);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Outil Mutation Automate";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Label HauteurProduitLabel;
        private TextBox hauteur;
        private Label label1;
        private Button BtnCalculer;
        private TextBox moyenne;
        private Label FreqLabel;
        private TextBox frequence;
        private Label label2;
        private TextBox hauteurG;
        private Label bienvenue;
        private Label label3;
        private Label label4;
        private PictureBox cerp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label ligne1;
        private Label ligne2;
        private Label ligne3;
        private Label ligne4;
        private Label Conclusionlabel;
        private GroupBox groupBox3;
        private Label ligne8;
        private Label ligne7;
        private Label ligne6;
        private Label ligne5;
        private System.Diagnostics.Process process1;
        private Button infobutton;
        private Button btnEnregistrer;
    }
}
