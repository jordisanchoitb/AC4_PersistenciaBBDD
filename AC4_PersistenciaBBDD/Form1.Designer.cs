using System.Xml.Linq;

namespace AC4_PersistenciaBBDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpBoxDades = new GroupBox();
            txtBoxTotal = new TextBox();
            lblTotal = new Label();
            txtBoxConsumDomestic = new TextBox();
            lblConsumDomestic = new Label();
            txtBoxActEconomiques = new TextBox();
            lblActEconomiques = new Label();
            txtBoxDomesticXarxa = new TextBox();
            lblDomesticXarxa = new Label();
            txtBoxPoblacio = new TextBox();
            lblPoblacio = new Label();
            cmbBoxComarca = new ComboBox();
            lblComarca = new Label();
            cmbBoxAny = new ComboBox();
            lblAny = new Label();
            grpBoxStats = new GroupBox();
            lblConsumDomesticBaixResult = new Label();
            lblConsumDomesticBaix = new Label();
            lblConsumDomesticAltResult = new Label();
            lblConsumDomesticAlt = new Label();
            lblConsumDomesticMitjaResult = new Label();
            lblConsumDomesticMitja = new Label();
            lblPoblacioResult = new Label();
            lblNamePoblacio = new Label();
            bttonSave = new Button();
            bttonClear = new Button();
            dgv_Comarcas = new DataGridView();
            comarcaBindingSource = new BindingSource(components);
            AnyProvider = new ErrorProvider(components);
            ComarcaProvider = new ErrorProvider(components);
            PoblacioProvider = new ErrorProvider(components);
            DomesticXarxaProvider = new ErrorProvider(components);
            ActEcoProvider = new ErrorProvider(components);
            ConsumDomesticProvider = new ErrorProvider(components);
            TotalProvider = new ErrorProvider(components);
            btnPaginaAnterior = new Button();
            btnPaginaSeguent = new Button();
            grpBoxDades.SuspendLayout();
            grpBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Comarcas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comarcaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnyProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComarcaProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PoblacioProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DomesticXarxaProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActEcoProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConsumDomesticProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalProvider).BeginInit();
            SuspendLayout();
            // 
            // grpBoxDades
            // 
            grpBoxDades.Controls.Add(txtBoxTotal);
            grpBoxDades.Controls.Add(lblTotal);
            grpBoxDades.Controls.Add(txtBoxConsumDomestic);
            grpBoxDades.Controls.Add(lblConsumDomestic);
            grpBoxDades.Controls.Add(txtBoxActEconomiques);
            grpBoxDades.Controls.Add(lblActEconomiques);
            grpBoxDades.Controls.Add(txtBoxDomesticXarxa);
            grpBoxDades.Controls.Add(lblDomesticXarxa);
            grpBoxDades.Controls.Add(txtBoxPoblacio);
            grpBoxDades.Controls.Add(lblPoblacio);
            grpBoxDades.Controls.Add(cmbBoxComarca);
            grpBoxDades.Controls.Add(lblComarca);
            grpBoxDades.Controls.Add(cmbBoxAny);
            grpBoxDades.Controls.Add(lblAny);
            grpBoxDades.Location = new Point(12, 36);
            grpBoxDades.Name = "grpBoxDades";
            grpBoxDades.Size = new Size(619, 188);
            grpBoxDades.TabIndex = 0;
            grpBoxDades.TabStop = false;
            grpBoxDades.Text = "Gestió de dades demogràfiques de regions";
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(461, 130);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(126, 23);
            txtBoxTotal.TabIndex = 13;
            txtBoxTotal.Validating += txtBoxTotal_Validating;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(352, 133);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // txtBoxConsumDomestic
            // 
            txtBoxConsumDomestic.Location = new Point(461, 92);
            txtBoxConsumDomestic.Name = "txtBoxConsumDomestic";
            txtBoxConsumDomestic.Size = new Size(126, 23);
            txtBoxConsumDomestic.TabIndex = 11;
            txtBoxConsumDomestic.Validating += txtBoxConsumDomestic_Validating;
            // 
            // lblConsumDomestic
            // 
            lblConsumDomestic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomestic.Location = new Point(352, 92);
            lblConsumDomestic.Name = "lblConsumDomestic";
            lblConsumDomestic.Size = new Size(112, 35);
            lblConsumDomestic.TabIndex = 10;
            lblConsumDomestic.Text = "Consum domèstic per càpita";
            // 
            // txtBoxActEconomiques
            // 
            txtBoxActEconomiques.Location = new Point(178, 141);
            txtBoxActEconomiques.Name = "txtBoxActEconomiques";
            txtBoxActEconomiques.Size = new Size(126, 23);
            txtBoxActEconomiques.TabIndex = 9;
            txtBoxActEconomiques.Validating += txtBoxActEconomiques_Validating;
            // 
            // lblActEconomiques
            // 
            lblActEconomiques.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActEconomiques.Location = new Point(178, 95);
            lblActEconomiques.Name = "lblActEconomiques";
            lblActEconomiques.Size = new Size(140, 32);
            lblActEconomiques.TabIndex = 8;
            lblActEconomiques.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // txtBoxDomesticXarxa
            // 
            txtBoxDomesticXarxa.Location = new Point(31, 141);
            txtBoxDomesticXarxa.Name = "txtBoxDomesticXarxa";
            txtBoxDomesticXarxa.Size = new Size(126, 23);
            txtBoxDomesticXarxa.TabIndex = 7;
            txtBoxDomesticXarxa.Validating += txtBoxDomesticXarxa_Validating;
            // 
            // lblDomesticXarxa
            // 
            lblDomesticXarxa.AutoSize = true;
            lblDomesticXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomesticXarxa.Location = new Point(31, 95);
            lblDomesticXarxa.Name = "lblDomesticXarxa";
            lblDomesticXarxa.Size = new Size(94, 15);
            lblDomesticXarxa.TabIndex = 6;
            lblDomesticXarxa.Text = "Domèstic xarxa";
            // 
            // txtBoxPoblacio
            // 
            txtBoxPoblacio.Location = new Point(302, 54);
            txtBoxPoblacio.Name = "txtBoxPoblacio";
            txtBoxPoblacio.Size = new Size(126, 23);
            txtBoxPoblacio.TabIndex = 5;
            txtBoxPoblacio.Validating += txtBoxPoblacio_Validating;
            // 
            // lblPoblacio
            // 
            lblPoblacio.AutoSize = true;
            lblPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoblacio.Location = new Point(302, 30);
            lblPoblacio.Name = "lblPoblacio";
            lblPoblacio.Size = new Size(53, 15);
            lblPoblacio.TabIndex = 4;
            lblPoblacio.Text = "Població";
            // 
            // cmbBoxComarca
            // 
            cmbBoxComarca.FormattingEnabled = true;
            cmbBoxComarca.Location = new Point(100, 54);
            cmbBoxComarca.Name = "cmbBoxComarca";
            cmbBoxComarca.Size = new Size(178, 23);
            cmbBoxComarca.TabIndex = 3;
            cmbBoxComarca.Validating += cmbBoxComarca_Validating;
            // 
            // lblComarca
            // 
            lblComarca.AutoSize = true;
            lblComarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComarca.Location = new Point(100, 30);
            lblComarca.Name = "lblComarca";
            lblComarca.Size = new Size(55, 15);
            lblComarca.TabIndex = 2;
            lblComarca.Text = "Comarca";
            // 
            // cmbBoxAny
            // 
            cmbBoxAny.FormattingEnabled = true;
            cmbBoxAny.Location = new Point(31, 54);
            cmbBoxAny.Name = "cmbBoxAny";
            cmbBoxAny.Size = new Size(52, 23);
            cmbBoxAny.TabIndex = 1;
            cmbBoxAny.Validating += cmbBoxAny_Validating;
            // 
            // lblAny
            // 
            lblAny.AutoSize = true;
            lblAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAny.Location = new Point(31, 30);
            lblAny.Name = "lblAny";
            lblAny.Size = new Size(28, 15);
            lblAny.TabIndex = 0;
            lblAny.Text = "Any";
            // 
            // grpBoxStats
            // 
            grpBoxStats.Controls.Add(lblConsumDomesticBaixResult);
            grpBoxStats.Controls.Add(lblConsumDomesticBaix);
            grpBoxStats.Controls.Add(lblConsumDomesticAltResult);
            grpBoxStats.Controls.Add(lblConsumDomesticAlt);
            grpBoxStats.Controls.Add(lblConsumDomesticMitjaResult);
            grpBoxStats.Controls.Add(lblConsumDomesticMitja);
            grpBoxStats.Controls.Add(lblPoblacioResult);
            grpBoxStats.Controls.Add(lblNamePoblacio);
            grpBoxStats.Location = new Point(637, 36);
            grpBoxStats.Name = "grpBoxStats";
            grpBoxStats.Size = new Size(287, 141);
            grpBoxStats.TabIndex = 1;
            grpBoxStats.TabStop = false;
            grpBoxStats.Text = "Estadístiques";
            // 
            // lblConsumDomesticBaixResult
            // 
            lblConsumDomesticBaixResult.AutoSize = true;
            lblConsumDomesticBaixResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticBaixResult.ForeColor = SystemColors.HotTrack;
            lblConsumDomesticBaixResult.Location = new Point(236, 112);
            lblConsumDomesticBaixResult.Name = "lblConsumDomesticBaixResult";
            lblConsumDomesticBaixResult.Size = new Size(29, 15);
            lblConsumDomesticBaixResult.TabIndex = 21;
            lblConsumDomesticBaixResult.Text = "N/A";
            // 
            // lblConsumDomesticBaix
            // 
            lblConsumDomesticBaix.AutoSize = true;
            lblConsumDomesticBaix.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticBaix.Location = new Point(15, 112);
            lblConsumDomesticBaix.Name = "lblConsumDomesticBaix";
            lblConsumDomesticBaix.Size = new Size(218, 15);
            lblConsumDomesticBaix.TabIndex = 20;
            lblConsumDomesticBaix.Text = "Consum domèstic per càpita més baix:";
            // 
            // lblConsumDomesticAltResult
            // 
            lblConsumDomesticAltResult.AutoSize = true;
            lblConsumDomesticAltResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticAltResult.ForeColor = SystemColors.HotTrack;
            lblConsumDomesticAltResult.Location = new Point(236, 83);
            lblConsumDomesticAltResult.Name = "lblConsumDomesticAltResult";
            lblConsumDomesticAltResult.Size = new Size(29, 15);
            lblConsumDomesticAltResult.TabIndex = 19;
            lblConsumDomesticAltResult.Text = "N/A";
            // 
            // lblConsumDomesticAlt
            // 
            lblConsumDomesticAlt.AutoSize = true;
            lblConsumDomesticAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticAlt.Location = new Point(15, 83);
            lblConsumDomesticAlt.Name = "lblConsumDomesticAlt";
            lblConsumDomesticAlt.Size = new Size(209, 15);
            lblConsumDomesticAlt.TabIndex = 18;
            lblConsumDomesticAlt.Text = "Consum domèstic per càpita més alt:";
            // 
            // lblConsumDomesticMitjaResult
            // 
            lblConsumDomesticMitjaResult.AutoSize = true;
            lblConsumDomesticMitjaResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticMitjaResult.ForeColor = SystemColors.HotTrack;
            lblConsumDomesticMitjaResult.Location = new Point(166, 57);
            lblConsumDomesticMitjaResult.Name = "lblConsumDomesticMitjaResult";
            lblConsumDomesticMitjaResult.Size = new Size(29, 15);
            lblConsumDomesticMitjaResult.TabIndex = 17;
            lblConsumDomesticMitjaResult.Text = "N/A";
            // 
            // lblConsumDomesticMitja
            // 
            lblConsumDomesticMitja.AutoSize = true;
            lblConsumDomesticMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumDomesticMitja.Location = new Point(15, 57);
            lblConsumDomesticMitja.Name = "lblConsumDomesticMitja";
            lblConsumDomesticMitja.Size = new Size(139, 15);
            lblConsumDomesticMitja.TabIndex = 16;
            lblConsumDomesticMitja.Text = "Consum domèstic mitjà:";
            // 
            // lblPoblacioResult
            // 
            lblPoblacioResult.AutoSize = true;
            lblPoblacioResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoblacioResult.ForeColor = SystemColors.HotTrack;
            lblPoblacioResult.Location = new Point(166, 30);
            lblPoblacioResult.Name = "lblPoblacioResult";
            lblPoblacioResult.Size = new Size(29, 15);
            lblPoblacioResult.TabIndex = 15;
            lblPoblacioResult.Text = "N/A";
            // 
            // lblNamePoblacio
            // 
            lblNamePoblacio.AutoSize = true;
            lblNamePoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePoblacio.Location = new Point(15, 30);
            lblNamePoblacio.Name = "lblNamePoblacio";
            lblNamePoblacio.Size = new Size(131, 15);
            lblNamePoblacio.TabIndex = 14;
            lblNamePoblacio.Text = "Població > 20000 hab.:";
            // 
            // bttonSave
            // 
            bttonSave.Location = new Point(530, 230);
            bttonSave.Name = "bttonSave";
            bttonSave.Size = new Size(84, 28);
            bttonSave.TabIndex = 2;
            bttonSave.Text = "Guardar";
            bttonSave.UseVisualStyleBackColor = true;
            bttonSave.Click += bttonSave_Click;
            // 
            // bttonClear
            // 
            bttonClear.Location = new Point(430, 230);
            bttonClear.Name = "bttonClear";
            bttonClear.Size = new Size(84, 28);
            bttonClear.TabIndex = 3;
            bttonClear.Text = "Netejar";
            bttonClear.UseVisualStyleBackColor = true;
            bttonClear.Click += bttonClear_Click;
            // 
            // dgv_Comarcas
            // 
            dgv_Comarcas.AllowUserToAddRows = false;
            dgv_Comarcas.AllowUserToDeleteRows = false;
            dgv_Comarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Comarcas.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_Comarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Comarcas.Location = new Point(12, 299);
            dgv_Comarcas.Name = "dgv_Comarcas";
            dgv_Comarcas.ReadOnly = true;
            dgv_Comarcas.Size = new Size(912, 274);
            dgv_Comarcas.TabIndex = 4;
            dgv_Comarcas.CellClick += dgv_Comarcas_CellClick;
            // 
            // comarcaBindingSource
            // 
            comarcaBindingSource.DataSource = typeof(Comarca);
            // 
            // AnyProvider
            // 
            AnyProvider.ContainerControl = this;
            // 
            // ComarcaProvider
            // 
            ComarcaProvider.ContainerControl = this;
            // 
            // PoblacioProvider
            // 
            PoblacioProvider.ContainerControl = this;
            // 
            // DomesticXarxaProvider
            // 
            DomesticXarxaProvider.ContainerControl = this;
            // 
            // ActEcoProvider
            // 
            ActEcoProvider.ContainerControl = this;
            // 
            // ConsumDomesticProvider
            // 
            ConsumDomesticProvider.ContainerControl = this;
            // 
            // TotalProvider
            // 
            TotalProvider.ContainerControl = this;
            // 
            // btnPaginaAnterior
            // 
            btnPaginaAnterior.Location = new Point(395, 274);
            btnPaginaAnterior.Name = "btnPaginaAnterior";
            btnPaginaAnterior.Size = new Size(45, 23);
            btnPaginaAnterior.TabIndex = 5;
            btnPaginaAnterior.Text = "<--";
            btnPaginaAnterior.UseVisualStyleBackColor = true;
            btnPaginaAnterior.Click += btnPaginaAnterior_Click;
            // 
            // btnPaginaSeguent
            // 
            btnPaginaSeguent.Location = new Point(446, 274);
            btnPaginaSeguent.Name = "btnPaginaSeguent";
            btnPaginaSeguent.Size = new Size(45, 23);
            btnPaginaSeguent.TabIndex = 6;
            btnPaginaSeguent.Text = "-->";
            btnPaginaSeguent.UseVisualStyleBackColor = true;
            btnPaginaSeguent.Click += btnPaginaSeguent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(935, 583);
            Controls.Add(btnPaginaSeguent);
            Controls.Add(btnPaginaAnterior);
            Controls.Add(dgv_Comarcas);
            Controls.Add(bttonClear);
            Controls.Add(bttonSave);
            Controls.Add(grpBoxStats);
            Controls.Add(grpBoxDades);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            grpBoxDades.ResumeLayout(false);
            grpBoxDades.PerformLayout();
            grpBoxStats.ResumeLayout(false);
            grpBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Comarcas).EndInit();
            ((System.ComponentModel.ISupportInitialize)comarcaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnyProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComarcaProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PoblacioProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DomesticXarxaProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActEcoProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConsumDomesticProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxDades;
        private Label lblAny;
        private GroupBox grpBoxStats;
        private ComboBox cmbBoxAny;
        private TextBox txtBoxPoblacio;
        private Label lblPoblacio;
        private ComboBox cmbBoxComarca;
        private Label lblComarca;
        private TextBox txtBoxConsumDomestic;
        private Label lblConsumDomestic;
        private TextBox txtBoxActEconomiques;
        private Label lblActEconomiques;
        private TextBox txtBoxDomesticXarxa;
        private Label lblDomesticXarxa;
        private TextBox txtBoxTotal;
        private Label lblTotal;
        private Label lblPoblacioResult;
        private Label lblNamePoblacio;
        private Label lblConsumDomesticBaixResult;
        private Label lblConsumDomesticBaix;
        private Label lblConsumDomesticAltResult;
        private Label lblConsumDomesticAlt;
        private Label lblConsumDomesticMitjaResult;
        private Label lblConsumDomesticMitja;
        private Button bttonSave;
        private Button bttonClear;
        private DataGridView dgv_Comarcas;
        private BindingSource comarcaBindingSource;
        private ErrorProvider AnyProvider;
        private ErrorProvider ComarcaProvider;
        private ErrorProvider PoblacioProvider;
        private ErrorProvider DomesticXarxaProvider;
        private ErrorProvider ActEcoProvider;
        private ErrorProvider ConsumDomesticProvider;
        private ErrorProvider TotalProvider;
        private Button btnPaginaSeguent;
        private Button btnPaginaAnterior;
    }
}
