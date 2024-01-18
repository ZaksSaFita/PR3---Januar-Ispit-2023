namespace DLWMS.WinForms.ispitIB220116
{
    partial class frmNovoUvjerenjeIB220116
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbVrsta = new ComboBox();
            label2 = new Label();
            txtSvrha = new TextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "", "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta", "Uvjerenje o godini studija" });
            cmbVrsta.Location = new Point(12, 27);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(222, 23);
            cmbVrsta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Svrha uplatnice:";
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 78);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(222, 166);
            txtSvrha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Skenirana uplatnica:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(252, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(380, 188);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(557, 221);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 251);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(txtSvrha);
            Controls.Add(label2);
            Controls.Add(cmbVrsta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNovoUvjerenjeIB220116";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmNovoUvjerenjeIB220116";
            Load += frmNovoUvjerenjeIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbVrsta;
        private Label label2;
        private TextBox txtSvrha;
        private Label label3;
        private PictureBox pbSlika;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}