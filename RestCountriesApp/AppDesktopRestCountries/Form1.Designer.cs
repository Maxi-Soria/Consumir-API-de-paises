namespace AppDesktopRestCountries
{
    partial class Form1
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
            cbPaises = new ComboBox();
            pbBandera = new PictureBox();
            lblNombre = new Label();
            lblCapital = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBandera).BeginInit();
            SuspendLayout();
            // 
            // cbPaises
            // 
            cbPaises.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaises.FormattingEnabled = true;
            cbPaises.Location = new Point(163, 65);
            cbPaises.Name = "cbPaises";
            cbPaises.Size = new Size(121, 23);
            cbPaises.TabIndex = 0;
            cbPaises.SelectedIndexChanged += cbPaises_SelectedIndexChanged;
            // 
            // pbBandera
            // 
            pbBandera.Location = new Point(376, 175);
            pbBandera.Name = "pbBandera";
            pbBandera.Size = new Size(258, 130);
            pbBandera.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBandera.TabIndex = 1;
            pbBandera.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(490, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(24, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "...";
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Font = new Font("Segoe UI", 15F);
            lblCapital.Location = new Point(490, 125);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(24, 28);
            lblCapital.TabIndex = 3;
            lblCapital.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(376, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 4;
            label1.Text = "Pais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(376, 125);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 5;
            label2.Text = "Capital:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCapital);
            Controls.Add(lblNombre);
            Controls.Add(pbBandera);
            Controls.Add(cbPaises);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbBandera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPaises;
        private PictureBox pbBandera;
        private Label lblNombre;
        private Label lblCapital;
        private Label label1;
        private Label label2;
    }
}