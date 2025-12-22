namespace Outil_Mutation_Automate.View
{
    partial class FrmAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthentification));
            IDLabel = new Label();
            txtIdentifiant = new TextBox();
            mdplabel = new Label();
            cerp = new PictureBox();
            txtMdp = new TextBox();
            SbtnConnexion = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.Black;
            IDLabel.Location = new Point(35, 313);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(129, 27);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "Identifiant : ";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Cursor = Cursors.IBeam;
            txtIdentifiant.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentifiant.Location = new Point(212, 309);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(191, 31);
            txtIdentifiant.TabIndex = 3;
            // 
            // mdplabel
            // 
            mdplabel.AutoSize = true;
            mdplabel.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mdplabel.ForeColor = Color.Black;
            mdplabel.Location = new Point(35, 363);
            mdplabel.Name = "mdplabel";
            mdplabel.Size = new Size(149, 27);
            mdplabel.TabIndex = 4;
            mdplabel.Text = "Mot de passe :";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(126, 30);
            cerp.Name = "cerp";
            cerp.Size = new Size(213, 200);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 13;
            cerp.TabStop = false;
            // 
            // txtMdp
            // 
            txtMdp.Cursor = Cursors.IBeam;
            txtMdp.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMdp.Location = new Point(212, 363);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(191, 31);
            txtMdp.TabIndex = 14;
            // 
            // SbtnConnexion
            // 
            SbtnConnexion.BackColor = Color.Transparent;
            SbtnConnexion.BadgeBackColor = Color.Red;
            SbtnConnexion.BadgeForeColor = Color.White;
            SbtnConnexion.BadgeRadius = 10;
            SbtnConnexion.BadgeRightMargin = 10;
            SbtnConnexion.BadgeValue = 0;
            SbtnConnexion.BorderColor = Color.FromArgb(150, 255, 255, 255);
            SbtnConnexion.BorderColorEnd = Color.Gray;
            SbtnConnexion.BorderColorStart = Color.White;
            SbtnConnexion.BorderRadiusBottomLeft = 25;
            SbtnConnexion.BorderRadiusBottomRight = 25;
            SbtnConnexion.BorderRadiusTopLeft = 25;
            SbtnConnexion.BorderRadiusTopRight = 25;
            SbtnConnexion.BorderThickness = 1;
            SbtnConnexion.ButtonColorEnd = Color.Green;
            SbtnConnexion.ButtonColorStart = Color.LimeGreen;
            SbtnConnexion.ButtonImage = null;
            SbtnConnexion.CanBeep = false;
            SbtnConnexion.CanShake = false;
            SbtnConnexion.ClickSoundPath = null;
            SbtnConnexion.DisabledOverlayOpacity = 0.5F;
            SbtnConnexion.EnableBorderGradient = false;
            SbtnConnexion.EnableClickSound = false;
            SbtnConnexion.EnableFocusBorder = false;
            SbtnConnexion.EnableHoverSound = false;
            SbtnConnexion.EnablePressScale = false;
            SbtnConnexion.EnableTextShadow = false;
            SbtnConnexion.FocusBorderColor = Color.FromArgb(100, 150, 255);
            SbtnConnexion.FocusBorderThickness = 2;
            SbtnConnexion.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SbtnConnexion.ForeColor = Color.White;
            SbtnConnexion.HoverColor = Color.FromArgb(20, 0, 0, 0);
            SbtnConnexion.HoverSoundPath = null;
            SbtnConnexion.HoverTransitionSpeed = 1F;
            SbtnConnexion.ImageAlign = ContentAlignment.MiddleCenter;
            SbtnConnexion.ImageLeftMargin = 5;
            SbtnConnexion.ImageRightMargin = 8;
            SbtnConnexion.ImageSize = 24;
            SbtnConnexion.IsReadOnly = false;
            SbtnConnexion.Location = new Point(252, 411);
            SbtnConnexion.MakeRadial = false;
            SbtnConnexion.Name = "SbtnConnexion";
            SbtnConnexion.PressAnimationSpeed = 0.5F;
            SbtnConnexion.PressDepth = 1;
            SbtnConnexion.RippleColor = Color.FromArgb(60, 255, 255, 255);
            SbtnConnexion.RippleExpandSpeedFactor = 0.05F;
            SbtnConnexion.RippleFadeSpeedFactor = 0.03F;
            SbtnConnexion.ShadowBlurFactor = 0.85F;
            SbtnConnexion.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            SbtnConnexion.ShadowOffsetX = 3;
            SbtnConnexion.ShadowOffsetY = 3;
            SbtnConnexion.Size = new Size(151, 50);
            SbtnConnexion.TabIndex = 22;
            SbtnConnexion.Text = "Se connecter";
            SbtnConnexion.TextAlign = ContentAlignment.MiddleCenter;
            SbtnConnexion.TextPaddingBottom = 0;
            SbtnConnexion.TextPaddingLeft = 0;
            SbtnConnexion.TextPaddingRight = 0;
            SbtnConnexion.TextPaddingTop = 0;
            SbtnConnexion.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            SbtnConnexion.TextShadowOffsetX = 1;
            SbtnConnexion.TextShadowOffsetY = 1;
            SbtnConnexion.Click += SbtnConnexion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSlateGray;
            label4.Location = new Point(35, 260);
            label4.Name = "label4";
            label4.Size = new Size(257, 27);
            label4.TabIndex = 31;
            label4.Text = "Veuillez vous authentifier :";
            // 
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(456, 507);
            Controls.Add(label4);
            Controls.Add(SbtnConnexion);
            Controls.Add(txtMdp);
            Controls.Add(cerp);
            Controls.Add(mdplabel);
            Controls.Add(IDLabel);
            Controls.Add(txtIdentifiant);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authentification";
            Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private TextBox txtIdentifiant;
        private Label mdplabel;
        private PictureBox cerp;
        private TextBox txtMdp;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced SbtnConnexion;
        private Label label4;
    }
}