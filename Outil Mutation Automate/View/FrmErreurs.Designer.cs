namespace Outil_Mutation_Automate.View
{
    partial class FrmErreurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErreurs));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label6 = new Label();
            cerp = new PictureBox();
            btnRechercherCodeGeo = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            txtRechercheCanal = new TextBox();
            btnAnnulerFiltre = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SViderBDD = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerManuelle = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerVide = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SBtnImporter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SbtnAnnuler = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            dgvErreurs = new DataGridView();
            Groupbox = new GroupBox();
            btnPrint = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvErreurs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1054, 263);
            label6.Name = "label6";
            label6.Size = new Size(93, 24);
            label6.TabIndex = 50;
            label6.Text = "N° Canal :";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(1035, 38);
            cerp.Name = "cerp";
            cerp.Size = new Size(230, 208);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 40;
            cerp.TabStop = false;
            // 
            // btnRechercherCodeGeo
            // 
            btnRechercherCodeGeo.BackColor = Color.Transparent;
            btnRechercherCodeGeo.BadgeBackColor = Color.Red;
            btnRechercherCodeGeo.BadgeForeColor = Color.White;
            btnRechercherCodeGeo.BadgeRadius = 10;
            btnRechercherCodeGeo.BadgeRightMargin = 10;
            btnRechercherCodeGeo.BadgeValue = 0;
            btnRechercherCodeGeo.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnRechercherCodeGeo.BorderColorEnd = Color.Gray;
            btnRechercherCodeGeo.BorderColorStart = Color.White;
            btnRechercherCodeGeo.BorderRadiusBottomLeft = 25;
            btnRechercherCodeGeo.BorderRadiusBottomRight = 25;
            btnRechercherCodeGeo.BorderRadiusTopLeft = 25;
            btnRechercherCodeGeo.BorderRadiusTopRight = 25;
            btnRechercherCodeGeo.BorderThickness = 1;
            btnRechercherCodeGeo.ButtonColorEnd = Color.Gray;
            btnRechercherCodeGeo.ButtonColorStart = Color.LightGray;
            btnRechercherCodeGeo.ButtonImage = null;
            btnRechercherCodeGeo.CanBeep = false;
            btnRechercherCodeGeo.CanShake = false;
            btnRechercherCodeGeo.ClickSoundPath = null;
            btnRechercherCodeGeo.DisabledOverlayOpacity = 0.5F;
            btnRechercherCodeGeo.EnableBorderGradient = false;
            btnRechercherCodeGeo.EnableClickSound = false;
            btnRechercherCodeGeo.EnableFocusBorder = false;
            btnRechercherCodeGeo.EnableHoverSound = false;
            btnRechercherCodeGeo.EnablePressScale = false;
            btnRechercherCodeGeo.EnableTextShadow = false;
            btnRechercherCodeGeo.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnRechercherCodeGeo.FocusBorderThickness = 2;
            btnRechercherCodeGeo.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRechercherCodeGeo.ForeColor = Color.White;
            btnRechercherCodeGeo.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btnRechercherCodeGeo.HoverSoundPath = null;
            btnRechercherCodeGeo.HoverTransitionSpeed = 1F;
            btnRechercherCodeGeo.ImageAlign = ContentAlignment.MiddleCenter;
            btnRechercherCodeGeo.ImageLeftMargin = 5;
            btnRechercherCodeGeo.ImageRightMargin = 8;
            btnRechercherCodeGeo.ImageSize = 24;
            btnRechercherCodeGeo.IsReadOnly = false;
            btnRechercherCodeGeo.Location = new Point(1181, 277);
            btnRechercherCodeGeo.MakeRadial = false;
            btnRechercherCodeGeo.Name = "btnRechercherCodeGeo";
            btnRechercherCodeGeo.PressAnimationSpeed = 0.5F;
            btnRechercherCodeGeo.PressDepth = 1;
            btnRechercherCodeGeo.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btnRechercherCodeGeo.RippleExpandSpeedFactor = 0.05F;
            btnRechercherCodeGeo.RippleFadeSpeedFactor = 0.03F;
            btnRechercherCodeGeo.ShadowBlurFactor = 0.85F;
            btnRechercherCodeGeo.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnRechercherCodeGeo.ShadowOffsetX = 3;
            btnRechercherCodeGeo.ShadowOffsetY = 3;
            btnRechercherCodeGeo.Size = new Size(100, 50);
            btnRechercherCodeGeo.TabIndex = 49;
            btnRechercherCodeGeo.Text = "Chercher";
            btnRechercherCodeGeo.TextAlign = ContentAlignment.MiddleCenter;
            btnRechercherCodeGeo.TextPaddingBottom = 0;
            btnRechercherCodeGeo.TextPaddingLeft = 0;
            btnRechercherCodeGeo.TextPaddingRight = 0;
            btnRechercherCodeGeo.TextPaddingTop = 0;
            btnRechercherCodeGeo.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnRechercherCodeGeo.TextShadowOffsetX = 1;
            btnRechercherCodeGeo.TextShadowOffsetY = 1;
            btnRechercherCodeGeo.Click += btnRechercherCodeGeo_Click;
            // 
            // txtRechercheCanal
            // 
            txtRechercheCanal.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRechercheCanal.Location = new Point(1058, 290);
            txtRechercheCanal.Name = "txtRechercheCanal";
            txtRechercheCanal.Size = new Size(114, 31);
            txtRechercheCanal.TabIndex = 43;
            // 
            // btnAnnulerFiltre
            // 
            btnAnnulerFiltre.BackColor = Color.Transparent;
            btnAnnulerFiltre.BadgeBackColor = Color.Red;
            btnAnnulerFiltre.BadgeForeColor = Color.White;
            btnAnnulerFiltre.BadgeRadius = 10;
            btnAnnulerFiltre.BadgeRightMargin = 10;
            btnAnnulerFiltre.BadgeValue = 0;
            btnAnnulerFiltre.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnAnnulerFiltre.BorderColorEnd = Color.Gray;
            btnAnnulerFiltre.BorderColorStart = Color.White;
            btnAnnulerFiltre.BorderRadiusBottomLeft = 25;
            btnAnnulerFiltre.BorderRadiusBottomRight = 25;
            btnAnnulerFiltre.BorderRadiusTopLeft = 25;
            btnAnnulerFiltre.BorderRadiusTopRight = 25;
            btnAnnulerFiltre.BorderThickness = 1;
            btnAnnulerFiltre.ButtonColorEnd = Color.DarkGreen;
            btnAnnulerFiltre.ButtonColorStart = Color.LimeGreen;
            btnAnnulerFiltre.ButtonImage = null;
            btnAnnulerFiltre.CanBeep = false;
            btnAnnulerFiltre.CanShake = false;
            btnAnnulerFiltre.ClickSoundPath = null;
            btnAnnulerFiltre.DisabledOverlayOpacity = 0.5F;
            btnAnnulerFiltre.EnableBorderGradient = false;
            btnAnnulerFiltre.EnableClickSound = false;
            btnAnnulerFiltre.EnableFocusBorder = false;
            btnAnnulerFiltre.EnableHoverSound = false;
            btnAnnulerFiltre.EnablePressScale = false;
            btnAnnulerFiltre.EnableTextShadow = false;
            btnAnnulerFiltre.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnAnnulerFiltre.FocusBorderThickness = 2;
            btnAnnulerFiltre.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnnulerFiltre.ForeColor = Color.White;
            btnAnnulerFiltre.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btnAnnulerFiltre.HoverSoundPath = null;
            btnAnnulerFiltre.HoverTransitionSpeed = 1F;
            btnAnnulerFiltre.ImageAlign = ContentAlignment.MiddleCenter;
            btnAnnulerFiltre.ImageLeftMargin = 5;
            btnAnnulerFiltre.ImageRightMargin = 8;
            btnAnnulerFiltre.ImageSize = 24;
            btnAnnulerFiltre.IsReadOnly = false;
            btnAnnulerFiltre.Location = new Point(545, 34);
            btnAnnulerFiltre.MakeRadial = false;
            btnAnnulerFiltre.Name = "btnAnnulerFiltre";
            btnAnnulerFiltre.PressAnimationSpeed = 0.5F;
            btnAnnulerFiltre.PressDepth = 1;
            btnAnnulerFiltre.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btnAnnulerFiltre.RippleExpandSpeedFactor = 0.05F;
            btnAnnulerFiltre.RippleFadeSpeedFactor = 0.03F;
            btnAnnulerFiltre.ShadowBlurFactor = 0.85F;
            btnAnnulerFiltre.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnAnnulerFiltre.ShadowOffsetX = 3;
            btnAnnulerFiltre.ShadowOffsetY = 3;
            btnAnnulerFiltre.Size = new Size(193, 50);
            btnAnnulerFiltre.TabIndex = 48;
            btnAnnulerFiltre.Text = "Annuler filtre";
            btnAnnulerFiltre.TextAlign = ContentAlignment.MiddleCenter;
            btnAnnulerFiltre.TextPaddingBottom = 0;
            btnAnnulerFiltre.TextPaddingLeft = 0;
            btnAnnulerFiltre.TextPaddingRight = 0;
            btnAnnulerFiltre.TextPaddingTop = 0;
            btnAnnulerFiltre.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnAnnulerFiltre.TextShadowOffsetX = 1;
            btnAnnulerFiltre.TextShadowOffsetY = 1;
            btnAnnulerFiltre.Click += btnAnnulerFiltre_Click_1;
            // 
            // SViderBDD
            // 
            SViderBDD.BackColor = Color.Transparent;
            SViderBDD.BadgeBackColor = Color.Red;
            SViderBDD.BadgeForeColor = Color.White;
            SViderBDD.BadgeRadius = 10;
            SViderBDD.BadgeRightMargin = 10;
            SViderBDD.BadgeValue = 0;
            SViderBDD.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SViderBDD.BorderColorEnd = Color.Gray;
            SViderBDD.BorderColorStart = Color.White;
            SViderBDD.BorderRadiusBottomLeft = 25;
            SViderBDD.BorderRadiusBottomRight = 25;
            SViderBDD.BorderRadiusTopLeft = 25;
            SViderBDD.BorderRadiusTopRight = 25;
            SViderBDD.BorderThickness = 1;
            SViderBDD.ButtonColorEnd = Color.DarkRed;
            SViderBDD.ButtonColorStart = Color.Red;
            SViderBDD.ButtonImage = null;
            SViderBDD.CanBeep = false;
            SViderBDD.CanShake = false;
            SViderBDD.ClickSoundPath = null;
            SViderBDD.DisabledOverlayOpacity = 0.5F;
            SViderBDD.EnableBorderGradient = false;
            SViderBDD.EnableClickSound = false;
            SViderBDD.EnableFocusBorder = false;
            SViderBDD.EnableHoverSound = false;
            SViderBDD.EnablePressScale = false;
            SViderBDD.EnableTextShadow = false;
            SViderBDD.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SViderBDD.FocusBorderThickness = 2;
            SViderBDD.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SViderBDD.ForeColor = Color.White;
            SViderBDD.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SViderBDD.HoverSoundPath = null;
            SViderBDD.HoverTransitionSpeed = 1F;
            SViderBDD.ImageAlign = ContentAlignment.MiddleCenter;
            SViderBDD.ImageLeftMargin = 5;
            SViderBDD.ImageRightMargin = 8;
            SViderBDD.ImageSize = 24;
            SViderBDD.IsReadOnly = false;
            SViderBDD.Location = new Point(1048, 333);
            SViderBDD.MakeRadial = false;
            SViderBDD.Name = "SViderBDD";
            SViderBDD.PressAnimationSpeed = 0.5F;
            SViderBDD.PressDepth = 1;
            SViderBDD.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SViderBDD.RippleExpandSpeedFactor = 0.05F;
            SViderBDD.RippleFadeSpeedFactor = 0.03F;
            SViderBDD.ShadowBlurFactor = 0.85F;
            SViderBDD.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SViderBDD.ShadowOffsetX = 3;
            SViderBDD.ShadowOffsetY = 3;
            SViderBDD.Size = new Size(233, 50);
            SViderBDD.TabIndex = 47;
            SViderBDD.Text = "Vider la base de données";
            SViderBDD.TextAlign = ContentAlignment.MiddleCenter;
            SViderBDD.TextPaddingBottom = 0;
            SViderBDD.TextPaddingLeft = 0;
            SViderBDD.TextPaddingRight = 0;
            SViderBDD.TextPaddingTop = 0;
            SViderBDD.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SViderBDD.TextShadowOffsetX = 1;
            SViderBDD.TextShadowOffsetY = 1;
            SViderBDD.Click += SViderBDD_Click;
            // 
            // FiltrerManuelle
            // 
            FiltrerManuelle.BackColor = Color.Transparent;
            FiltrerManuelle.BadgeBackColor = Color.Red;
            FiltrerManuelle.BadgeForeColor = Color.White;
            FiltrerManuelle.BadgeRadius = 10;
            FiltrerManuelle.BadgeRightMargin = 10;
            FiltrerManuelle.BadgeValue = 0;
            FiltrerManuelle.BorderColor = Color.FromArgb(150, 255, 255, 255);
            FiltrerManuelle.BorderColorEnd = Color.Gray;
            FiltrerManuelle.BorderColorStart = Color.White;
            FiltrerManuelle.BorderRadiusBottomLeft = 25;
            FiltrerManuelle.BorderRadiusBottomRight = 25;
            FiltrerManuelle.BorderRadiusTopLeft = 25;
            FiltrerManuelle.BorderRadiusTopRight = 25;
            FiltrerManuelle.BorderThickness = 1;
            FiltrerManuelle.ButtonColorEnd = Color.DarkCyan;
            FiltrerManuelle.ButtonColorStart = Color.MediumTurquoise;
            FiltrerManuelle.ButtonImage = null;
            FiltrerManuelle.CanBeep = false;
            FiltrerManuelle.CanShake = false;
            FiltrerManuelle.ClickSoundPath = null;
            FiltrerManuelle.DisabledOverlayOpacity = 0.5F;
            FiltrerManuelle.EnableBorderGradient = false;
            FiltrerManuelle.EnableClickSound = false;
            FiltrerManuelle.EnableFocusBorder = false;
            FiltrerManuelle.EnableHoverSound = false;
            FiltrerManuelle.EnablePressScale = false;
            FiltrerManuelle.EnableTextShadow = false;
            FiltrerManuelle.FocusBorderColor = Color.FromArgb(100, 150, 255);
            FiltrerManuelle.FocusBorderThickness = 2;
            FiltrerManuelle.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltrerManuelle.ForeColor = Color.White;
            FiltrerManuelle.HoverColor = Color.FromArgb(20, 0, 0, 0);
            FiltrerManuelle.HoverSoundPath = null;
            FiltrerManuelle.HoverTransitionSpeed = 1F;
            FiltrerManuelle.ImageAlign = ContentAlignment.MiddleCenter;
            FiltrerManuelle.ImageLeftMargin = 5;
            FiltrerManuelle.ImageRightMargin = 8;
            FiltrerManuelle.ImageSize = 24;
            FiltrerManuelle.IsReadOnly = false;
            FiltrerManuelle.Location = new Point(273, 34);
            FiltrerManuelle.MakeRadial = false;
            FiltrerManuelle.Name = "FiltrerManuelle";
            FiltrerManuelle.PressAnimationSpeed = 0.5F;
            FiltrerManuelle.PressDepth = 1;
            FiltrerManuelle.RippleColor = Color.FromArgb(60, 255, 255, 255);
            FiltrerManuelle.RippleExpandSpeedFactor = 0.05F;
            FiltrerManuelle.RippleFadeSpeedFactor = 0.03F;
            FiltrerManuelle.ShadowBlurFactor = 0.85F;
            FiltrerManuelle.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            FiltrerManuelle.ShadowOffsetX = 3;
            FiltrerManuelle.ShadowOffsetY = 3;
            FiltrerManuelle.Size = new Size(234, 50);
            FiltrerManuelle.TabIndex = 46;
            FiltrerManuelle.Text = "Filtrer (Sortie manuelle)";
            FiltrerManuelle.TextAlign = ContentAlignment.MiddleCenter;
            FiltrerManuelle.TextPaddingBottom = 0;
            FiltrerManuelle.TextPaddingLeft = 0;
            FiltrerManuelle.TextPaddingRight = 0;
            FiltrerManuelle.TextPaddingTop = 0;
            FiltrerManuelle.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            FiltrerManuelle.TextShadowOffsetX = 1;
            FiltrerManuelle.TextShadowOffsetY = 1;
            FiltrerManuelle.Click += FiltrerManuelle_Click;
            // 
            // FiltrerVide
            // 
            FiltrerVide.BackColor = Color.Transparent;
            FiltrerVide.BadgeBackColor = Color.Red;
            FiltrerVide.BadgeForeColor = Color.White;
            FiltrerVide.BadgeRadius = 10;
            FiltrerVide.BadgeRightMargin = 10;
            FiltrerVide.BadgeValue = 0;
            FiltrerVide.BorderColor = Color.FromArgb(150, 255, 255, 255);
            FiltrerVide.BorderColorEnd = Color.Gray;
            FiltrerVide.BorderColorStart = Color.White;
            FiltrerVide.BorderRadiusBottomLeft = 25;
            FiltrerVide.BorderRadiusBottomRight = 25;
            FiltrerVide.BorderRadiusTopLeft = 25;
            FiltrerVide.BorderRadiusTopRight = 25;
            FiltrerVide.BorderThickness = 1;
            FiltrerVide.ButtonColorEnd = Color.Red;
            FiltrerVide.ButtonColorStart = Color.Orange;
            FiltrerVide.ButtonImage = null;
            FiltrerVide.CanBeep = false;
            FiltrerVide.CanShake = false;
            FiltrerVide.ClickSoundPath = null;
            FiltrerVide.DisabledOverlayOpacity = 0.5F;
            FiltrerVide.EnableBorderGradient = false;
            FiltrerVide.EnableClickSound = false;
            FiltrerVide.EnableFocusBorder = false;
            FiltrerVide.EnableHoverSound = false;
            FiltrerVide.EnablePressScale = false;
            FiltrerVide.EnableTextShadow = false;
            FiltrerVide.FocusBorderColor = Color.FromArgb(100, 150, 255);
            FiltrerVide.FocusBorderThickness = 2;
            FiltrerVide.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltrerVide.ForeColor = Color.White;
            FiltrerVide.HoverColor = Color.FromArgb(20, 0, 0, 0);
            FiltrerVide.HoverSoundPath = null;
            FiltrerVide.HoverTransitionSpeed = 1F;
            FiltrerVide.ImageAlign = ContentAlignment.MiddleCenter;
            FiltrerVide.ImageLeftMargin = 5;
            FiltrerVide.ImageRightMargin = 8;
            FiltrerVide.ImageSize = 24;
            FiltrerVide.IsReadOnly = false;
            FiltrerVide.Location = new Point(40, 34);
            FiltrerVide.MakeRadial = false;
            FiltrerVide.Name = "FiltrerVide";
            FiltrerVide.PressAnimationSpeed = 0.5F;
            FiltrerVide.PressDepth = 1;
            FiltrerVide.RippleColor = Color.FromArgb(60, 255, 255, 255);
            FiltrerVide.RippleExpandSpeedFactor = 0.05F;
            FiltrerVide.RippleFadeSpeedFactor = 0.03F;
            FiltrerVide.ShadowBlurFactor = 0.85F;
            FiltrerVide.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            FiltrerVide.ShadowOffsetX = 3;
            FiltrerVide.ShadowOffsetY = 3;
            FiltrerVide.Size = new Size(193, 50);
            FiltrerVide.TabIndex = 45;
            FiltrerVide.Text = "Filtrer (Vide)";
            FiltrerVide.TextAlign = ContentAlignment.MiddleCenter;
            FiltrerVide.TextPaddingBottom = 0;
            FiltrerVide.TextPaddingLeft = 0;
            FiltrerVide.TextPaddingRight = 0;
            FiltrerVide.TextPaddingTop = 0;
            FiltrerVide.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            FiltrerVide.TextShadowOffsetX = 1;
            FiltrerVide.TextShadowOffsetY = 1;
            FiltrerVide.Click += FiltrerVide_Click;
            // 
            // SBtnImporter
            // 
            SBtnImporter.BackColor = Color.Transparent;
            SBtnImporter.BadgeBackColor = Color.Red;
            SBtnImporter.BadgeForeColor = Color.White;
            SBtnImporter.BadgeRadius = 10;
            SBtnImporter.BadgeRightMargin = 10;
            SBtnImporter.BadgeValue = 0;
            SBtnImporter.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SBtnImporter.BorderColorEnd = Color.Gray;
            SBtnImporter.BorderColorStart = Color.White;
            SBtnImporter.BorderRadiusBottomLeft = 25;
            SBtnImporter.BorderRadiusBottomRight = 25;
            SBtnImporter.BorderRadiusTopLeft = 25;
            SBtnImporter.BorderRadiusTopRight = 25;
            SBtnImporter.BorderThickness = 1;
            SBtnImporter.ButtonColorEnd = Color.DarkViolet;
            SBtnImporter.ButtonColorStart = Color.Magenta;
            SBtnImporter.ButtonImage = null;
            SBtnImporter.CanBeep = false;
            SBtnImporter.CanShake = false;
            SBtnImporter.ClickSoundPath = null;
            SBtnImporter.DisabledOverlayOpacity = 0.5F;
            SBtnImporter.EnableBorderGradient = false;
            SBtnImporter.EnableClickSound = false;
            SBtnImporter.EnableFocusBorder = false;
            SBtnImporter.EnableHoverSound = false;
            SBtnImporter.EnablePressScale = false;
            SBtnImporter.EnableTextShadow = false;
            SBtnImporter.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SBtnImporter.FocusBorderThickness = 2;
            SBtnImporter.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SBtnImporter.ForeColor = Color.White;
            SBtnImporter.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SBtnImporter.HoverSoundPath = null;
            SBtnImporter.HoverTransitionSpeed = 1F;
            SBtnImporter.ImageAlign = ContentAlignment.MiddleCenter;
            SBtnImporter.ImageLeftMargin = 5;
            SBtnImporter.ImageRightMargin = 8;
            SBtnImporter.ImageSize = 24;
            SBtnImporter.IsReadOnly = false;
            SBtnImporter.Location = new Point(993, 418);
            SBtnImporter.MakeRadial = false;
            SBtnImporter.Name = "SBtnImporter";
            SBtnImporter.PressAnimationSpeed = 0.5F;
            SBtnImporter.PressDepth = 1;
            SBtnImporter.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SBtnImporter.RippleExpandSpeedFactor = 0.05F;
            SBtnImporter.RippleFadeSpeedFactor = 0.03F;
            SBtnImporter.ShadowBlurFactor = 0.85F;
            SBtnImporter.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SBtnImporter.ShadowOffsetX = 3;
            SBtnImporter.ShadowOffsetY = 3;
            SBtnImporter.Size = new Size(116, 50);
            SBtnImporter.TabIndex = 44;
            SBtnImporter.Text = "Importer";
            SBtnImporter.TextAlign = ContentAlignment.MiddleCenter;
            SBtnImporter.TextPaddingBottom = 0;
            SBtnImporter.TextPaddingLeft = 0;
            SBtnImporter.TextPaddingRight = 0;
            SBtnImporter.TextPaddingTop = 0;
            SBtnImporter.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SBtnImporter.TextShadowOffsetX = 1;
            SBtnImporter.TextShadowOffsetY = 1;
            SBtnImporter.Click += SBtnImporter_Click;
            // 
            // SbtnAnnuler
            // 
            SbtnAnnuler.BackColor = Color.Transparent;
            SbtnAnnuler.BadgeBackColor = Color.Red;
            SbtnAnnuler.BadgeForeColor = Color.White;
            SbtnAnnuler.BadgeRadius = 10;
            SbtnAnnuler.BadgeRightMargin = 10;
            SbtnAnnuler.BadgeValue = 0;
            SbtnAnnuler.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnAnnuler.BorderColorEnd = Color.Gray;
            SbtnAnnuler.BorderColorStart = Color.White;
            SbtnAnnuler.BorderRadiusBottomLeft = 25;
            SbtnAnnuler.BorderRadiusBottomRight = 25;
            SbtnAnnuler.BorderRadiusTopLeft = 25;
            SbtnAnnuler.BorderRadiusTopRight = 25;
            SbtnAnnuler.BorderThickness = 1;
            SbtnAnnuler.ButtonColorEnd = Color.MidnightBlue;
            SbtnAnnuler.ButtonColorStart = Color.CornflowerBlue;
            SbtnAnnuler.ButtonImage = null;
            SbtnAnnuler.CanBeep = false;
            SbtnAnnuler.CanShake = true;
            SbtnAnnuler.ClickSoundPath = null;
            SbtnAnnuler.DisabledOverlayOpacity = 0.5F;
            SbtnAnnuler.EnableBorderGradient = false;
            SbtnAnnuler.EnableClickSound = false;
            SbtnAnnuler.EnableFocusBorder = false;
            SbtnAnnuler.EnableHoverSound = false;
            SbtnAnnuler.EnablePressScale = false;
            SbtnAnnuler.EnableTextShadow = false;
            SbtnAnnuler.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnAnnuler.FocusBorderThickness = 2;
            SbtnAnnuler.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnAnnuler.ForeColor = Color.White;
            SbtnAnnuler.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnAnnuler.HoverSoundPath = null;
            SbtnAnnuler.HoverTransitionSpeed = 1F;
            SbtnAnnuler.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnAnnuler.ImageLeftMargin = 5;
            SbtnAnnuler.ImageRightMargin = 8;
            SbtnAnnuler.ImageSize = 24;
            SbtnAnnuler.IsReadOnly = false;
            SbtnAnnuler.Location = new Point(1115, 418);
            SbtnAnnuler.MakeRadial = false;
            SbtnAnnuler.Name = "SbtnAnnuler";
            SbtnAnnuler.PressAnimationSpeed = 0.5F;
            SbtnAnnuler.PressDepth = 1;
            SbtnAnnuler.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnAnnuler.RippleExpandSpeedFactor = 0.05F;
            SbtnAnnuler.RippleFadeSpeedFactor = 0.03F;
            SbtnAnnuler.ShadowBlurFactor = 0.85F;
            SbtnAnnuler.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnAnnuler.ShadowOffsetX = 3;
            SbtnAnnuler.ShadowOffsetY = 3;
            SbtnAnnuler.Size = new Size(166, 50);
            SbtnAnnuler.TabIndex = 42;
            SbtnAnnuler.Text = "Retour";
            SbtnAnnuler.TextAlign = ContentAlignment.MiddleCenter;
            SbtnAnnuler.TextPaddingBottom = 0;
            SbtnAnnuler.TextPaddingLeft = 0;
            SbtnAnnuler.TextPaddingRight = 0;
            SbtnAnnuler.TextPaddingTop = 0;
            SbtnAnnuler.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnAnnuler.TextShadowOffsetX = 1;
            SbtnAnnuler.TextShadowOffsetY = 1;
            SbtnAnnuler.Click += SbtnAnnuler_Click;
            // 
            // dgvErreurs
            // 
            dgvErreurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvErreurs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvErreurs.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvErreurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvErreurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvErreurs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvErreurs.EnableHeadersVisualStyles = false;
            dgvErreurs.Location = new Point(45, 54);
            dgvErreurs.MultiSelect = false;
            dgvErreurs.Name = "dgvErreurs";
            dgvErreurs.ReadOnly = true;
            dgvErreurs.RowHeadersVisible = false;
            dgvErreurs.RowHeadersWidth = 62;
            dgvErreurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvErreurs.Size = new Size(921, 324);
            dgvErreurs.TabIndex = 37;
            // 
            // Groupbox
            // 
            Groupbox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Groupbox.ForeColor = Color.Black;
            Groupbox.Location = new Point(39, 25);
            Groupbox.Name = "Groupbox";
            Groupbox.Size = new Size(936, 359);
            Groupbox.TabIndex = 38;
            Groupbox.TabStop = false;
            Groupbox.Text = "Erreurs Automates - Enregistrées";
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.Location = new Point(802, 27);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(63, 61);
            btnPrint.TabIndex = 24;
            btnPrint.Tag = "";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAnnulerFiltre);
            groupBox1.Controls.Add(btnPrint);
            groupBox1.Controls.Add(FiltrerVide);
            groupBox1.Controls.Add(FiltrerManuelle);
            groupBox1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 112);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fonctions de filtrage";
            // 
            // FrmErreurs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 526);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(cerp);
            Controls.Add(btnRechercherCodeGeo);
            Controls.Add(txtRechercheCanal);
            Controls.Add(SViderBDD);
            Controls.Add(SBtnImporter);
            Controls.Add(SbtnAnnuler);
            Controls.Add(dgvErreurs);
            Controls.Add(Groupbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmErreurs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Erreurs Automate";
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvErreurs).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private PictureBox cerp;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnRechercherCodeGeo;
        private TextBox txtRechercheCanal;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnAnnulerFiltre;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SViderBDD;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerManuelle;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerVide;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SBtnImporter;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnAnnuler;
        private DataGridView dgvErreurs;
        private GroupBox Groupbox;
        private Button btnPrint;
        private GroupBox groupBox1;
    }
}