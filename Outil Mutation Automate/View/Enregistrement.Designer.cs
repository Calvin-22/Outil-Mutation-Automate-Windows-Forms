namespace Outil_Mutation_Automate.View
{
    partial class Enregistrement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enregistrement));
            dgvMutation = new DataGridView();
            Groupbox = new GroupBox();
            txtRechercheCodeGeo = new TextBox();
            SBtnErreursAutomate = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnPrint = new Button();
            SbtnAjouter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            txtDesignation = new TextBox();
            txtCIP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SbtnAnnuler = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SbtnSupprimer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SBtnImporter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerAutomate = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerMagasin = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SViderBDD = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnAnnulerFiltre = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnRechercherCodeGeo = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label6 = new Label();
            filtrebutton = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneGroupBox1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            ligne4 = new Label();
            ligne3 = new Label();
            ligne1 = new Label();
            ligne2 = new Label();
            siticoneGroupBox2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label12 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            siticoneGroupBox3 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label13 = new Label();
            cerp = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMutation).BeginInit();
            siticoneGroupBox1.SuspendLayout();
            siticoneGroupBox2.SuspendLayout();
            siticoneGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            SuspendLayout();
            // 
            // dgvMutation
            // 
            dgvMutation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMutation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMutation.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMutation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMutation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMutation.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMutation.EnableHeadersVisualStyles = false;
            dgvMutation.Location = new Point(39, 55);
            dgvMutation.MultiSelect = false;
            dgvMutation.Name = "dgvMutation";
            dgvMutation.ReadOnly = true;
            dgvMutation.RowHeadersVisible = false;
            dgvMutation.RowHeadersWidth = 62;
            dgvMutation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMutation.Size = new Size(1823, 625);
            dgvMutation.TabIndex = 0;
            // 
            // Groupbox
            // 
            Groupbox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Groupbox.ForeColor = Color.Black;
            Groupbox.Location = new Point(33, 26);
            Groupbox.Name = "Groupbox";
            Groupbox.Size = new Size(1835, 660);
            Groupbox.TabIndex = 3;
            Groupbox.TabStop = false;
            Groupbox.Text = "Lignes Enregistrées";
            Groupbox.Enter += Groupbox_Enter;
            // 
            // txtRechercheCodeGeo
            // 
            txtRechercheCodeGeo.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRechercheCodeGeo.Location = new Point(160, 99);
            txtRechercheCodeGeo.Name = "txtRechercheCodeGeo";
            txtRechercheCodeGeo.Size = new Size(126, 31);
            txtRechercheCodeGeo.TabIndex = 25;
            // 
            // SBtnErreursAutomate
            // 
            SBtnErreursAutomate.BackColor = Color.Transparent;
            SBtnErreursAutomate.BadgeBackColor = Color.Red;
            SBtnErreursAutomate.BadgeForeColor = Color.White;
            SBtnErreursAutomate.BadgeRadius = 10;
            SBtnErreursAutomate.BadgeRightMargin = 10;
            SBtnErreursAutomate.BadgeValue = 0;
            SBtnErreursAutomate.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SBtnErreursAutomate.BorderColorEnd = Color.Gray;
            SBtnErreursAutomate.BorderColorStart = Color.White;
            SBtnErreursAutomate.BorderRadiusBottomLeft = 25;
            SBtnErreursAutomate.BorderRadiusBottomRight = 25;
            SBtnErreursAutomate.BorderRadiusTopLeft = 25;
            SBtnErreursAutomate.BorderRadiusTopRight = 25;
            SBtnErreursAutomate.BorderThickness = 1;
            SBtnErreursAutomate.ButtonColorEnd = Color.DarkGoldenrod;
            SBtnErreursAutomate.ButtonColorStart = Color.Gold;
            SBtnErreursAutomate.ButtonImage = null;
            SBtnErreursAutomate.CanBeep = false;
            SBtnErreursAutomate.CanShake = false;
            SBtnErreursAutomate.ClickSoundPath = null;
            SBtnErreursAutomate.DisabledOverlayOpacity = 0.5F;
            SBtnErreursAutomate.EnableBorderGradient = false;
            SBtnErreursAutomate.EnableClickSound = false;
            SBtnErreursAutomate.EnableFocusBorder = false;
            SBtnErreursAutomate.EnableHoverSound = false;
            SBtnErreursAutomate.EnablePressScale = false;
            SBtnErreursAutomate.EnableTextShadow = false;
            SBtnErreursAutomate.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SBtnErreursAutomate.FocusBorderThickness = 2;
            SBtnErreursAutomate.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SBtnErreursAutomate.ForeColor = Color.White;
            SBtnErreursAutomate.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SBtnErreursAutomate.HoverSoundPath = null;
            SBtnErreursAutomate.HoverTransitionSpeed = 1F;
            SBtnErreursAutomate.ImageAlign = ContentAlignment.MiddleCenter;
            SBtnErreursAutomate.ImageLeftMargin = 5;
            SBtnErreursAutomate.ImageRightMargin = 8;
            SBtnErreursAutomate.ImageSize = 24;
            SBtnErreursAutomate.IsReadOnly = false;
            SBtnErreursAutomate.Location = new Point(311, 199);
            SBtnErreursAutomate.MakeRadial = false;
            SBtnErreursAutomate.Name = "SBtnErreursAutomate";
            SBtnErreursAutomate.PressAnimationSpeed = 0.5F;
            SBtnErreursAutomate.PressDepth = 1;
            SBtnErreursAutomate.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SBtnErreursAutomate.RippleExpandSpeedFactor = 0.05F;
            SBtnErreursAutomate.RippleFadeSpeedFactor = 0.03F;
            SBtnErreursAutomate.ShadowBlurFactor = 0.85F;
            SBtnErreursAutomate.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SBtnErreursAutomate.ShadowOffsetX = 3;
            SBtnErreursAutomate.ShadowOffsetY = 3;
            SBtnErreursAutomate.Size = new Size(183, 50);
            SBtnErreursAutomate.TabIndex = 37;
            SBtnErreursAutomate.Text = "Erreurs Automate";
            SBtnErreursAutomate.TextAlign = ContentAlignment.MiddleCenter;
            SBtnErreursAutomate.TextPaddingBottom = 0;
            SBtnErreursAutomate.TextPaddingLeft = 0;
            SBtnErreursAutomate.TextPaddingRight = 0;
            SBtnErreursAutomate.TextPaddingTop = 0;
            SBtnErreursAutomate.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SBtnErreursAutomate.TextShadowOffsetX = 1;
            SBtnErreursAutomate.TextShadowOffsetY = 1;
            SBtnErreursAutomate.Click += SBtnErreursAutomate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.Location = new Point(592, 66);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(63, 61);
            btnPrint.TabIndex = 24;
            btnPrint.Tag = "";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // SbtnAjouter
            // 
            SbtnAjouter.BackColor = Color.Transparent;
            SbtnAjouter.BadgeBackColor = Color.Red;
            SbtnAjouter.BadgeForeColor = Color.White;
            SbtnAjouter.BadgeRadius = 10;
            SbtnAjouter.BadgeRightMargin = 10;
            SbtnAjouter.BadgeValue = 0;
            SbtnAjouter.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnAjouter.BorderColorEnd = Color.Gray;
            SbtnAjouter.BorderColorStart = Color.White;
            SbtnAjouter.BorderRadiusBottomLeft = 25;
            SbtnAjouter.BorderRadiusBottomRight = 25;
            SbtnAjouter.BorderRadiusTopLeft = 25;
            SbtnAjouter.BorderRadiusTopRight = 25;
            SbtnAjouter.BorderThickness = 1;
            SbtnAjouter.ButtonColorEnd = Color.Green;
            SbtnAjouter.ButtonColorStart = Color.LimeGreen;
            SbtnAjouter.ButtonImage = null;
            SbtnAjouter.CanBeep = false;
            SbtnAjouter.CanShake = false;
            SbtnAjouter.ClickSoundPath = null;
            SbtnAjouter.DisabledOverlayOpacity = 0.5F;
            SbtnAjouter.EnableBorderGradient = false;
            SbtnAjouter.EnableClickSound = false;
            SbtnAjouter.EnableFocusBorder = false;
            SbtnAjouter.EnableHoverSound = false;
            SbtnAjouter.EnablePressScale = false;
            SbtnAjouter.EnableTextShadow = false;
            SbtnAjouter.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnAjouter.FocusBorderThickness = 2;
            SbtnAjouter.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnAjouter.ForeColor = Color.White;
            SbtnAjouter.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnAjouter.HoverSoundPath = null;
            SbtnAjouter.HoverTransitionSpeed = 1F;
            SbtnAjouter.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnAjouter.ImageLeftMargin = 5;
            SbtnAjouter.ImageRightMargin = 8;
            SbtnAjouter.ImageSize = 24;
            SbtnAjouter.IsReadOnly = false;
            SbtnAjouter.Location = new Point(252, 199);
            SbtnAjouter.MakeRadial = false;
            SbtnAjouter.Name = "SbtnAjouter";
            SbtnAjouter.PressAnimationSpeed = 0.5F;
            SbtnAjouter.PressDepth = 1;
            SbtnAjouter.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnAjouter.RippleExpandSpeedFactor = 0.05F;
            SbtnAjouter.RippleFadeSpeedFactor = 0.03F;
            SbtnAjouter.ShadowBlurFactor = 0.85F;
            SbtnAjouter.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnAjouter.ShadowOffsetX = 3;
            SbtnAjouter.ShadowOffsetY = 3;
            SbtnAjouter.Size = new Size(123, 50);
            SbtnAjouter.TabIndex = 22;
            SbtnAjouter.Text = "Ajouter";
            SbtnAjouter.TextAlign = ContentAlignment.MiddleCenter;
            SbtnAjouter.TextPaddingBottom = 0;
            SbtnAjouter.TextPaddingLeft = 0;
            SbtnAjouter.TextPaddingRight = 0;
            SbtnAjouter.TextPaddingTop = 0;
            SbtnAjouter.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnAjouter.TextShadowOffsetX = 1;
            SbtnAjouter.TextShadowOffsetY = 1;
            SbtnAjouter.Click += SbtnAjouter_Click;
            // 
            // txtDesignation
            // 
            txtDesignation.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesignation.Location = new Point(171, 138);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(200, 31);
            txtDesignation.TabIndex = 3;
            // 
            // txtCIP
            // 
            txtCIP.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCIP.Location = new Point(171, 99);
            txtCIP.Name = "txtCIP";
            txtCIP.Size = new Size(200, 31);
            txtCIP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 141);
            label2.Name = "label2";
            label2.Size = new Size(139, 27);
            label2.TabIndex = 1;
            label2.Text = "Désignation : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 99);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 0;
            label1.Text = "CIP : ";
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
            SbtnAnnuler.Location = new Point(500, 199);
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
            SbtnAnnuler.TabIndex = 23;
            SbtnAnnuler.Text = "Menu Principal";
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
            // SbtnSupprimer
            // 
            SbtnSupprimer.BackColor = Color.Transparent;
            SbtnSupprimer.BadgeBackColor = Color.Red;
            SbtnSupprimer.BadgeForeColor = Color.White;
            SbtnSupprimer.BadgeRadius = 10;
            SbtnSupprimer.BadgeRightMargin = 10;
            SbtnSupprimer.BadgeValue = 0;
            SbtnSupprimer.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnSupprimer.BorderColorEnd = Color.Gray;
            SbtnSupprimer.BorderColorStart = Color.White;
            SbtnSupprimer.BorderRadiusBottomLeft = 25;
            SbtnSupprimer.BorderRadiusBottomRight = 25;
            SbtnSupprimer.BorderRadiusTopLeft = 25;
            SbtnSupprimer.BorderRadiusTopRight = 25;
            SbtnSupprimer.BorderThickness = 1;
            SbtnSupprimer.ButtonColorEnd = Color.Red;
            SbtnSupprimer.ButtonColorStart = Color.Orange;
            SbtnSupprimer.ButtonImage = null;
            SbtnSupprimer.CanBeep = false;
            SbtnSupprimer.CanShake = false;
            SbtnSupprimer.ClickSoundPath = null;
            SbtnSupprimer.DisabledOverlayOpacity = 0.5F;
            SbtnSupprimer.EnableBorderGradient = false;
            SbtnSupprimer.EnableClickSound = false;
            SbtnSupprimer.EnableFocusBorder = false;
            SbtnSupprimer.EnableHoverSound = false;
            SbtnSupprimer.EnablePressScale = false;
            SbtnSupprimer.EnableTextShadow = false;
            SbtnSupprimer.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnSupprimer.FocusBorderThickness = 2;
            SbtnSupprimer.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnSupprimer.ForeColor = Color.White;
            SbtnSupprimer.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnSupprimer.HoverSoundPath = null;
            SbtnSupprimer.HoverTransitionSpeed = 1F;
            SbtnSupprimer.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnSupprimer.ImageLeftMargin = 5;
            SbtnSupprimer.ImageRightMargin = 8;
            SbtnSupprimer.ImageSize = 24;
            SbtnSupprimer.IsReadOnly = false;
            SbtnSupprimer.Location = new Point(510, 133);
            SbtnSupprimer.MakeRadial = false;
            SbtnSupprimer.Name = "SbtnSupprimer";
            SbtnSupprimer.PressAnimationSpeed = 0.5F;
            SbtnSupprimer.PressDepth = 1;
            SbtnSupprimer.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnSupprimer.RippleExpandSpeedFactor = 0.05F;
            SbtnSupprimer.RippleFadeSpeedFactor = 0.03F;
            SbtnSupprimer.ShadowBlurFactor = 0.85F;
            SbtnSupprimer.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnSupprimer.ShadowOffsetX = 3;
            SbtnSupprimer.ShadowOffsetY = 3;
            SbtnSupprimer.Size = new Size(123, 50);
            SbtnSupprimer.TabIndex = 23;
            SbtnSupprimer.Text = "Supprimer";
            SbtnSupprimer.TextAlign = ContentAlignment.MiddleCenter;
            SbtnSupprimer.TextPaddingBottom = 0;
            SbtnSupprimer.TextPaddingLeft = 0;
            SbtnSupprimer.TextPaddingRight = 0;
            SbtnSupprimer.TextPaddingTop = 0;
            SbtnSupprimer.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnSupprimer.TextShadowOffsetX = 1;
            SbtnSupprimer.TextShadowOffsetY = 1;
            SbtnSupprimer.Click += SbtnSupprimer_Click;
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
            SBtnImporter.Location = new Point(311, 133);
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
            SBtnImporter.TabIndex = 29;
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
            // FiltrerAutomate
            // 
            FiltrerAutomate.BackColor = Color.Transparent;
            FiltrerAutomate.BadgeBackColor = Color.Red;
            FiltrerAutomate.BadgeForeColor = Color.White;
            FiltrerAutomate.BadgeRadius = 10;
            FiltrerAutomate.BadgeRightMargin = 10;
            FiltrerAutomate.BadgeValue = 0;
            FiltrerAutomate.BorderColor = Color.FromArgb(150, 255, 255, 255);
            FiltrerAutomate.BorderColorEnd = Color.Gray;
            FiltrerAutomate.BorderColorStart = Color.White;
            FiltrerAutomate.BorderRadiusBottomLeft = 25;
            FiltrerAutomate.BorderRadiusBottomRight = 25;
            FiltrerAutomate.BorderRadiusTopLeft = 25;
            FiltrerAutomate.BorderRadiusTopRight = 25;
            FiltrerAutomate.BorderThickness = 1;
            FiltrerAutomate.ButtonColorEnd = Color.Gray;
            FiltrerAutomate.ButtonColorStart = Color.LightGray;
            FiltrerAutomate.ButtonImage = null;
            FiltrerAutomate.CanBeep = false;
            FiltrerAutomate.CanShake = false;
            FiltrerAutomate.ClickSoundPath = null;
            FiltrerAutomate.DisabledOverlayOpacity = 0.5F;
            FiltrerAutomate.EnableBorderGradient = false;
            FiltrerAutomate.EnableClickSound = false;
            FiltrerAutomate.EnableFocusBorder = false;
            FiltrerAutomate.EnableHoverSound = false;
            FiltrerAutomate.EnablePressScale = false;
            FiltrerAutomate.EnableTextShadow = false;
            FiltrerAutomate.FocusBorderColor = Color.FromArgb(100, 150, 255);
            FiltrerAutomate.FocusBorderThickness = 2;
            FiltrerAutomate.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltrerAutomate.ForeColor = Color.White;
            FiltrerAutomate.HoverColor = Color.FromArgb(20, 0, 0, 0);
            FiltrerAutomate.HoverSoundPath = null;
            FiltrerAutomate.HoverTransitionSpeed = 1F;
            FiltrerAutomate.ImageAlign = ContentAlignment.MiddleCenter;
            FiltrerAutomate.ImageLeftMargin = 5;
            FiltrerAutomate.ImageRightMargin = 8;
            FiltrerAutomate.ImageSize = 24;
            FiltrerAutomate.IsReadOnly = false;
            FiltrerAutomate.Location = new Point(43, 199);
            FiltrerAutomate.MakeRadial = false;
            FiltrerAutomate.Name = "FiltrerAutomate";
            FiltrerAutomate.PressAnimationSpeed = 0.5F;
            FiltrerAutomate.PressDepth = 1;
            FiltrerAutomate.RippleColor = Color.FromArgb(60, 255, 255, 255);
            FiltrerAutomate.RippleExpandSpeedFactor = 0.05F;
            FiltrerAutomate.RippleFadeSpeedFactor = 0.03F;
            FiltrerAutomate.ShadowBlurFactor = 0.85F;
            FiltrerAutomate.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            FiltrerAutomate.ShadowOffsetX = 3;
            FiltrerAutomate.ShadowOffsetY = 3;
            FiltrerAutomate.Size = new Size(193, 50);
            FiltrerAutomate.TabIndex = 30;
            FiltrerAutomate.Text = "Filtrer (Automate)";
            FiltrerAutomate.TextAlign = ContentAlignment.MiddleCenter;
            FiltrerAutomate.TextPaddingBottom = 0;
            FiltrerAutomate.TextPaddingLeft = 0;
            FiltrerAutomate.TextPaddingRight = 0;
            FiltrerAutomate.TextPaddingTop = 0;
            FiltrerAutomate.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            FiltrerAutomate.TextShadowOffsetX = 1;
            FiltrerAutomate.TextShadowOffsetY = 1;
            FiltrerAutomate.Click += FiltrerAutomate_Click;
            // 
            // FiltrerMagasin
            // 
            FiltrerMagasin.BackColor = Color.Transparent;
            FiltrerMagasin.BadgeBackColor = Color.Red;
            FiltrerMagasin.BadgeForeColor = Color.White;
            FiltrerMagasin.BadgeRadius = 10;
            FiltrerMagasin.BadgeRightMargin = 10;
            FiltrerMagasin.BadgeValue = 0;
            FiltrerMagasin.BorderColor = Color.FromArgb(150, 255, 255, 255);
            FiltrerMagasin.BorderColorEnd = Color.Gray;
            FiltrerMagasin.BorderColorStart = Color.White;
            FiltrerMagasin.BorderRadiusBottomLeft = 25;
            FiltrerMagasin.BorderRadiusBottomRight = 25;
            FiltrerMagasin.BorderRadiusTopLeft = 25;
            FiltrerMagasin.BorderRadiusTopRight = 25;
            FiltrerMagasin.BorderThickness = 1;
            FiltrerMagasin.ButtonColorEnd = Color.Gray;
            FiltrerMagasin.ButtonColorStart = Color.LightGray;
            FiltrerMagasin.ButtonImage = null;
            FiltrerMagasin.CanBeep = false;
            FiltrerMagasin.CanShake = false;
            FiltrerMagasin.ClickSoundPath = null;
            FiltrerMagasin.DisabledOverlayOpacity = 0.5F;
            FiltrerMagasin.EnableBorderGradient = false;
            FiltrerMagasin.EnableClickSound = false;
            FiltrerMagasin.EnableFocusBorder = false;
            FiltrerMagasin.EnableHoverSound = false;
            FiltrerMagasin.EnablePressScale = false;
            FiltrerMagasin.EnableTextShadow = false;
            FiltrerMagasin.FocusBorderColor = Color.FromArgb(100, 150, 255);
            FiltrerMagasin.FocusBorderThickness = 2;
            FiltrerMagasin.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltrerMagasin.ForeColor = Color.White;
            FiltrerMagasin.HoverColor = Color.FromArgb(20, 0, 0, 0);
            FiltrerMagasin.HoverSoundPath = null;
            FiltrerMagasin.HoverTransitionSpeed = 1F;
            FiltrerMagasin.ImageAlign = ContentAlignment.MiddleCenter;
            FiltrerMagasin.ImageLeftMargin = 5;
            FiltrerMagasin.ImageRightMargin = 8;
            FiltrerMagasin.ImageSize = 24;
            FiltrerMagasin.IsReadOnly = false;
            FiltrerMagasin.Location = new Point(243, 199);
            FiltrerMagasin.MakeRadial = false;
            FiltrerMagasin.Name = "FiltrerMagasin";
            FiltrerMagasin.PressAnimationSpeed = 0.5F;
            FiltrerMagasin.PressDepth = 1;
            FiltrerMagasin.RippleColor = Color.FromArgb(60, 255, 255, 255);
            FiltrerMagasin.RippleExpandSpeedFactor = 0.05F;
            FiltrerMagasin.RippleFadeSpeedFactor = 0.03F;
            FiltrerMagasin.ShadowBlurFactor = 0.85F;
            FiltrerMagasin.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            FiltrerMagasin.ShadowOffsetX = 3;
            FiltrerMagasin.ShadowOffsetY = 3;
            FiltrerMagasin.Size = new Size(193, 50);
            FiltrerMagasin.TabIndex = 31;
            FiltrerMagasin.Text = "Filtrer (Magasin)";
            FiltrerMagasin.TextAlign = ContentAlignment.MiddleCenter;
            FiltrerMagasin.TextPaddingBottom = 0;
            FiltrerMagasin.TextPaddingLeft = 0;
            FiltrerMagasin.TextPaddingRight = 0;
            FiltrerMagasin.TextPaddingTop = 0;
            FiltrerMagasin.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            FiltrerMagasin.TextShadowOffsetX = 1;
            FiltrerMagasin.TextShadowOffsetY = 1;
            FiltrerMagasin.Click += FiltrerMagasin_Click;
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
            SViderBDD.Location = new Point(433, 133);
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
            SViderBDD.TabIndex = 32;
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
            btnAnnulerFiltre.ButtonColorEnd = Color.Gray;
            btnAnnulerFiltre.ButtonColorStart = Color.LightGray;
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
            btnAnnulerFiltre.Location = new Point(440, 199);
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
            btnAnnulerFiltre.TabIndex = 33;
            btnAnnulerFiltre.Text = "Annuler filtre";
            btnAnnulerFiltre.TextAlign = ContentAlignment.MiddleCenter;
            btnAnnulerFiltre.TextPaddingBottom = 0;
            btnAnnulerFiltre.TextPaddingLeft = 0;
            btnAnnulerFiltre.TextPaddingRight = 0;
            btnAnnulerFiltre.TextPaddingTop = 0;
            btnAnnulerFiltre.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnAnnulerFiltre.TextShadowOffsetX = 1;
            btnAnnulerFiltre.TextShadowOffsetY = 1;
            btnAnnulerFiltre.Click += btnAnnulerFiltre_Click;
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
            btnRechercherCodeGeo.Location = new Point(292, 88);
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
            btnRechercherCodeGeo.TabIndex = 34;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 99);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 35;
            label6.Text = "Code géo :";
            // 
            // filtrebutton
            // 
            filtrebutton.BackColor = Color.Transparent;
            filtrebutton.BackgroundImage = (Image)resources.GetObject("filtrebutton.BackgroundImage");
            filtrebutton.BackgroundImageLayout = ImageLayout.Stretch;
            filtrebutton.BadgeBackColor = Color.White;
            filtrebutton.BadgeForeColor = Color.White;
            filtrebutton.BadgeRadius = 10;
            filtrebutton.BadgeRightMargin = 10;
            filtrebutton.BadgeValue = 0;
            filtrebutton.BorderColor = Color.White;
            filtrebutton.BorderColorEnd = Color.Transparent;
            filtrebutton.BorderColorStart = Color.White;
            filtrebutton.BorderRadiusBottomLeft = 25;
            filtrebutton.BorderRadiusBottomRight = 25;
            filtrebutton.BorderRadiusTopLeft = 25;
            filtrebutton.BorderRadiusTopRight = 25;
            filtrebutton.BorderThickness = 1;
            filtrebutton.ButtonColorEnd = Color.Transparent;
            filtrebutton.ButtonColorStart = Color.Transparent;
            filtrebutton.ButtonImage = null;
            filtrebutton.CanBeep = false;
            filtrebutton.CanShake = false;
            filtrebutton.ClickSoundPath = null;
            filtrebutton.DisabledOverlayOpacity = 0.5F;
            filtrebutton.EnableBorderGradient = false;
            filtrebutton.EnableClickSound = false;
            filtrebutton.EnableFocusBorder = false;
            filtrebutton.EnableHoverSound = false;
            filtrebutton.EnablePressScale = false;
            filtrebutton.EnableTextShadow = false;
            filtrebutton.FocusBorderColor = Color.White;
            filtrebutton.FocusBorderThickness = 2;
            filtrebutton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filtrebutton.ForeColor = Color.White;
            filtrebutton.HoverColor = Color.FromArgb(20, 0, 0, 0);
            filtrebutton.HoverSoundPath = null;
            filtrebutton.HoverTransitionSpeed = 1F;
            filtrebutton.ImageAlign = ContentAlignment.MiddleCenter;
            filtrebutton.ImageLeftMargin = 5;
            filtrebutton.ImageRightMargin = 8;
            filtrebutton.ImageSize = 24;
            filtrebutton.IsReadOnly = false;
            filtrebutton.Location = new Point(329, 138);
            filtrebutton.MakeRadial = false;
            filtrebutton.Name = "filtrebutton";
            filtrebutton.PressAnimationSpeed = 0.5F;
            filtrebutton.PressDepth = 1;
            filtrebutton.RippleColor = Color.Transparent;
            filtrebutton.RippleExpandSpeedFactor = 0.05F;
            filtrebutton.RippleFadeSpeedFactor = 0.03F;
            filtrebutton.ShadowBlurFactor = 0.01F;
            filtrebutton.ShadowColor = Color.Transparent;
            filtrebutton.ShadowOffsetX = 3;
            filtrebutton.ShadowOffsetY = 3;
            filtrebutton.Size = new Size(55, 54);
            filtrebutton.TabIndex = 36;
            filtrebutton.TextAlign = ContentAlignment.MiddleCenter;
            filtrebutton.TextPaddingBottom = 0;
            filtrebutton.TextPaddingLeft = 0;
            filtrebutton.TextPaddingRight = 0;
            filtrebutton.TextPaddingTop = 0;
            filtrebutton.TextShadowColor = Color.White;
            filtrebutton.TextShadowOffsetX = 1;
            filtrebutton.TextShadowOffsetY = 1;
            filtrebutton.Click += filtrebutton_Click;
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
            siticoneGroupBox1.Controls.Add(SbtnAjouter);
            siticoneGroupBox1.Controls.Add(ligne2);
            siticoneGroupBox1.Controls.Add(label1);
            siticoneGroupBox1.Controls.Add(label2);
            siticoneGroupBox1.Controls.Add(txtDesignation);
            siticoneGroupBox1.Controls.Add(txtCIP);
            siticoneGroupBox1.CornerRadius = 15;
            siticoneGroupBox1.EnableBlinking = false;
            siticoneGroupBox1.EnableHoverAnimation = true;
            siticoneGroupBox1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneGroupBox1.ForeColor = Color.Black;
            siticoneGroupBox1.GradientEndColor = Color.LightGray;
            siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox1.GradientStartColor = Color.White;
            siticoneGroupBox1.GroupTitle = "Enregistrer une ligne";
            siticoneGroupBox1.HoveredBorderColor = Color.Green;
            siticoneGroupBox1.HoveredTitleColor = Color.Black;
            siticoneGroupBox1.IsCollapsed = false;
            siticoneGroupBox1.IsCollapsible = false;
            siticoneGroupBox1.Location = new Point(33, 710);
            siticoneGroupBox1.MaxBlinkCount = 3;
            siticoneGroupBox1.Name = "siticoneGroupBox1";
            siticoneGroupBox1.PressedBorderColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox1.ShadowColor = Color.FromArgb(192, 192, 0);
            siticoneGroupBox1.ShadowDepth = 3;
            siticoneGroupBox1.ShowShadow = true;
            siticoneGroupBox1.Size = new Size(409, 286);
            siticoneGroupBox1.SolidFillColor = Color.White;
            siticoneGroupBox1.StatusIcon = null;
            siticoneGroupBox1.StatusText = "";
            siticoneGroupBox1.TabIndex = 37;
            siticoneGroupBox1.TitleBackColor = Color.Transparent;
            siticoneGroupBox1.TitleColor = Color.Black;
            siticoneGroupBox1.TitlePadding = new Padding(0, 0, 0, 12);
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
            siticoneGroupBox2.Controls.Add(label12);
            siticoneGroupBox2.Controls.Add(label3);
            siticoneGroupBox2.Controls.Add(label4);
            siticoneGroupBox2.Controls.Add(label5);
            siticoneGroupBox2.Controls.Add(filtrebutton);
            siticoneGroupBox2.Controls.Add(SbtnSupprimer);
            siticoneGroupBox2.Controls.Add(label7);
            siticoneGroupBox2.Controls.Add(label6);
            siticoneGroupBox2.Controls.Add(btnAnnulerFiltre);
            siticoneGroupBox2.Controls.Add(FiltrerMagasin);
            siticoneGroupBox2.Controls.Add(btnRechercherCodeGeo);
            siticoneGroupBox2.Controls.Add(FiltrerAutomate);
            siticoneGroupBox2.Controls.Add(txtRechercheCodeGeo);
            siticoneGroupBox2.CornerRadius = 15;
            siticoneGroupBox2.EnableBlinking = false;
            siticoneGroupBox2.EnableHoverAnimation = true;
            siticoneGroupBox2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneGroupBox2.ForeColor = Color.Black;
            siticoneGroupBox2.GradientEndColor = Color.LightGray;
            siticoneGroupBox2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox2.GradientStartColor = Color.White;
            siticoneGroupBox2.GroupTitle = "Interagir avec la base de données";
            siticoneGroupBox2.HoveredBorderColor = Color.DarkRed;
            siticoneGroupBox2.HoveredTitleColor = Color.Black;
            siticoneGroupBox2.IsCollapsed = false;
            siticoneGroupBox2.IsCollapsible = false;
            siticoneGroupBox2.Location = new Point(466, 710);
            siticoneGroupBox2.MaxBlinkCount = 3;
            siticoneGroupBox2.Name = "siticoneGroupBox2";
            siticoneGroupBox2.PressedBorderColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox2.ShadowColor = Color.FromArgb(192, 192, 0);
            siticoneGroupBox2.ShadowDepth = 3;
            siticoneGroupBox2.ShowShadow = true;
            siticoneGroupBox2.Size = new Size(675, 286);
            siticoneGroupBox2.SolidFillColor = Color.White;
            siticoneGroupBox2.StatusIcon = null;
            siticoneGroupBox2.StatusText = "";
            siticoneGroupBox2.TabIndex = 38;
            siticoneGroupBox2.TitleBackColor = Color.Transparent;
            siticoneGroupBox2.TitleColor = Color.Black;
            siticoneGroupBox2.TitlePadding = new Padding(0, 0, 0, 12);
            siticoneGroupBox2.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox2.UseGradient = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 149);
            label12.Name = "label12";
            label12.Size = new Size(290, 27);
            label12.TabIndex = 23;
            label12.Text = "Filtrer les produits incorrects :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 158);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(28, 125);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 61);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(28, 93);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 1;
            // 
            // siticoneGroupBox3
            // 
            siticoneGroupBox3.BackColor = Color.Transparent;
            siticoneGroupBox3.BadgeColor = Color.Red;
            siticoneGroupBox3.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox3.BadgeLeftPadding = 12;
            siticoneGroupBox3.BadgeValue = 0;
            siticoneGroupBox3.BadgeVisible = false;
            siticoneGroupBox3.BlinkInterval = 500;
            siticoneGroupBox3.BlinkMinOpacity = 0.3F;
            siticoneGroupBox3.BlinkOpacityStep = 0.05F;
            siticoneGroupBox3.BorderColor = Color.LightGray;
            siticoneGroupBox3.BorderWidth = 3F;
            siticoneGroupBox3.CanHover = true;
            siticoneGroupBox3.ChevronColor = Color.Black;
            siticoneGroupBox3.ChevronLeftSpacing = 4F;
            siticoneGroupBox3.ChevronSize = 10F;
            siticoneGroupBox3.ChevronThickness = 2F;
            siticoneGroupBox3.ContentPadding = 5;
            siticoneGroupBox3.Controls.Add(label13);
            siticoneGroupBox3.Controls.Add(cerp);
            siticoneGroupBox3.Controls.Add(label8);
            siticoneGroupBox3.Controls.Add(label9);
            siticoneGroupBox3.Controls.Add(SbtnAnnuler);
            siticoneGroupBox3.Controls.Add(SBtnErreursAutomate);
            siticoneGroupBox3.Controls.Add(label10);
            siticoneGroupBox3.Controls.Add(label11);
            siticoneGroupBox3.Controls.Add(btnPrint);
            siticoneGroupBox3.Controls.Add(SBtnImporter);
            siticoneGroupBox3.Controls.Add(SViderBDD);
            siticoneGroupBox3.CornerRadius = 15;
            siticoneGroupBox3.EnableBlinking = false;
            siticoneGroupBox3.EnableHoverAnimation = true;
            siticoneGroupBox3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneGroupBox3.ForeColor = Color.Black;
            siticoneGroupBox3.GradientEndColor = Color.LightGray;
            siticoneGroupBox3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox3.GradientStartColor = Color.White;
            siticoneGroupBox3.GroupTitle = "Générales";
            siticoneGroupBox3.HoveredBorderColor = Color.DarkBlue;
            siticoneGroupBox3.HoveredTitleColor = Color.Black;
            siticoneGroupBox3.IsCollapsed = false;
            siticoneGroupBox3.IsCollapsible = false;
            siticoneGroupBox3.Location = new Point(1164, 710);
            siticoneGroupBox3.MaxBlinkCount = 3;
            siticoneGroupBox3.Name = "siticoneGroupBox3";
            siticoneGroupBox3.PressedBorderColor = Color.FromArgb(40, 90, 160);
            siticoneGroupBox3.ShadowColor = Color.FromArgb(192, 192, 0);
            siticoneGroupBox3.ShadowDepth = 3;
            siticoneGroupBox3.ShowShadow = true;
            siticoneGroupBox3.Size = new Size(704, 286);
            siticoneGroupBox3.SolidFillColor = Color.White;
            siticoneGroupBox3.StatusIcon = null;
            siticoneGroupBox3.StatusText = "";
            siticoneGroupBox3.TabIndex = 38;
            siticoneGroupBox3.TitleBackColor = Color.Transparent;
            siticoneGroupBox3.TitleColor = Color.Black;
            siticoneGroupBox3.TitlePadding = new Padding(0, 0, 0, 12);
            siticoneGroupBox3.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox3.UseGradient = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(397, 85);
            label13.Name = "label13";
            label13.Size = new Size(188, 27);
            label13.TabIndex = 37;
            label13.Text = "Exporter vers PDF :";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(48, 61);
            cerp.Name = "cerp";
            cerp.Size = new Size(213, 200);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 38;
            cerp.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(28, 158);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(28, 125);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(28, 61);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(28, 93);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 1;
            // 
            // Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(siticoneGroupBox3);
            Controls.Add(siticoneGroupBox2);
            Controls.Add(siticoneGroupBox1);
            Controls.Add(dgvMutation);
            Controls.Add(Groupbox);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Enregistrement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enregistrer";
            ((System.ComponentModel.ISupportInitialize)dgvMutation).EndInit();
            siticoneGroupBox1.ResumeLayout(false);
            siticoneGroupBox1.PerformLayout();
            siticoneGroupBox2.ResumeLayout(false);
            siticoneGroupBox2.PerformLayout();
            siticoneGroupBox3.ResumeLayout(false);
            siticoneGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMutation;
        private GroupBox Groupbox;
        private TextBox txtDesignation;
        private TextBox txtCIP;
        private Label label2;
        private Label label1;
        private Button btnMenuPrincipal;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnAjouter;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnAnnuler;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnSupprimer;
        private Button btnPrint;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SBtnImporter;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerAutomate;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerMagasin;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SViderBDD;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnAnnulerFiltre;
        private TextBox txtRechercheCodeGeo;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnRechercherCodeGeo;
        private Label label6;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced filtrebutton;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SBtnErreursAutomate;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox1;
        private Label ligne4;
        private Label ligne3;
        private Label ligne1;
        private Label ligne2;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox cerp;
        private Label label12;
        private Label label13;
    }
}