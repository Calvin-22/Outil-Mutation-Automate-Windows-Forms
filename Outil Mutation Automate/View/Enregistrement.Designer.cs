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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enregistrement));
            dgvMutation = new DataGridView();
            btnSupprimer = new Button();
            Groupbox = new GroupBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnConfirmer = new Button();
            txtDesignation = new TextBox();
            txtCIP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAnnuler = new Button();
            cerp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMutation).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cerp).BeginInit();
            SuspendLayout();
            // 
            // dgvMutation
            // 
            dgvMutation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMutation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMutation.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Green;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMutation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMutation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMutation.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMutation.EnableHeadersVisualStyles = false;
            dgvMutation.Location = new Point(54, 55);
            dgvMutation.MultiSelect = false;
            dgvMutation.Name = "dgvMutation";
            dgvMutation.ReadOnly = true;
            dgvMutation.RowHeadersVisible = false;
            dgvMutation.RowHeadersWidth = 62;
            dgvMutation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMutation.Size = new Size(793, 239);
            dgvMutation.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(69, 317);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(112, 39);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(637, 93);
            label4.Name = "label4";
            label4.Size = new Size(339, 24);
            label4.TabIndex = 6;
            label4.Text = "*NBV : Nombre de boîte vendues par jour.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(636, 69);
            label3.Name = "label3";
            label3.Size = new Size(328, 24);
            label3.TabIndex = 5;
            label3.Text = "*NBC : Nombre de boîte par commande.";
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(21, 138);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(112, 39);
            btnConfirmer.TabIndex = 4;
            btnConfirmer.Text = "Ajouter";
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
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(902, 317);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(159, 39);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Menu Principal";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
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
            // Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 588);
            Controls.Add(btnAnnuler);
            Controls.Add(cerp);
            Controls.Add(groupBox1);
            Controls.Add(btnSupprimer);
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
        private Label label4;
        private Label label3;
    }
}