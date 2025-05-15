
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
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // HauteurProduitLabel
            // 
            HauteurProduitLabel.AutoSize = true;
            HauteurProduitLabel.Location = new Point(31, 25);
            HauteurProduitLabel.Name = "HauteurProduitLabel";
            HauteurProduitLabel.Size = new Size(186, 25);
            HauteurProduitLabel.TabIndex = 0;
            HauteurProduitLabel.Text = "Hauteur produit (mm)";
            // 
            // hauteur
            // 
            hauteur.Location = new Point(31, 63);
            hauteur.Name = "hauteur";
            hauteur.Size = new Size(274, 31);
            hauteur.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 117);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 2;
            label1.Text = "Moyenne des ventes (par mois)";
            // 
            // BtnCalculer
            // 
            BtnCalculer.Location = new Point(722, 670);
            BtnCalculer.Name = "BtnCalculer";
            BtnCalculer.Size = new Size(112, 43);
            BtnCalculer.TabIndex = 3;
            BtnCalculer.Text = "Calculer";
            BtnCalculer.UseVisualStyleBackColor = true;
            BtnCalculer.Click += BtnCalculer_Click;
            // 
            // moyenne
            // 
            moyenne.Location = new Point(31, 158);
            moyenne.Name = "moyenne";
            moyenne.Size = new Size(260, 31);
            moyenne.TabIndex = 4;
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Location = new Point(484, 25);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(274, 25);
            FreqLabel.TabIndex = 5;
            FreqLabel.Text = "Fréquence picking mensuel (M-1)";
            // 
            // frequence
            // 
            frequence.Location = new Point(484, 63);
            frequence.Name = "frequence";
            frequence.Size = new Size(274, 31);
            frequence.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 117);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 7;
            label2.Text = "Hauteur du canal désiré (mm)";
            // 
            // hauteurG
            // 
            hauteurG.Location = new Point(484, 158);
            hauteurG.Name = "hauteurG";
            hauteurG.Size = new Size(274, 31);
            hauteurG.TabIndex = 8;
            // 
            // bienvenue
            // 
            bienvenue.AutoSize = true;
            bienvenue.Location = new Point(45, 109);
            bienvenue.Name = "bienvenue";
            bienvenue.Size = new Size(412, 25);
            bienvenue.TabIndex = 9;
            bienvenue.Text = "Bienvenue sur l'outil d'aide à la mutation automate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 135);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 10;
            label3.Text = "Créé par Calvin ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(45, 165);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 11;
            label4.Text = "v.0.5";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(614, 42);
            cerp.Name = "cerp";
            cerp.Size = new Size(220, 208);
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
            groupBox1.Location = new Point(45, 453);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 199);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ligne4);
            groupBox2.Controls.Add(ligne3);
            groupBox2.Controls.Add(ligne2);
            groupBox2.Controls.Add(ligne1);
            groupBox2.Location = new Point(45, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(789, 181);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // ligne4
            // 
            ligne4.AutoSize = true;
            ligne4.ForeColor = Color.Black;
            ligne4.Location = new Point(19, 132);
            ligne4.Name = "ligne4";
            ligne4.Size = new Size(0, 25);
            ligne4.TabIndex = 3;
            // 
            // ligne3
            // 
            ligne3.AutoSize = true;
            ligne3.ForeColor = Color.Black;
            ligne3.Location = new Point(19, 98);
            ligne3.Name = "ligne3";
            ligne3.Size = new Size(0, 25);
            ligne3.TabIndex = 2;
            // 
            // ligne2
            // 
            ligne2.AutoSize = true;
            ligne2.ForeColor = Color.Black;
            ligne2.Location = new Point(19, 65);
            ligne2.Name = "ligne2";
            ligne2.Size = new Size(0, 25);
            ligne2.TabIndex = 1;
            // 
            // ligne1
            // 
            ligne1.AutoSize = true;
            ligne1.ForeColor = Color.Black;
            ligne1.Location = new Point(19, 31);
            ligne1.Name = "ligne1";
            ligne1.Size = new Size(0, 25);
            ligne1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 258);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 15;
            label5.Text = "Résultats : ";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(885, 730);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cerp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bienvenue);
            Controls.Add(BtnCalculer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Outil Mutation Automate";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
