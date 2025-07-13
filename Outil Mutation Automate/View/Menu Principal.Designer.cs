
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
            moyenne = new TextBox();
            FreqLabel = new Label();
            frequence = new TextBox();
            label2 = new Label();
            hauteurG = new TextBox();
            bienvenue = new Label();
            label3 = new Label();
            lbversion = new Label();
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
            BtnVider = new Button();
            mySiticoneLicenseSettings1 = new SiticoneNetCoreUI.MySiticoneLicenseSettings();
            SbtnEnregistrer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SbtnCalculer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ProgressBar = new SiticoneNetCoreUI.SiticoneHProgressBar();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // HauteurProduitLabel
            // 
            HauteurProduitLabel.AutoSize = true;
            HauteurProduitLabel.Location = new Point(27, 24);
            HauteurProduitLabel.Name = "HauteurProduitLabel";
            HauteurProduitLabel.Size = new Size(210, 24);
            HauteurProduitLabel.TabIndex = 0;
            HauteurProduitLabel.Text = "Hauteur produit (mm) : ";
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
            label1.Location = new Point(27, 112);
            label1.Name = "label1";
            label1.Size = new Size(286, 24);
            label1.TabIndex = 2;
            label1.Text = "Moyenne des ventes (par mois) : ";
            // 
            // moyenne
            // 
            moyenne.Cursor = Cursors.IBeam;
            moyenne.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moyenne.Location = new Point(31, 152);
            moyenne.Name = "moyenne";
            moyenne.Size = new Size(274, 31);
            moyenne.TabIndex = 4;
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Location = new Point(480, 24);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(229, 24);
            FreqLabel.TabIndex = 5;
            FreqLabel.Text = "Fréquence picking (M-1) : ";
            // 
            // frequence
            // 
            frequence.Cursor = Cursors.IBeam;
            frequence.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequence.Location = new Point(484, 60);
            frequence.Name = "frequence";
            frequence.Size = new Size(274, 31);
            frequence.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 112);
            label2.Name = "label2";
            label2.Size = new Size(274, 24);
            label2.TabIndex = 7;
            label2.Text = "Hauteur du canal désiré (mm) : ";
            // 
            // hauteurG
            // 
            hauteurG.Cursor = Cursors.IBeam;
            hauteurG.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hauteurG.Location = new Point(484, 152);
            hauteurG.Name = "hauteurG";
            hauteurG.Size = new Size(274, 31);
            hauteurG.TabIndex = 8;
            // 
            // bienvenue
            // 
            bienvenue.AutoSize = true;
            bienvenue.BackColor = Color.Transparent;
            bienvenue.FlatStyle = FlatStyle.Popup;
            bienvenue.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bienvenue.ForeColor = Color.LimeGreen;
            bienvenue.Location = new Point(45, 105);
            bienvenue.Name = "bienvenue";
            bienvenue.Size = new Size(535, 30);
            bienvenue.TabIndex = 9;
            bienvenue.Text = "Bienvenue sur l'outil d'aide à la mutation automate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(45, 135);
            label3.Name = "label3";
            label3.Size = new Size(213, 24);
            label3.TabIndex = 9;
            label3.Text = "Créé par Calvin N'diaye ";
            // 
            // lbversion
            // 
            lbversion.AutoSize = true;
            lbversion.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbversion.ForeColor = SystemColors.ButtonShadow;
            lbversion.Location = new Point(45, 159);
            lbversion.Name = "lbversion";
            lbversion.Size = new Size(50, 24);
            lbversion.TabIndex = 11;
            lbversion.Text = "v.3.0";
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
            groupBox1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label5.Font = new Font("Segoe UI Variable Small Semibol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(45, 248);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 15;
            label5.Text = "Résultats : ";
            // 
            // Conclusionlabel
            // 
            Conclusionlabel.AutoSize = true;
            Conclusionlabel.Font = new Font("Segoe UI Variable Small Semibol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Conclusionlabel.ForeColor = Color.MidnightBlue;
            Conclusionlabel.Location = new Point(45, 673);
            Conclusionlabel.Name = "Conclusionlabel";
            Conclusionlabel.Size = new Size(139, 27);
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
            // BtnVider
            // 
            BtnVider.BackgroundImage = (Image)resources.GetObject("BtnVider.BackgroundImage");
            BtnVider.BackgroundImageLayout = ImageLayout.Stretch;
            BtnVider.FlatAppearance.BorderColor = SystemColors.Control;
            BtnVider.Location = new Point(539, 648);
            BtnVider.Name = "BtnVider";
            BtnVider.Size = new Size(42, 41);
            BtnVider.TabIndex = 20;
            BtnVider.UseVisualStyleBackColor = true;
            BtnVider.Click += BtnVider_Click;
            // 
            // SbtnEnregistrer
            // 
            SbtnEnregistrer.BackColor = Color.Transparent;
            SbtnEnregistrer.BadgeBackColor = Color.Red;
            SbtnEnregistrer.BadgeForeColor = Color.White;
            SbtnEnregistrer.BadgeRadius = 10;
            SbtnEnregistrer.BadgeRightMargin = 10;
            SbtnEnregistrer.BadgeValue = 0;
            SbtnEnregistrer.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnEnregistrer.BorderColorEnd = Color.Gray;
            SbtnEnregistrer.BorderColorStart = Color.White;
            SbtnEnregistrer.BorderRadiusBottomLeft = 25;
            SbtnEnregistrer.BorderRadiusBottomRight = 25;
            SbtnEnregistrer.BorderRadiusTopLeft = 25;
            SbtnEnregistrer.BorderRadiusTopRight = 25;
            SbtnEnregistrer.BorderThickness = 1;
            SbtnEnregistrer.ButtonColorEnd = Color.Green;
            SbtnEnregistrer.ButtonColorStart = Color.LimeGreen;
            SbtnEnregistrer.ButtonImage = null;
            SbtnEnregistrer.CanBeep = false;
            SbtnEnregistrer.CanShake = false;
            SbtnEnregistrer.ClickSoundPath = null;
            SbtnEnregistrer.DisabledOverlayOpacity = 0.5F;
            SbtnEnregistrer.EnableBorderGradient = false;
            SbtnEnregistrer.EnableClickSound = false;
            SbtnEnregistrer.EnableFocusBorder = false;
            SbtnEnregistrer.EnableHoverSound = false;
            SbtnEnregistrer.EnablePressScale = false;
            SbtnEnregistrer.EnableTextShadow = false;
            SbtnEnregistrer.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnEnregistrer.FocusBorderThickness = 2;
            SbtnEnregistrer.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnEnregistrer.ForeColor = Color.White;
            SbtnEnregistrer.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnEnregistrer.HoverSoundPath = null;
            SbtnEnregistrer.HoverTransitionSpeed = 1F;
            SbtnEnregistrer.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnEnregistrer.ImageLeftMargin = 5;
            SbtnEnregistrer.ImageRightMargin = 8;
            SbtnEnregistrer.ImageSize = 24;
            SbtnEnregistrer.IsReadOnly = false;
            SbtnEnregistrer.Location = new Point(587, 644);
            SbtnEnregistrer.MakeRadial = false;
            SbtnEnregistrer.Name = "SbtnEnregistrer";
            SbtnEnregistrer.PressAnimationSpeed = 0.5F;
            SbtnEnregistrer.PressDepth = 1;
            SbtnEnregistrer.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnEnregistrer.RippleExpandSpeedFactor = 0.05F;
            SbtnEnregistrer.RippleFadeSpeedFactor = 0.03F;
            SbtnEnregistrer.ShadowBlurFactor = 0.85F;
            SbtnEnregistrer.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnEnregistrer.ShadowOffsetX = 3;
            SbtnEnregistrer.ShadowOffsetY = 3;
            SbtnEnregistrer.Size = new Size(123, 50);
            SbtnEnregistrer.TabIndex = 21;
            SbtnEnregistrer.Text = "Enregistrer";
            SbtnEnregistrer.TextAlign = ContentAlignment.MiddleCenter;
            SbtnEnregistrer.TextPaddingBottom = 0;
            SbtnEnregistrer.TextPaddingLeft = 0;
            SbtnEnregistrer.TextPaddingRight = 0;
            SbtnEnregistrer.TextPaddingTop = 0;
            SbtnEnregistrer.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnEnregistrer.TextShadowOffsetX = 1;
            SbtnEnregistrer.TextShadowOffsetY = 1;
            SbtnEnregistrer.Click += SbtnEnregistrer_Click;
            // 
            // SbtnCalculer
            // 
            SbtnCalculer.BackColor = Color.Transparent;
            SbtnCalculer.BadgeBackColor = Color.Red;
            SbtnCalculer.BadgeForeColor = Color.White;
            SbtnCalculer.BadgeRadius = 10;
            SbtnCalculer.BadgeRightMargin = 10;
            SbtnCalculer.BadgeValue = 0;
            SbtnCalculer.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnCalculer.BorderColorEnd = Color.Gray;
            SbtnCalculer.BorderColorStart = Color.White;
            SbtnCalculer.BorderRadiusBottomLeft = 25;
            SbtnCalculer.BorderRadiusBottomRight = 25;
            SbtnCalculer.BorderRadiusTopLeft = 25;
            SbtnCalculer.BorderRadiusTopRight = 25;
            SbtnCalculer.BorderThickness = 1;
            SbtnCalculer.ButtonColorEnd = Color.MidnightBlue;
            SbtnCalculer.ButtonColorStart = Color.CornflowerBlue;
            SbtnCalculer.ButtonImage = null;
            SbtnCalculer.CanBeep = false;
            SbtnCalculer.CanShake = true;
            SbtnCalculer.ClickSoundPath = null;
            SbtnCalculer.DisabledOverlayOpacity = 0.5F;
            SbtnCalculer.EnableBorderGradient = false;
            SbtnCalculer.EnableClickSound = false;
            SbtnCalculer.EnableFocusBorder = false;
            SbtnCalculer.EnableHoverSound = false;
            SbtnCalculer.EnablePressScale = false;
            SbtnCalculer.EnableTextShadow = false;
            SbtnCalculer.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnCalculer.FocusBorderThickness = 2;
            SbtnCalculer.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnCalculer.ForeColor = Color.White;
            SbtnCalculer.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnCalculer.HoverSoundPath = null;
            SbtnCalculer.HoverTransitionSpeed = 1F;
            SbtnCalculer.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnCalculer.ImageLeftMargin = 5;
            SbtnCalculer.ImageRightMargin = 8;
            SbtnCalculer.ImageSize = 24;
            SbtnCalculer.IsReadOnly = false;
            SbtnCalculer.Location = new Point(716, 644);
            SbtnCalculer.MakeRadial = false;
            SbtnCalculer.Name = "SbtnCalculer";
            SbtnCalculer.PressAnimationSpeed = 0.5F;
            SbtnCalculer.PressDepth = 1;
            SbtnCalculer.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnCalculer.RippleExpandSpeedFactor = 0.05F;
            SbtnCalculer.RippleFadeSpeedFactor = 0.03F;
            SbtnCalculer.ShadowBlurFactor = 0.85F;
            SbtnCalculer.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnCalculer.ShadowOffsetX = 3;
            SbtnCalculer.ShadowOffsetY = 3;
            SbtnCalculer.Size = new Size(123, 50);
            SbtnCalculer.TabIndex = 22;
            SbtnCalculer.Text = "Calculer";
            SbtnCalculer.TextAlign = ContentAlignment.MiddleCenter;
            SbtnCalculer.TextPaddingBottom = 0;
            SbtnCalculer.TextPaddingLeft = 0;
            SbtnCalculer.TextPaddingRight = 0;
            SbtnCalculer.TextPaddingTop = 0;
            SbtnCalculer.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnCalculer.TextShadowOffsetX = 1;
            SbtnCalculer.TextShadowOffsetY = 1;
            SbtnCalculer.Click += SbtnCalculer_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.AccessibleDescription = "This control shows the value of the horizontal progress bar.";
            ProgressBar.AccessibleName = "Advanced and modern horizontal progress bar control";
            ProgressBar.AccessibleRole = AccessibleRole.ProgressBar;
            ProgressBar.AnimationDurationMs = 4000D;
            ProgressBar.AnimationTimerInterval = 20;
            ProgressBar.AutoLabelColor = false;
            ProgressBar.BackgroundBarColor = Color.White;
            ProgressBar.BorderColor = Color.FromArgb(34, 30, 65);
            ProgressBar.CanBeep = true;
            ProgressBar.CanShake = true;
            ProgressBar.CornerRadiusBottomLeft = 15;
            ProgressBar.CornerRadiusBottomRight = 15;
            ProgressBar.CornerRadiusTopLeft = 15;
            ProgressBar.CornerRadiusTopRight = 15;
            ProgressBar.CustomLabel = "Connexion en cours...";
            ProgressBar.EnableValueDragging = false;
            ProgressBar.ErrorColor = Color.Red;
            ProgressBar.GradientEndColor = Color.MidnightBlue;
            ProgressBar.GradientStartColor = Color.CornflowerBlue;
            ProgressBar.Indeterminate = false;
            ProgressBar.IndeterminateBarColor = Color.FromArgb(34, 30, 65);
            ProgressBar.IsReadonly = false;
            ProgressBar.LabelColor = Color.Transparent;
            ProgressBar.LabelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            ProgressBar.Location = new Point(614, 246);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.MinimumSize = new Size(50, 20);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ReadonlyBorderColor = Color.DimGray;
            ProgressBar.ReadonlyFillColor1 = Color.Gray;
            ProgressBar.ReadonlyFillColor2 = Color.DarkGray;
            ProgressBar.ReadonlyForeColor = Color.White;
            ProgressBar.ShowFocusCue = false;
            ProgressBar.ShowPercentage = false;
            ProgressBar.Size = new Size(220, 21);
            ProgressBar.SuccessColor = Color.Green;
            ProgressBar.TabIndex = 23;
            ProgressBar.Value = 100;
            ProgressBar.ValueOrientation = SiticoneNetCoreUI.Helpers.ProgressBar.ProgressBarOrientation.Horizontal;
            ProgressBar.WarningColor = Color.Orange;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 903);
            Controls.Add(ProgressBar);
            Controls.Add(SbtnCalculer);
            Controls.Add(SbtnEnregistrer);
            Controls.Add(BtnVider);
            Controls.Add(infobutton);
            Controls.Add(Conclusionlabel);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cerp);
            Controls.Add(lbversion);
            Controls.Add(label3);
            Controls.Add(bienvenue);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Outil Mutation Automate";
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
        private TextBox moyenne;
        private Label FreqLabel;
        private TextBox frequence;
        private Label label2;
        private TextBox hauteurG;
        private Label bienvenue;
        private Label label3;
        private Label lbversion;
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
        private Button BtnVider;
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnEnregistrer;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnCalculer;
        private SiticoneNetCoreUI.SiticoneHProgressBar ProgressBar;
    }
}
