namespace DLWMS.WinForms.ispitIB220116
{
    partial class frmStudentInfoIB220116
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
            lblStudent = new Label();
            pbSlikaStudenta = new PictureBox();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent.Location = new Point(12, 219);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(209, 52);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "STUDENT";
            lblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSlikaStudenta
            // 
            pbSlikaStudenta.Location = new Point(12, 12);
            pbSlikaStudenta.Name = "pbSlikaStudenta";
            pbSlikaStudenta.Size = new Size(209, 204);
            pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaStudenta.TabIndex = 1;
            pbSlikaStudenta.TabStop = false;
            // 
            // lblProsjek
            // 
            lblProsjek.Location = new Point(12, 259);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(209, 29);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "Prosjek:";
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 297);
            Controls.Add(lblProsjek);
            Controls.Add(pbSlikaStudenta);
            Controls.Add(lblStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentInfoIB220116";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStudentInfoIB220116";
            Load += frmStudentInfoIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStudent;
        private PictureBox pbSlikaStudenta;
        private Label lblProsjek;
    }
}