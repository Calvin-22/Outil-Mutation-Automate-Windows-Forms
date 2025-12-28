
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            label3 = new Label();
            lbversion = new Label();
            cerp = new PictureBox();
            label5 = new Label();
            Conclusionlabel = new Label();
            ligne8 = new Label();
            ligne7 = new Label();
            ligne6 = new Label();
            ligne5 = new Label();
            process1 = new System.Diagnostics.Process();
            BtnVider = new Button();
            SbtnEnregistrer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SbtnCalculer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ProgressBar = new SiticoneNetCoreUI.SiticoneHProgressBar();
            SmoothCircular = new SiticoneNetCoreUI.SiticoneSmoothCircularSpinner();
            SmoothTimer = new System.Windows.Forms.Timer(components);
            btnFakeAccept = new Button();
            SbtnConsultation = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            mySiticoneLicenseSettings1 = new SiticoneNetCoreUI.MySiticoneLicenseSettings();
            siticoneGroupBox1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            ligne4 = new Label();
            ligne3 = new Label();
            ligne1 = new Label();
            ligne2 = new Label();
            infobutton = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            HauteurProduitLabel = new Label();
            hauteur = new TextBox();
            label1 = new Label();
            moyenne = new TextBox();
            FreqLabel = new Label();
            frequence = new TextBox();
            CodeGeoTxt = new TextBox();
            label2 = new Label();
            label4 = new Label();
            siticoneGroupBox2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            siticoneGroupBox1.SuspendLayout();
            siticoneGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(25, 142);
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
            lbversion.Location = new Point(26, 166);
            lbversion.Name = "lbversion";
            lbversion.Size = new Size(58, 24);
            lbversion.TabIndex = 11;
            lbversion.Text = "v8.5.1";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(557, 24);
            cerp.Name = "cerp";
            cerp.Size = new Size(213, 200);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 12;
            cerp.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(25, 230);
            label5.Name = "label5";
            label5.Size = new Size(115, 27);
            label5.TabIndex = 15;
            label5.Text = "Résultats : ";
            // 
            // Conclusionlabel
            // 
            Conclusionlabel.AutoSize = true;
            Conclusionlabel.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            Conclusionlabel.ForeColor = Color.MidnightBlue;
            Conclusionlabel.Location = new Point(25, 658);
            Conclusionlabel.Name = "Conclusionlabel";
            Conclusionlabel.Size = new Size(141, 27);
            Conclusionlabel.TabIndex = 17;
            Conclusionlabel.Text = "Conclusions : ";
            // 
            // ligne8
            // 
            ligne8.AutoSize = true;
            ligne8.Font = new Font("Segoe UI", 9F);
            ligne8.ForeColor = Color.Black;
            ligne8.Location = new Point(17, 168);
            ligne8.Name = "ligne8";
            ligne8.Size = new Size(0, 25);
            ligne8.TabIndex = 3;
            // 
            // ligne7
            // 
            ligne7.AutoSize = true;
            ligne7.Font = new Font("Segoe UI", 9F);
            ligne7.ForeColor = Color.Black;
            ligne7.Location = new Point(17, 135);
            ligne7.Name = "ligne7";
            ligne7.Size = new Size(0, 25);
            ligne7.TabIndex = 2;
            // 
            // ligne6
            // 
            ligne6.AutoSize = true;
            ligne6.Font = new Font("Segoe UI", 9F);
            ligne6.ForeColor = Color.Black;
            ligne6.Location = new Point(17, 103);
            ligne6.Name = "ligne6";
            ligne6.Size = new Size(0, 25);
            ligne6.TabIndex = 1;
            // 
            // ligne5
            // 
            ligne5.AutoSize = true;
            ligne5.Font = new Font("Segoe UI", 9F);
            ligne5.ForeColor = Color.Black;
            ligne5.Location = new Point(17, 71);
            ligne5.Name = "ligne5";
            ligne5.Size = new Size(0, 25);
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
            // BtnVider
            // 
            BtnVider.BackgroundImage = (Image)resources.GetObject("BtnVider.BackgroundImage");
            BtnVider.BackgroundImageLayout = ImageLayout.Stretch;
            BtnVider.FlatAppearance.BorderColor = SystemColors.Control;
            BtnVider.FlatAppearance.BorderSize = 0;
            BtnVider.FlatStyle = FlatStyle.Flat;
            BtnVider.ForeColor = Color.Transparent;
            BtnVider.Location = new Point(369, 632);
            BtnVider.Name = "BtnVider";
            BtnVider.Size = new Size(40, 41);
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
            SbtnEnregistrer.Location = new Point(541, 625);
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
            SbtnEnregistrer.Size = new Size(116, 50);
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
            SbtnCalculer.Location = new Point(656, 625);
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
            SbtnCalculer.Size = new Size(116, 50);
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
            ProgressBar.Location = new Point(557, 230);
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
            ProgressBar.Size = new Size(213, 21);
            ProgressBar.SuccessColor = Color.Green;
            ProgressBar.TabIndex = 23;
            ProgressBar.Value = 100;
            ProgressBar.ValueOrientation = SiticoneNetCoreUI.Helpers.ProgressBar.ProgressBarOrientation.Horizontal;
            ProgressBar.WarningColor = Color.Orange;
            // 
            // SmoothCircular
            // 
            SmoothCircular.ArcMaxLength = 270F;
            SmoothCircular.ArcMinLength = 150F;
            SmoothCircular.BackColor = Color.Transparent;
            SmoothCircular.IsAnimating = true;
            SmoothCircular.Location = new Point(306, 627);
            SmoothCircular.MinimumSize = new Size(50, 50);
            SmoothCircular.Name = "SmoothCircular";
            SmoothCircular.OscillationSpeed = 0.5F;
            SmoothCircular.ReverseDirection = false;
            SmoothCircular.RotationSpeed = 480F;
            SmoothCircular.Size = new Size(50, 50);
            SmoothCircular.StrokeColor = Color.Green;
            SmoothCircular.StrokeThickness = 7;
            SmoothCircular.TabIndex = 25;
            // 
            // SmoothTimer
            // 
            SmoothTimer.Interval = 1000;
            SmoothTimer.Tick += SmoothTimer_Tick;
            // 
            // btnFakeAccept
            // 
            btnFakeAccept.BackColor = Color.Transparent;
            btnFakeAccept.FlatAppearance.BorderSize = 0;
            btnFakeAccept.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFakeAccept.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFakeAccept.FlatStyle = FlatStyle.Flat;
            btnFakeAccept.ForeColor = Color.Transparent;
            btnFakeAccept.Location = new Point(844, 864);
            btnFakeAccept.Name = "btnFakeAccept";
            btnFakeAccept.Size = new Size(21, 27);
            btnFakeAccept.TabIndex = 26;
            btnFakeAccept.TabStop = false;
            btnFakeAccept.UseVisualStyleBackColor = false;
            btnFakeAccept.Click += btnFakeAccept_Click;
            // 
            // SbtnConsultation
            // 
            SbtnConsultation.BackColor = Color.Transparent;
            SbtnConsultation.BadgeBackColor = Color.Red;
            SbtnConsultation.BadgeForeColor = Color.White;
            SbtnConsultation.BadgeRadius = 10;
            SbtnConsultation.BadgeRightMargin = 10;
            SbtnConsultation.BadgeValue = 0;
            SbtnConsultation.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnConsultation.BorderColorEnd = Color.Gray;
            SbtnConsultation.BorderColorStart = Color.White;
            SbtnConsultation.BorderRadiusBottomLeft = 25;
            SbtnConsultation.BorderRadiusBottomRight = 25;
            SbtnConsultation.BorderRadiusTopLeft = 25;
            SbtnConsultation.BorderRadiusTopRight = 25;
            SbtnConsultation.BorderThickness = 1;
            SbtnConsultation.ButtonColorEnd = Color.Red;
            SbtnConsultation.ButtonColorStart = Color.Orange;
            SbtnConsultation.ButtonImage = null;
            SbtnConsultation.CanBeep = false;
            SbtnConsultation.CanShake = false;
            SbtnConsultation.ClickSoundPath = null;
            SbtnConsultation.DisabledOverlayOpacity = 0.5F;
            SbtnConsultation.EnableBorderGradient = false;
            SbtnConsultation.EnableClickSound = false;
            SbtnConsultation.EnableFocusBorder = false;
            SbtnConsultation.EnableHoverSound = false;
            SbtnConsultation.EnablePressScale = false;
            SbtnConsultation.EnableTextShadow = false;
            SbtnConsultation.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnConsultation.FocusBorderThickness = 2;
            SbtnConsultation.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnConsultation.ForeColor = Color.White;
            SbtnConsultation.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnConsultation.HoverSoundPath = null;
            SbtnConsultation.HoverTransitionSpeed = 1F;
            SbtnConsultation.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnConsultation.ImageLeftMargin = 5;
            SbtnConsultation.ImageRightMargin = 8;
            SbtnConsultation.ImageSize = 24;
            SbtnConsultation.IsReadOnly = false;
            SbtnConsultation.Location = new Point(410, 625);
            SbtnConsultation.MakeRadial = false;
            SbtnConsultation.Name = "SbtnConsultation";
            SbtnConsultation.PressAnimationSpeed = 0.5F;
            SbtnConsultation.PressDepth = 1;
            SbtnConsultation.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnConsultation.RippleExpandSpeedFactor = 0.05F;
            SbtnConsultation.RippleFadeSpeedFactor = 0.03F;
            SbtnConsultation.ShadowBlurFactor = 0.85F;
            SbtnConsultation.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnConsultation.ShadowOffsetX = 3;
            SbtnConsultation.ShadowOffsetY = 3;
            SbtnConsultation.Size = new Size(133, 50);
            SbtnConsultation.TabIndex = 27;
            SbtnConsultation.Text = "Consultation";
            SbtnConsultation.TextAlign = ContentAlignment.MiddleCenter;
            SbtnConsultation.TextPaddingBottom = 0;
            SbtnConsultation.TextPaddingLeft = 0;
            SbtnConsultation.TextPaddingRight = 0;
            SbtnConsultation.TextPaddingTop = 0;
            SbtnConsultation.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnConsultation.TextShadowOffsetX = 1;
            SbtnConsultation.TextShadowOffsetY = 1;
            SbtnConsultation.Click += SbtnConsultation_Click;
            // 
            // siticoneGroupBox1
            // 
            siticoneGroupBox1.BackColor = Color.Transparent;
            siticoneGroupBox1.BadgeColor = Color.Red;
            siticoneGroupBox1.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox1.BadgeLeftPadding = 12;
            siticoneGroupBox1.BadgeValue = 0;
            siticoneGroupBox1.BadgeVisible = false;
            siticoneGroupBox1.BlinkInterval = 500;
            siticoneGroupBox1.BlinkMinOpacity = 0.3F;
            siticoneGroupBox1.BlinkOpacityStep = 0.05F;
            siticoneGroupBox1.BorderColor = Color.LightGray;
            siticoneGroupBox1.BorderWidth = 3F;
            siticoneGroupBox1.CanHover = true;
            siticoneGroupBox1.ChevronColor = Color.Black;
            siticoneGroupBox1.ChevronLeftSpacing = 4F;
            siticoneGroupBox1.ChevronSize = 10F;
            siticoneGroupBox1.ChevronThickness = 2F;
            siticoneGroupBox1.ContentPadding = 5;
            siticoneGroupBox1.Controls.Add(ligne4);
            siticoneGroupBox1.Controls.Add(ligne3);
            siticoneGroupBox1.Controls.Add(ligne1);
            siticoneGroupBox1.Controls.Add(ligne2);
            siticoneGroupBox1.CornerRadius = 15;
            siticoneGroupBox1.EnableBlinking = false;
            siticoneGroupBox1.EnableHoverAnimation = true;
            siticoneGroupBox1.Font = new Font("Segoe UI", 10F);
            siticoneGroupBox1.ForeColor = Color.Black;
            siticoneGroupBox1.GradientEndColor = Color.LightGray;
            siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox1.GradientStartColor = Color.White;
            siticoneGroupBox1.GroupTitle = "GroupBox";
            siticoneGroupBox1.HoveredBorderColor = Color.Green;
            siticoneGroupBox1.HoveredTitleColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox1.IsCollapsed = false;
            siticoneGroupBox1.IsCollapsible = false;
            siticoneGroupBox1.Location = new Point(25, 218);
            siticoneGroupBox1.MaxBlinkCount = 3;
            siticoneGroupBox1.Name = "siticoneGroupBox1";
            siticoneGroupBox1.PressedBorderColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox1.ShadowColor = Color.FromArgb(192, 192, 0);
            siticoneGroupBox1.ShadowDepth = 3;
            siticoneGroupBox1.ShowShadow = true;
            siticoneGroupBox1.Size = new Size(757, 207);
            siticoneGroupBox1.SolidFillColor = Color.White;
            siticoneGroupBox1.StatusIcon = null;
            siticoneGroupBox1.StatusText = "";
            siticoneGroupBox1.TabIndex = 28;
            siticoneGroupBox1.TitleBackColor = Color.Transparent;
            siticoneGroupBox1.TitleColor = Color.White;
            siticoneGroupBox1.TitlePadding = new Padding(0, 8, 0, 12);
            siticoneGroupBox1.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox1.UseGradient = false;
            // 
            // ligne4
            // 
            ligne4.AutoSize = true;
            ligne4.Font = new Font("Segoe UI", 9F);
            ligne4.ForeColor = Color.Black;
            ligne4.Location = new Point(28, 158);
            ligne4.Name = "ligne4";
            ligne4.Size = new Size(0, 25);
            ligne4.TabIndex = 3;
            // 
            // ligne3
            // 
            ligne3.AutoSize = true;
            ligne3.Font = new Font("Segoe UI", 9F);
            ligne3.ForeColor = Color.Black;
            ligne3.Location = new Point(28, 125);
            ligne3.Name = "ligne3";
            ligne3.Size = new Size(0, 25);
            ligne3.TabIndex = 2;
            // 
            // ligne1
            // 
            ligne1.AutoSize = true;
            ligne1.Font = new Font("Segoe UI", 9F);
            ligne1.ForeColor = Color.Black;
            ligne1.Location = new Point(28, 61);
            ligne1.Name = "ligne1";
            ligne1.Size = new Size(0, 25);
            ligne1.TabIndex = 0;
            // 
            // ligne2
            // 
            ligne2.AutoSize = true;
            ligne2.Font = new Font("Segoe UI", 9F);
            ligne2.ForeColor = Color.Black;
            ligne2.Location = new Point(28, 93);
            ligne2.Name = "ligne2";
            ligne2.Size = new Size(0, 25);
            ligne2.TabIndex = 1;
            // 
            // infobutton
            // 
            infobutton.BackColor = Color.Transparent;
            infobutton.BackgroundImage = (Image)resources.GetObject("infobutton.BackgroundImage");
            infobutton.BackgroundImageLayout = ImageLayout.Stretch;
            infobutton.BadgeBackColor = Color.White;
            infobutton.BadgeForeColor = Color.White;
            infobutton.BadgeRadius = 10;
            infobutton.BadgeRightMargin = 10;
            infobutton.BadgeValue = 0;
            infobutton.BorderColor = Color.White;
            infobutton.BorderColorEnd = Color.Transparent;
            infobutton.BorderColorStart = Color.White;
            infobutton.BorderRadiusBottomLeft = 25;
            infobutton.BorderRadiusBottomRight = 25;
            infobutton.BorderRadiusTopLeft = 25;
            infobutton.BorderRadiusTopRight = 25;
            infobutton.BorderThickness = 1;
            infobutton.ButtonColorEnd = Color.Transparent;
            infobutton.ButtonColorStart = Color.Transparent;
            infobutton.ButtonImage = null;
            infobutton.CanBeep = false;
            infobutton.CanShake = false;
            infobutton.ClickSoundPath = null;
            infobutton.DisabledOverlayOpacity = 0.5F;
            infobutton.EnableBorderGradient = false;
            infobutton.EnableClickSound = false;
            infobutton.EnableFocusBorder = false;
            infobutton.EnableHoverSound = false;
            infobutton.EnablePressScale = false;
            infobutton.EnableTextShadow = false;
            infobutton.FocusBorderColor = Color.White;
            infobutton.FocusBorderThickness = 2;
            infobutton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infobutton.ForeColor = Color.White;
            infobutton.HoverColor = Color.FromArgb(20, 0, 0, 0);
            infobutton.HoverSoundPath = null;
            infobutton.HoverTransitionSpeed = 1F;
            infobutton.ImageAlign = ContentAlignment.MiddleCenter;
            infobutton.ImageLeftMargin = 5;
            infobutton.ImageRightMargin = 8;
            infobutton.ImageSize = 24;
            infobutton.IsReadOnly = false;
            infobutton.Location = new Point(18, 24);
            infobutton.MakeRadial = false;
            infobutton.Name = "infobutton";
            infobutton.PressAnimationSpeed = 0.5F;
            infobutton.PressDepth = 1;
            infobutton.RippleColor = Color.Transparent;
            infobutton.RippleExpandSpeedFactor = 0.05F;
            infobutton.RippleFadeSpeedFactor = 0.03F;
            infobutton.ShadowBlurFactor = 0.01F;
            infobutton.ShadowColor = Color.Transparent;
            infobutton.ShadowOffsetX = 3;
            infobutton.ShadowOffsetY = 3;
            infobutton.Size = new Size(55, 54);
            infobutton.TabIndex = 29;
            infobutton.TextAlign = ContentAlignment.MiddleCenter;
            infobutton.TextPaddingBottom = 0;
            infobutton.TextPaddingLeft = 0;
            infobutton.TextPaddingRight = 0;
            infobutton.TextPaddingTop = 0;
            infobutton.TextShadowColor = Color.White;
            infobutton.TextShadowOffsetX = 1;
            infobutton.TextShadowOffsetY = 1;
            infobutton.Click += infobutton_Click;
            // 
            // HauteurProduitLabel
            // 
            HauteurProduitLabel.AutoSize = true;
            HauteurProduitLabel.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HauteurProduitLabel.ForeColor = Color.Black;
            HauteurProduitLabel.Location = new Point(28, 433);
            HauteurProduitLabel.Name = "HauteurProduitLabel";
            HauteurProduitLabel.Size = new Size(238, 27);
            HauteurProduitLabel.TabIndex = 0;
            HauteurProduitLabel.Text = "Hauteur produit (mm) : ";
            // 
            // hauteur
            // 
            hauteur.Cursor = Cursors.IBeam;
            hauteur.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hauteur.Location = new Point(32, 469);
            hauteur.Name = "hauteur";
            hauteur.Size = new Size(274, 31);
            hauteur.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 521);
            label1.Name = "label1";
            label1.Size = new Size(325, 27);
            label1.TabIndex = 2;
            label1.Text = "Moyenne des ventes (par mois) : ";
            // 
            // moyenne
            // 
            moyenne.Cursor = Cursors.IBeam;
            moyenne.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moyenne.Location = new Point(32, 561);
            moyenne.Name = "moyenne";
            moyenne.Size = new Size(274, 31);
            moyenne.TabIndex = 4;
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            FreqLabel.ForeColor = Color.Black;
            FreqLabel.Location = new Point(491, 433);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(257, 27);
            FreqLabel.TabIndex = 5;
            FreqLabel.Text = "Fréquence picking (M-1) : ";
            // 
            // frequence
            // 
            frequence.Cursor = Cursors.IBeam;
            frequence.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequence.Location = new Point(495, 469);
            frequence.Name = "frequence";
            frequence.Size = new Size(274, 31);
            frequence.TabIndex = 6;
            // 
            // CodeGeoTxt
            // 
            CodeGeoTxt.Cursor = Cursors.IBeam;
            CodeGeoTxt.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeGeoTxt.Location = new Point(495, 561);
            CodeGeoTxt.Name = "CodeGeoTxt";
            CodeGeoTxt.Size = new Size(274, 31);
            CodeGeoTxt.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(492, 521);
            label2.Name = "label2";
            label2.Size = new Size(119, 27);
            label2.TabIndex = 8;
            label2.Text = "Code Géo : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(25, 111);
            label4.Name = "label4";
            label4.Size = new Size(452, 27);
            label4.TabIndex = 30;
            label4.Text = "Bienvenue sur OMA (Outil Mutation Automate)";
            // 
            // siticoneGroupBox2
            // 
            siticoneGroupBox2.BackColor = Color.Transparent;
            siticoneGroupBox2.BadgeColor = Color.Red;
            siticoneGroupBox2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox2.BadgeLeftPadding = 12;
            siticoneGroupBox2.BadgeValue = 0;
            siticoneGroupBox2.BadgeVisible = false;
            siticoneGroupBox2.BlinkInterval = 500;
            siticoneGroupBox2.BlinkMinOpacity = 0.3F;
            siticoneGroupBox2.BlinkOpacityStep = 0.05F;
            siticoneGroupBox2.BorderColor = Color.LightGray;
            siticoneGroupBox2.BorderWidth = 3F;
            siticoneGroupBox2.CanHover = true;
            siticoneGroupBox2.ChevronColor = Color.Black;
            siticoneGroupBox2.ChevronLeftSpacing = 4F;
            siticoneGroupBox2.ChevronSize = 10F;
            siticoneGroupBox2.ChevronThickness = 2F;
            siticoneGroupBox2.ContentPadding = 5;
            siticoneGroupBox2.Controls.Add(ligne8);
            siticoneGroupBox2.Controls.Add(ligne7);
            siticoneGroupBox2.Controls.Add(label6);
            siticoneGroupBox2.Controls.Add(label7);
            siticoneGroupBox2.Controls.Add(ligne6);
            siticoneGroupBox2.Controls.Add(label8);
            siticoneGroupBox2.Controls.Add(label9);
            siticoneGroupBox2.Controls.Add(ligne5);
            siticoneGroupBox2.CornerRadius = 15;
            siticoneGroupBox2.EnableBlinking = false;
            siticoneGroupBox2.EnableHoverAnimation = true;
            siticoneGroupBox2.Font = new Font("Segoe UI", 10F);
            siticoneGroupBox2.ForeColor = Color.Black;
            siticoneGroupBox2.GradientEndColor = Color.LightGray;
            siticoneGroupBox2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox2.GradientStartColor = Color.White;
            siticoneGroupBox2.GroupTitle = "GroupBox";
            siticoneGroupBox2.HoveredBorderColor = Color.MidnightBlue;
            siticoneGroupBox2.HoveredTitleColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox2.IsCollapsed = false;
            siticoneGroupBox2.IsCollapsible = false;
            siticoneGroupBox2.Location = new Point(25, 648);
            siticoneGroupBox2.MaxBlinkCount = 3;
            siticoneGroupBox2.Name = "siticoneGroupBox2";
            siticoneGroupBox2.PressedBorderColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox2.ShadowColor = Color.FromArgb(192, 192, 0);
            siticoneGroupBox2.ShadowDepth = 3;
            siticoneGroupBox2.ShowShadow = true;
            siticoneGroupBox2.Size = new Size(757, 217);
            siticoneGroupBox2.SolidFillColor = Color.White;
            siticoneGroupBox2.StatusIcon = null;
            siticoneGroupBox2.StatusText = "";
            siticoneGroupBox2.TabIndex = 29;
            siticoneGroupBox2.TitleBackColor = Color.Transparent;
            siticoneGroupBox2.TitleColor = Color.White;
            siticoneGroupBox2.TitlePadding = new Padding(0, 8, 0, 12);
            siticoneGroupBox2.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox2.UseGradient = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 161);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 128);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 64);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 96);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 885);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(infobutton);
            Controls.Add(CodeGeoTxt);
            Controls.Add(SbtnConsultation);
            Controls.Add(frequence);
            Controls.Add(btnFakeAccept);
            Controls.Add(SmoothCircular);
            Controls.Add(FreqLabel);
            Controls.Add(moyenne);
            Controls.Add(ProgressBar);
            Controls.Add(HauteurProduitLabel);
            Controls.Add(SbtnCalculer);
            Controls.Add(label1);
            Controls.Add(SbtnEnregistrer);
            Controls.Add(hauteur);
            Controls.Add(BtnVider);
            Controls.Add(Conclusionlabel);
            Controls.Add(label5);
            Controls.Add(cerp);
            Controls.Add(lbversion);
            Controls.Add(label3);
            Controls.Add(siticoneGroupBox1);
            Controls.Add(siticoneGroupBox2);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Outil Mutation Automate";
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            siticoneGroupBox1.ResumeLayout(false);
            siticoneGroupBox1.PerformLayout();
            siticoneGroupBox2.ResumeLayout(false);
            siticoneGroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion
        private Label label3;
        private Label lbversion;
        private PictureBox cerp;
        private Label label5;
        private Label Conclusionlabel;
        private Label ligne8;
        private Label ligne7;
        private Label ligne6;
        private Label ligne5;
        private System.Diagnostics.Process process1;
        private Button BtnVider;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnEnregistrer;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnCalculer;
        private SiticoneNetCoreUI.SiticoneHProgressBar ProgressBar;
        private SiticoneNetCoreUI.SiticoneSmoothCircularSpinner SmoothCircular;
        private System.Windows.Forms.Timer SmoothTimer;
        private Button btnFakeAccept;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnConsultation;
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox1;
        private Label ligne4;
        private Label ligne3;
        private Label ligne1;
        private Label ligne2;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced infobutton;
        private Label label2;
        private TextBox CodeGeoTxt;
        private TextBox frequence;
        private Label FreqLabel;
        private TextBox moyenne;
        private Label HauteurProduitLabel;
        private Label label1;
        private TextBox hauteur;
        private Label label4;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
