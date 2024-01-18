namespace DLWMS.WinForms.ispitIB220116
{
    partial class frmPretragaIB220116
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
            cmbSpol = new ComboBox();
            label2 = new Label();
            dtpDatumOD = new DateTimePicker();
            label3 = new Label();
            dtpDatumDO = new DateTimePicker();
            dgvPretraga = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenje = new DataGridViewButtonColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(51, 6);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(121, 23);
            cmbSpol.TabIndex = 1;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "roden u periodu od";
            // 
            // dtpDatumOD
            // 
            dtpDatumOD.Location = new Point(293, 6);
            dtpDatumOD.Name = "dtpDatumOD";
            dtpDatumOD.Size = new Size(200, 23);
            dtpDatumOD.TabIndex = 3;
            dtpDatumOD.Value = new DateTime(1900, 1, 15, 20, 17, 0, 0);
            dtpDatumOD.ValueChanged += dtpDatumOD_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "do";
            // 
            // dtpDatumDO
            // 
            dtpDatumDO.Location = new Point(526, 6);
            dtpDatumDO.Name = "dtpDatumDO";
            dtpDatumDO.Size = new Size(200, 23);
            dtpDatumDO.TabIndex = 5;
            dtpDatumDO.ValueChanged += dtpDatumDO_ValueChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, StudentName, Prosjek, DatumRodjenja, Aktivan, Uvjerenje });
            dgvPretraga.Location = new Point(12, 35);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowTemplate.Height = 25;
            dgvPretraga.Size = new Size(714, 161);
            dgvPretraga.TabIndex = 6;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Ime i prezime";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenje
            // 
            Uvjerenje.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenje.HeaderText = "";
            Uvjerenje.Name = "Uvjerenje";
            Uvjerenje.ReadOnly = true;
            Uvjerenje.Text = "Uvjerenje";
            Uvjerenje.UseColumnTextForButtonValue = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPretragaIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 208);
            Controls.Add(dgvPretraga);
            Controls.Add(dtpDatumDO);
            Controls.Add(label3);
            Controls.Add(dtpDatumOD);
            Controls.Add(label2);
            Controls.Add(cmbSpol);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmPretragaIB220116";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga sutdenata";
            Load += frmPretragaIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSpol;
        private Label label2;
        private DateTimePicker dtpDatumOD;
        private Label label3;
        private DateTimePicker dtpDatumDO;
        private DataGridView dgvPretraga;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenje;
    }
}