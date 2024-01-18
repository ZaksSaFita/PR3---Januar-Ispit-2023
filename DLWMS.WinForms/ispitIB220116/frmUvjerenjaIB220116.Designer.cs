namespace DLWMS.WinForms.ispitIB220116
{
    partial class frmUvjerenjaBrojIndeksa
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
            btnZahtjev = new Button();
            dgvUvjerenje = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            cmbVrsta = new ComboBox();
            txtSvrha = new TextBox();
            txtBroj = new TextBox();
            btnDodaj = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenje).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnZahtjev
            // 
            btnZahtjev.Location = new Point(565, 12);
            btnZahtjev.Name = "btnZahtjev";
            btnZahtjev.Size = new Size(119, 23);
            btnZahtjev.TabIndex = 0;
            btnZahtjev.Text = "Novi zahtjev";
            btnZahtjev.UseVisualStyleBackColor = true;
            btnZahtjev.Click += btnZahtjev_Click;
            // 
            // dgvUvjerenje
            // 
            dgvUvjerenje.AllowUserToAddRows = false;
            dgvUvjerenje.AllowUserToDeleteRows = false;
            dgvUvjerenje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenje.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenje.Location = new Point(12, 46);
            dgvUvjerenje.Name = "dgvUvjerenje";
            dgvUvjerenje.ReadOnly = true;
            dgvUvjerenje.RowTemplate.Height = 25;
            dgvUvjerenje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenje.Size = new Size(672, 149);
            dgvUvjerenje.TabIndex = 1;
            dgvUvjerenje.CellContentClick += dgvUvjerenje_CellContentClick;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 199);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanje uvjerenja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 97);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(658, 96);
            txtInfo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Info:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "", "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta", "Uvjerenje o godini studija" });
            cmbVrsta.Location = new Point(6, 53);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(189, 23);
            cmbVrsta.TabIndex = 6;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(201, 53);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(259, 23);
            txtSvrha.TabIndex = 5;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(466, 53);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(100, 23);
            txtBroj.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(572, 52);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(92, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 35);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 35);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUvjerenjaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 408);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenje);
            Controls.Add(btnZahtjev);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmUvjerenjaBrojIndeksa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmUvjerenjaBrojIndeksa";
            Load += frmUvjerenjaBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenje).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZahtjev;
        private DataGridView dgvUvjerenje;
        private GroupBox groupBox1;
        private TextBox txtSvrha;
        private TextBox txtBroj;
        private Button btnDodaj;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInfo;
        private Label label4;
        private ComboBox cmbVrsta;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private ErrorProvider errorProvider1;
    }
}