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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enregistrement));
            dgvMutation = new DataGridView();
            Groupbox = new GroupBox();
            txtRechercheCodeGeo = new TextBox();
            groupBox1 = new GroupBox();
            btnPrint = new Button();
            label5 = new Label();
            SbtnAjouter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label4 = new Label();
            label3 = new Label();
            txtDesignation = new TextBox();
            txtCIP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SbtnAnnuler = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            cerp = new PictureBox();
            SbtnSupprimer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SBtnImporter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerAutomate = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            FiltrerMagasin = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SViderBDD = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnAnnulerFiltre = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnRechercherCodeGeo = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMutation).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            SuspendLayout();
            // 
            // dgvMutation
            // 
            dgvMutation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMutation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMutation.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Green;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Padding = new Padding(1);
            dataGridViewCellStyle9.SelectionBackColor = Color.Green;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvMutation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvMutation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(1);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvMutation.DefaultCellStyle = dataGridViewCellStyle10;
            dgvMutation.EnableHeadersVisualStyles = false;
            dgvMutation.Location = new Point(54, 55);
            dgvMutation.MultiSelect = false;
            dgvMutation.Name = "dgvMutation";
            dgvMutation.ReadOnly = true;
            dgvMutation.RowHeadersVisible = false;
            dgvMutation.RowHeadersWidth = 62;
            dgvMutation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMutation.Size = new Size(971, 324);
            dgvMutation.TabIndex = 0;
            // 
            // Groupbox
            // 
            Groupbox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Groupbox.ForeColor = Color.Black;
            Groupbox.Location = new Point(48, 26);
            Groupbox.Name = "Groupbox";
            Groupbox.Size = new Size(983, 359);
            Groupbox.TabIndex = 3;
            Groupbox.TabStop = false;
            Groupbox.Text = "Lignes Enregistrées";
            // 
            // txtRechercheCodeGeo
            // 
            txtRechercheCodeGeo.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRechercheCodeGeo.Location = new Point(1070, 291);
            txtRechercheCodeGeo.Name = "txtRechercheCodeGeo";
            txtRechercheCodeGeo.Size = new Size(114, 31);
            txtRechercheCodeGeo.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrint);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(SbtnAjouter);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDesignation);
            groupBox1.Controls.Add(txtCIP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(48, 459);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1242, 194);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enregistrer une ligne";
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.Location = new Point(1087, 69);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(63, 61);
            btnPrint.TabIndex = 24;
            btnPrint.Tag = "";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(576, 116);
            label5.Name = "label5";
            label5.Size = new Size(362, 24);
            label5.TabIndex = 23;
            label5.Text = "*Canaux : Nombre de canaux nécessaires.";
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
            SbtnAjouter.Location = new Point(20, 131);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(576, 93);
            label4.Name = "label4";
            label4.Size = new Size(360, 24);
            label4.TabIndex = 6;
            label4.Text = "*NBV : Nombre de boîte vendues par jour.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(575, 69);
            label3.Name = "label3";
            label3.Size = new Size(347, 24);
            label3.TabIndex = 5;
            label3.Text = "*NBC : Nombre de boîte par commande.";
            // 
            // txtDesignation
            // 
            txtDesignation.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesignation.Location = new Point(158, 86);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(200, 31);
            txtDesignation.TabIndex = 3;
            // 
            // txtCIP
            // 
            txtCIP.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCIP.Location = new Point(158, 48);
            txtCIP.Name = "txtCIP";
            txtCIP.Size = new Size(200, 31);
            txtCIP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 1;
            label2.Text = "Désignation : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(53, 24);
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
            SbtnAnnuler.Location = new Point(1123, 400);
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
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(1063, 39);
            cerp.Name = "cerp";
            cerp.Size = new Size(230, 208);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 13;
            cerp.TabStop = false;
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
            SbtnSupprimer.Location = new Point(69, 400);
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
            SBtnImporter.Location = new Point(1001, 400);
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
            FiltrerAutomate.Location = new Point(273, 400);
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
            FiltrerMagasin.Location = new Point(472, 400);
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
            SViderBDD.Location = new Point(1056, 329);
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
            btnAnnulerFiltre.Location = new Point(671, 400);
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
            btnRechercherCodeGeo.Location = new Point(1190, 278);
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
            label6.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1066, 264);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 35;
            label6.Text = "Code géo :";
            // 
            // Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 689);
            Controls.Add(label6);
            Controls.Add(cerp);
            Controls.Add(btnRechercherCodeGeo);
            Controls.Add(txtRechercheCodeGeo);
            Controls.Add(btnAnnulerFiltre);
            Controls.Add(SViderBDD);
            Controls.Add(FiltrerMagasin);
            Controls.Add(FiltrerAutomate);
            Controls.Add(SBtnImporter);
            Controls.Add(SbtnSupprimer);
            Controls.Add(SbtnAnnuler);
            Controls.Add(groupBox1);
            Controls.Add(dgvMutation);
            Controls.Add(Groupbox);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Enregistrement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enregistrer";
            ((System.ComponentModel.ISupportInitialize)dgvMutation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMutation;
        private GroupBox Groupbox;
        private GroupBox groupBox1;
        private TextBox txtDesignation;
        private TextBox txtCIP;
        private Label label2;
        private Label label1;
        private PictureBox cerp;
        private Button btnMenuPrincipal;
        private Label label4;
        private Label label3;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnAjouter;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnAnnuler;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnSupprimer;
        private Label label5;
        private Button btnPrint;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SBtnImporter;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerAutomate;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced FiltrerMagasin;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SViderBDD;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnAnnulerFiltre;
        private TextBox txtRechercheCodeGeo;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnRechercherCodeGeo;
        private Label label6;
    }
}