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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enregistrement));
            dgvMutation = new DataGridView();
            btnModifier = new Button();
            btnSupprimer = new Button();
            Groupbox = new GroupBox();
            groupBox1 = new GroupBox();
            btnAnnuler = new Button();
            btnConfirmer = new Button();
            txtDesignation = new TextBox();
            txtCIP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cerp = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMutation).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            SuspendLayout();
            // 
            // dgvMutation
            // 
            dgvMutation.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMutation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMutation.Location = new Point(54, 55);
            dgvMutation.Name = "dgvMutation";
            dgvMutation.RowHeadersWidth = 62;
            dgvMutation.Size = new Size(793, 239);
            dgvMutation.TabIndex = 0;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(58, 317);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(112, 39);
            btnModifier.TabIndex = 1;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(187, 317);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(112, 39);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // Groupbox
            // 
            Groupbox.Location = new Point(48, 26);
            Groupbox.Name = "Groupbox";
            Groupbox.Size = new Size(805, 274);
            Groupbox.TabIndex = 3;
            Groupbox.TabStop = false;
            Groupbox.Text = "Lignes Enregistrées";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAnnuler);
            groupBox1.Controls.Add(btnConfirmer);
            groupBox1.Controls.Add(txtDesignation);
            groupBox1.Controls.Add(txtCIP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 362);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1042, 194);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enregistrer une ligne";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(139, 140);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(112, 39);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(10, 140);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(112, 39);
            btnConfirmer.TabIndex = 4;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(158, 86);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(200, 31);
            txtDesignation.TabIndex = 3;
            // 
            // txtCIP
            // 
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
            label2.Size = new Size(116, 24);
            label2.TabIndex = 1;
            label2.Text = "Désignation : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 0;
            label1.Text = "CIP : ";
            // 
            // cerp
            // 
            cerp.Image = (Image)resources.GetObject("cerp.Image");
            cerp.Location = new Point(870, 64);
            cerp.Name = "cerp";
            cerp.Size = new Size(220, 200);
            cerp.SizeMode = PictureBoxSizeMode.Zoom;
            cerp.TabIndex = 13;
            cerp.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(895, 317);
            button1.Name = "button1";
            button1.Size = new Size(166, 39);
            button1.TabIndex = 14;
            button1.Text = "Menu Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 588);
            Controls.Add(button1);
            Controls.Add(cerp);
            Controls.Add(groupBox1);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(dgvMutation);
            Controls.Add(Groupbox);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Enregistrement";
            Text = "Enregistrer";
            ((System.ComponentModel.ISupportInitialize)dgvMutation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMutation;
        private Button btnModifier;
        private Button btnSupprimer;
        private GroupBox Groupbox;
        private GroupBox groupBox1;
        private Button btnAnnuler;
        private Button btnConfirmer;
        private TextBox txtDesignation;
        private TextBox txtCIP;
        private Label label2;
        private Label label1;
        private PictureBox cerp;
        private Button btnMenuPrincipal;
        private Button button1;
    }
}