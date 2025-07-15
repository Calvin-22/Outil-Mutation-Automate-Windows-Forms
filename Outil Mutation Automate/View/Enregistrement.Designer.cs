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
            groupBox1.Size = new Size(1233, 194);
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
            SbtnAnnuler.Location = new Point(1085, 400);
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
            cerp.Location = new Point(1061, 105);
            cerp.Name = "cerp";
            cerp.Size = new Size(220, 200);
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
            // Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 689);
            Controls.Add(SbtnSupprimer);
            Controls.Add(SbtnAnnuler);
            Controls.Add(cerp);
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
    }
}