namespace Campionamento
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCampionamento = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.grpMainTab = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadFromCSV = new System.Windows.Forms.Button();
            this.btnLoadFromDB = new System.Windows.Forms.Button();
            this.btnLoadFromXls = new System.Windows.Forms.Button();
            this.dgvMain = new myGrid.myGrid();
            this.tabEstrazioni = new System.Windows.Forms.TabPage();
            this.grpEstrazioni = new System.Windows.Forms.GroupBox();
            this.btnMostraEstrazioniDati = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDataEstrazioni = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEstrazione = new RegexTextBox.RegexTextBox();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.rdbNoReimmissione = new System.Windows.Forms.RadioButton();
            this.rdbReimmissione = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstrazioni = new myGrid.myGrid();
            this.tabEstrazioniMultiple = new System.Windows.Forms.TabPage();
            this.grpEstrazioniMultiple = new System.Windows.Forms.GroupBox();
            this.btnMostraDati = new System.Windows.Forms.Button();
            this.cmbSceltaColonna = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSceltaNumeroEstrazione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpEstrazioneMultipla = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEstrazioneMultipla = new System.Windows.Forms.Button();
            this.rdbEstrazioniMultipleNoReimmissione = new System.Windows.Forms.RadioButton();
            this.rdbReimmissioneEstrazioneMultiple = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEstrazioniMultiple = new myGrid.myGrid();
            this.tabClassi = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.myGrid1 = new myGrid.myGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvClassiPopolazione = new myGrid.myGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScegliColonnaClassiPopolazioneOk = new System.Windows.Forms.Button();
            this.cmbScegliColonnaPopolazione = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNClassi = new RegexTextBox.RegexTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXMax = new RegexTextBox.RegexTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXMin = new RegexTextBox.RegexTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tmrControl = new System.Windows.Forms.Timer(this.components);
            this.txtPopolazioneEstrazioniMultiple = new RegexTextBox.RegexTextBox();
            this.txtNumeroGruppi = new RegexTextBox.RegexTextBox();
            this.tabCampionamento.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.grpMainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tabEstrazioni.SuspendLayout();
            this.grpEstrazioni.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrazioni)).BeginInit();
            this.tabEstrazioniMultiple.SuspendLayout();
            this.grpEstrazioniMultiple.SuspendLayout();
            this.grpEstrazioneMultipla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrazioniMultiple)).BeginInit();
            this.tabClassi.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassiPopolazione)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCampionamento
            // 
            this.tabCampionamento.Controls.Add(this.tabMain);
            this.tabCampionamento.Controls.Add(this.tabEstrazioni);
            this.tabCampionamento.Controls.Add(this.tabEstrazioniMultiple);
            this.tabCampionamento.Controls.Add(this.tabClassi);
            this.tabCampionamento.Location = new System.Drawing.Point(3, 3);
            this.tabCampionamento.Name = "tabCampionamento";
            this.tabCampionamento.SelectedIndex = 0;
            this.tabCampionamento.Size = new System.Drawing.Size(470, 388);
            this.tabCampionamento.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.grpMainTab);
            this.tabMain.Controls.Add(this.groupBox1);
            this.tabMain.Controls.Add(this.dgvMain);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(462, 362);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main Grid";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // grpMainTab
            // 
            this.grpMainTab.Controls.Add(this.btnView);
            this.grpMainTab.Controls.Add(this.label1);
            this.grpMainTab.Controls.Add(this.cmbShow);
            this.grpMainTab.Location = new System.Drawing.Point(274, 256);
            this.grpMainTab.Name = "grpMainTab";
            this.grpMainTab.Size = new System.Drawing.Size(182, 100);
            this.grpMainTab.TabIndex = 6;
            this.grpMainTab.TabStop = false;
            this.grpMainTab.Text = "Show data";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(32, 71);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(114, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose column";
            // 
            // cmbShow
            // 
            this.cmbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Location = new System.Drawing.Point(6, 37);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(170, 21);
            this.cmbShow.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadFromCSV);
            this.groupBox1.Controls.Add(this.btnLoadFromDB);
            this.groupBox1.Controls.Add(this.btnLoadFromXls);
            this.groupBox1.Location = new System.Drawing.Point(274, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load";
            // 
            // btnLoadFromCSV
            // 
            this.btnLoadFromCSV.Location = new System.Drawing.Point(19, 19);
            this.btnLoadFromCSV.Name = "btnLoadFromCSV";
            this.btnLoadFromCSV.Size = new System.Drawing.Size(140, 23);
            this.btnLoadFromCSV.TabIndex = 1;
            this.btnLoadFromCSV.Text = "Load from csv";
            this.btnLoadFromCSV.UseVisualStyleBackColor = true;
            this.btnLoadFromCSV.Click += new System.EventHandler(this.btnLoadFromCSV_Click);
            // 
            // btnLoadFromDB
            // 
            this.btnLoadFromDB.Location = new System.Drawing.Point(19, 48);
            this.btnLoadFromDB.Name = "btnLoadFromDB";
            this.btnLoadFromDB.Size = new System.Drawing.Size(140, 23);
            this.btnLoadFromDB.TabIndex = 2;
            this.btnLoadFromDB.Text = "Load from db";
            this.btnLoadFromDB.UseVisualStyleBackColor = true;
            this.btnLoadFromDB.Click += new System.EventHandler(this.btnLoadFromDB_Click);
            // 
            // btnLoadFromXls
            // 
            this.btnLoadFromXls.Location = new System.Drawing.Point(19, 77);
            this.btnLoadFromXls.Name = "btnLoadFromXls";
            this.btnLoadFromXls.Size = new System.Drawing.Size(140, 23);
            this.btnLoadFromXls.TabIndex = 3;
            this.btnLoadFromXls.Text = "Load from xls";
            this.btnLoadFromXls.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(5, 6);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(263, 350);
            this.dgvMain.TabIndex = 0;
            // 
            // tabEstrazioni
            // 
            this.tabEstrazioni.Controls.Add(this.grpEstrazioni);
            this.tabEstrazioni.Controls.Add(this.groupBox3);
            this.tabEstrazioni.Controls.Add(this.dgvEstrazioni);
            this.tabEstrazioni.Location = new System.Drawing.Point(4, 22);
            this.tabEstrazioni.Name = "tabEstrazioni";
            this.tabEstrazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstrazioni.Size = new System.Drawing.Size(462, 362);
            this.tabEstrazioni.TabIndex = 1;
            this.tabEstrazioni.Text = "Estrazioni";
            this.tabEstrazioni.UseVisualStyleBackColor = true;
            // 
            // grpEstrazioni
            // 
            this.grpEstrazioni.Controls.Add(this.btnMostraEstrazioniDati);
            this.grpEstrazioni.Controls.Add(this.label3);
            this.grpEstrazioni.Controls.Add(this.cmbDataEstrazioni);
            this.grpEstrazioni.Location = new System.Drawing.Point(259, 189);
            this.grpEstrazioni.Name = "grpEstrazioni";
            this.grpEstrazioni.Size = new System.Drawing.Size(197, 100);
            this.grpEstrazioni.TabIndex = 7;
            this.grpEstrazioni.TabStop = false;
            this.grpEstrazioni.Text = "Show data";
            // 
            // btnMostraEstrazioniDati
            // 
            this.btnMostraEstrazioniDati.Location = new System.Drawing.Point(36, 71);
            this.btnMostraEstrazioniDati.Name = "btnMostraEstrazioniDati";
            this.btnMostraEstrazioniDati.Size = new System.Drawing.Size(114, 23);
            this.btnMostraEstrazioniDati.TabIndex = 6;
            this.btnMostraEstrazioniDati.Text = "View";
            this.btnMostraEstrazioniDati.UseVisualStyleBackColor = true;
            this.btnMostraEstrazioniDati.Click += new System.EventHandler(this.btnMostraEstrazioniDati_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose column";
            // 
            // cmbDataEstrazioni
            // 
            this.cmbDataEstrazioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataEstrazioni.FormattingEnabled = true;
            this.cmbDataEstrazioni.Location = new System.Drawing.Point(9, 37);
            this.cmbDataEstrazioni.Name = "cmbDataEstrazioni";
            this.cmbDataEstrazioni.Size = new System.Drawing.Size(170, 21);
            this.cmbDataEstrazioni.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEstrazione);
            this.groupBox3.Controls.Add(this.btnEstrai);
            this.groupBox3.Controls.Add(this.rdbNoReimmissione);
            this.groupBox3.Controls.Add(this.rdbReimmissione);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(259, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estrazione";
            // 
            // txtEstrazione
            // 
            this.txtEstrazione.CheckTextBox = true;
            this.txtEstrazione.Location = new System.Drawing.Point(76, 28);
            this.txtEstrazione.Name = "txtEstrazione";
            this.txtEstrazione.Pattern = "^[0-9]{0,}$";
            this.txtEstrazione.Size = new System.Drawing.Size(103, 20);
            this.txtEstrazione.TabIndex = 5;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(52, 122);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(88, 20);
            this.btnEstrai.TabIndex = 4;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // rdbNoReimmissione
            // 
            this.rdbNoReimmissione.AutoSize = true;
            this.rdbNoReimmissione.Location = new System.Drawing.Point(9, 87);
            this.rdbNoReimmissione.Name = "rdbNoReimmissione";
            this.rdbNoReimmissione.Size = new System.Drawing.Size(167, 17);
            this.rdbNoReimmissione.TabIndex = 3;
            this.rdbNoReimmissione.TabStop = true;
            this.rdbNoReimmissione.Text = "Estrazione senza reimmissione";
            this.rdbNoReimmissione.UseVisualStyleBackColor = true;
            // 
            // rdbReimmissione
            // 
            this.rdbReimmissione.AutoSize = true;
            this.rdbReimmissione.Location = new System.Drawing.Point(9, 64);
            this.rdbReimmissione.Name = "rdbReimmissione";
            this.rdbReimmissione.Size = new System.Drawing.Size(157, 17);
            this.rdbReimmissione.TabIndex = 2;
            this.rdbReimmissione.TabStop = true;
            this.rdbReimmissione.Text = "Estrazione con reimmissione";
            this.rdbReimmissione.UseVisualStyleBackColor = true;
            this.rdbReimmissione.CheckedChanged += new System.EventHandler(this.rdbReimmissione_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Popolazione";
            // 
            // dgvEstrazioni
            // 
            this.dgvEstrazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstrazioni.Location = new System.Drawing.Point(6, 6);
            this.dgvEstrazioni.Name = "dgvEstrazioni";
            this.dgvEstrazioni.ReadOnly = true;
            this.dgvEstrazioni.Size = new System.Drawing.Size(240, 350);
            this.dgvEstrazioni.TabIndex = 2;
            // 
            // tabEstrazioniMultiple
            // 
            this.tabEstrazioniMultiple.Controls.Add(this.grpEstrazioniMultiple);
            this.tabEstrazioniMultiple.Controls.Add(this.grpEstrazioneMultipla);
            this.tabEstrazioniMultiple.Controls.Add(this.dgvEstrazioniMultiple);
            this.tabEstrazioniMultiple.Location = new System.Drawing.Point(4, 22);
            this.tabEstrazioniMultiple.Name = "tabEstrazioniMultiple";
            this.tabEstrazioniMultiple.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstrazioniMultiple.Size = new System.Drawing.Size(462, 362);
            this.tabEstrazioniMultiple.TabIndex = 2;
            this.tabEstrazioniMultiple.Text = "Estrazioni multiple";
            this.tabEstrazioniMultiple.UseVisualStyleBackColor = true;
            // 
            // grpEstrazioniMultiple
            // 
            this.grpEstrazioniMultiple.Controls.Add(this.btnMostraDati);
            this.grpEstrazioniMultiple.Controls.Add(this.cmbSceltaColonna);
            this.grpEstrazioniMultiple.Controls.Add(this.label7);
            this.grpEstrazioniMultiple.Controls.Add(this.cmbSceltaNumeroEstrazione);
            this.grpEstrazioniMultiple.Controls.Add(this.label6);
            this.grpEstrazioniMultiple.Location = new System.Drawing.Point(252, 175);
            this.grpEstrazioniMultiple.Name = "grpEstrazioniMultiple";
            this.grpEstrazioniMultiple.Size = new System.Drawing.Size(200, 181);
            this.grpEstrazioniMultiple.TabIndex = 5;
            this.grpEstrazioniMultiple.TabStop = false;
            this.grpEstrazioniMultiple.Text = "Valori Estrazioni Multiple";
            // 
            // btnMostraDati
            // 
            this.btnMostraDati.Location = new System.Drawing.Point(39, 141);
            this.btnMostraDati.Name = "btnMostraDati";
            this.btnMostraDati.Size = new System.Drawing.Size(75, 23);
            this.btnMostraDati.TabIndex = 4;
            this.btnMostraDati.Text = "Mostra";
            this.btnMostraDati.UseVisualStyleBackColor = true;
            this.btnMostraDati.Click += new System.EventHandler(this.btnMostraDati_Click);
            // 
            // cmbSceltaColonna
            // 
            this.cmbSceltaColonna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSceltaColonna.FormattingEnabled = true;
            this.cmbSceltaColonna.Location = new System.Drawing.Point(12, 102);
            this.cmbSceltaColonna.Name = "cmbSceltaColonna";
            this.cmbSceltaColonna.Size = new System.Drawing.Size(134, 21);
            this.cmbSceltaColonna.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Scegliere colonna";
            // 
            // cmbSceltaNumeroEstrazione
            // 
            this.cmbSceltaNumeroEstrazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSceltaNumeroEstrazione.FormattingEnabled = true;
            this.cmbSceltaNumeroEstrazione.Location = new System.Drawing.Point(9, 50);
            this.cmbSceltaNumeroEstrazione.Name = "cmbSceltaNumeroEstrazione";
            this.cmbSceltaNumeroEstrazione.Size = new System.Drawing.Size(134, 21);
            this.cmbSceltaNumeroEstrazione.TabIndex = 1;
            this.cmbSceltaNumeroEstrazione.SelectedIndexChanged += new System.EventHandler(this.cmbSceltaNumeroEstrazione_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Secgliere Numero Estrazione";
            // 
            // grpEstrazioneMultipla
            // 
            this.grpEstrazioneMultipla.Controls.Add(this.txtNumeroGruppi);
            this.grpEstrazioneMultipla.Controls.Add(this.txtPopolazioneEstrazioniMultiple);
            this.grpEstrazioneMultipla.Controls.Add(this.label5);
            this.grpEstrazioneMultipla.Controls.Add(this.btnEstrazioneMultipla);
            this.grpEstrazioneMultipla.Controls.Add(this.rdbEstrazioniMultipleNoReimmissione);
            this.grpEstrazioneMultipla.Controls.Add(this.rdbReimmissioneEstrazioneMultiple);
            this.grpEstrazioneMultipla.Controls.Add(this.label4);
            this.grpEstrazioneMultipla.Location = new System.Drawing.Point(252, 6);
            this.grpEstrazioneMultipla.Name = "grpEstrazioneMultipla";
            this.grpEstrazioneMultipla.Size = new System.Drawing.Size(200, 163);
            this.grpEstrazioneMultipla.TabIndex = 4;
            this.grpEstrazioneMultipla.TabStop = false;
            this.grpEstrazioneMultipla.Text = "Estrazione multipla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Num gruppi";
            // 
            // btnEstrazioneMultipla
            // 
            this.btnEstrazioneMultipla.Location = new System.Drawing.Point(55, 137);
            this.btnEstrazioneMultipla.Name = "btnEstrazioneMultipla";
            this.btnEstrazioneMultipla.Size = new System.Drawing.Size(91, 20);
            this.btnEstrazioneMultipla.TabIndex = 4;
            this.btnEstrazioneMultipla.Text = "Estrai";
            this.btnEstrazioneMultipla.UseVisualStyleBackColor = true;
            this.btnEstrazioneMultipla.Click += new System.EventHandler(this.btnEstrazioneMultipla_Click);
            // 
            // rdbEstrazioniMultipleNoReimmissione
            // 
            this.rdbEstrazioniMultipleNoReimmissione.AutoSize = true;
            this.rdbEstrazioniMultipleNoReimmissione.Location = new System.Drawing.Point(9, 104);
            this.rdbEstrazioniMultipleNoReimmissione.Name = "rdbEstrazioniMultipleNoReimmissione";
            this.rdbEstrazioniMultipleNoReimmissione.Size = new System.Drawing.Size(167, 17);
            this.rdbEstrazioniMultipleNoReimmissione.TabIndex = 3;
            this.rdbEstrazioniMultipleNoReimmissione.TabStop = true;
            this.rdbEstrazioniMultipleNoReimmissione.Text = "Estrazione senza reimmissione";
            this.rdbEstrazioniMultipleNoReimmissione.UseVisualStyleBackColor = true;
            // 
            // rdbReimmissioneEstrazioneMultiple
            // 
            this.rdbReimmissioneEstrazioneMultiple.AutoSize = true;
            this.rdbReimmissioneEstrazioneMultiple.Location = new System.Drawing.Point(9, 81);
            this.rdbReimmissioneEstrazioneMultiple.Name = "rdbReimmissioneEstrazioneMultiple";
            this.rdbReimmissioneEstrazioneMultiple.Size = new System.Drawing.Size(157, 17);
            this.rdbReimmissioneEstrazioneMultiple.TabIndex = 2;
            this.rdbReimmissioneEstrazioneMultiple.TabStop = true;
            this.rdbReimmissioneEstrazioneMultiple.Text = "Estrazione con reimmissione";
            this.rdbReimmissioneEstrazioneMultiple.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Popolazione";
            // 
            // dgvEstrazioniMultiple
            // 
            this.dgvEstrazioniMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstrazioniMultiple.Location = new System.Drawing.Point(6, 6);
            this.dgvEstrazioniMultiple.Name = "dgvEstrazioniMultiple";
            this.dgvEstrazioniMultiple.ReadOnly = true;
            this.dgvEstrazioniMultiple.Size = new System.Drawing.Size(240, 350);
            this.dgvEstrazioniMultiple.TabIndex = 3;
            // 
            // tabClassi
            // 
            this.tabClassi.Controls.Add(this.groupBox5);
            this.tabClassi.Controls.Add(this.groupBox4);
            this.tabClassi.Controls.Add(this.groupBox2);
            this.tabClassi.Location = new System.Drawing.Point(4, 22);
            this.tabClassi.Name = "tabClassi";
            this.tabClassi.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassi.Size = new System.Drawing.Size(462, 362);
            this.tabClassi.TabIndex = 3;
            this.tabClassi.Text = "Classi";
            this.tabClassi.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.myGrid1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(245, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 288);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Classi estrazioni multiple";
            // 
            // myGrid1
            // 
            this.myGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.myGrid1.Location = new System.Drawing.Point(6, 84);
            this.myGrid1.Name = "myGrid1";
            this.myGrid1.ReadOnly = true;
            this.myGrid1.Size = new System.Drawing.Size(193, 198);
            this.myGrid1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Min";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Max";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Frequenza";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Scegli colonna";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvClassiPopolazione);
            this.groupBox4.Controls.Add(this.btnScegliColonnaClassiPopolazioneOk);
            this.groupBox4.Controls.Add(this.cmbScegliColonnaPopolazione);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 288);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classi popolazione";
            // 
            // dgvClassiPopolazione
            // 
            this.dgvClassiPopolazione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassiPopolazione.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvClassiPopolazione.Location = new System.Drawing.Point(6, 84);
            this.dgvClassiPopolazione.Name = "dgvClassiPopolazione";
            this.dgvClassiPopolazione.ReadOnly = true;
            this.dgvClassiPopolazione.Size = new System.Drawing.Size(193, 198);
            this.dgvClassiPopolazione.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Min";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Max";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Frequenza";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnScegliColonnaClassiPopolazioneOk
            // 
            this.btnScegliColonnaClassiPopolazioneOk.Location = new System.Drawing.Point(84, 55);
            this.btnScegliColonnaClassiPopolazioneOk.Name = "btnScegliColonnaClassiPopolazioneOk";
            this.btnScegliColonnaClassiPopolazioneOk.Size = new System.Drawing.Size(115, 23);
            this.btnScegliColonnaClassiPopolazioneOk.TabIndex = 2;
            this.btnScegliColonnaClassiPopolazioneOk.Text = "Ok";
            this.btnScegliColonnaClassiPopolazioneOk.UseVisualStyleBackColor = true;
            this.btnScegliColonnaClassiPopolazioneOk.Click += new System.EventHandler(this.btnScegliColonnaClassiPopolazioneOk_Click);
            // 
            // cmbScegliColonnaPopolazione
            // 
            this.cmbScegliColonnaPopolazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScegliColonnaPopolazione.FormattingEnabled = true;
            this.cmbScegliColonnaPopolazione.Location = new System.Drawing.Point(84, 23);
            this.cmbScegliColonnaPopolazione.Name = "cmbScegliColonnaPopolazione";
            this.cmbScegliColonnaPopolazione.Size = new System.Drawing.Size(115, 21);
            this.cmbScegliColonnaPopolazione.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Scegli colonna";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNClassi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtXMax);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtXMin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Divisione in classi";
            // 
            // txtNClassi
            // 
            this.txtNClassi.CheckTextBox = true;
            this.txtNClassi.Location = new System.Drawing.Point(344, 22);
            this.txtNClassi.Name = "txtNClassi";
            this.txtNClassi.Pattern = "^[0-9]{0,}$";
            this.txtNClassi.Size = new System.Drawing.Size(100, 20);
            this.txtNClassi.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Num classi";
            // 
            // txtXMax
            // 
            this.txtXMax.CheckTextBox = true;
            this.txtXMax.Location = new System.Drawing.Point(170, 22);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Pattern = "^[0-9]{0,}$";
            this.txtXMax.Size = new System.Drawing.Size(100, 20);
            this.txtXMax.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Max";
            // 
            // txtXMin
            // 
            this.txtXMin.CheckTextBox = true;
            this.txtXMin.Location = new System.Drawing.Point(36, 22);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Pattern = "^[0-9]{0,}$";
            this.txtXMin.Size = new System.Drawing.Size(100, 20);
            this.txtXMin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Min";
            // 
            // tmrControl
            // 
            this.tmrControl.Tick += new System.EventHandler(this.tmrControl_Tick);
            // 
            // txtPopolazioneEstrazioniMultiple
            // 
            this.txtPopolazioneEstrazioniMultiple.CheckTextBox = true;
            this.txtPopolazioneEstrazioniMultiple.Location = new System.Drawing.Point(77, 28);
            this.txtPopolazioneEstrazioniMultiple.Name = "txtPopolazioneEstrazioniMultiple";
            this.txtPopolazioneEstrazioniMultiple.Pattern = "^[0-9]{0,}$";
            this.txtPopolazioneEstrazioniMultiple.Size = new System.Drawing.Size(117, 20);
            this.txtPopolazioneEstrazioniMultiple.TabIndex = 7;
            // 
            // txtNumeroGruppi
            // 
            this.txtNumeroGruppi.CheckTextBox = true;
            this.txtNumeroGruppi.Location = new System.Drawing.Point(76, 59);
            this.txtNumeroGruppi.Name = "txtNumeroGruppi";
            this.txtNumeroGruppi.Pattern = "^[0-9]{0,}$";
            this.txtNumeroGruppi.Size = new System.Drawing.Size(118, 20);
            this.txtNumeroGruppi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 393);
            this.Controls.Add(this.tabCampionamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCampionamento.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.grpMainTab.ResumeLayout(false);
            this.grpMainTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tabEstrazioni.ResumeLayout(false);
            this.grpEstrazioni.ResumeLayout(false);
            this.grpEstrazioni.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrazioni)).EndInit();
            this.tabEstrazioniMultiple.ResumeLayout(false);
            this.grpEstrazioniMultiple.ResumeLayout(false);
            this.grpEstrazioniMultiple.PerformLayout();
            this.grpEstrazioneMultipla.ResumeLayout(false);
            this.grpEstrazioneMultipla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrazioniMultiple)).EndInit();
            this.tabClassi.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassiPopolazione)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCampionamento;
        private System.Windows.Forms.TabPage tabMain;
        private myGrid.myGrid dgvMain;
        private System.Windows.Forms.TabPage tabEstrazioni;
        private System.Windows.Forms.GroupBox grpMainTab;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFromCSV;
        private System.Windows.Forms.Button btnLoadFromDB;
        private System.Windows.Forms.Button btnLoadFromXls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbNoReimmissione;
        private System.Windows.Forms.RadioButton rdbReimmissione;
        private System.Windows.Forms.Button btnEstrai;
        private myGrid.myGrid dgvEstrazioni;
        private System.Windows.Forms.GroupBox grpEstrazioni;
        private System.Windows.Forms.Button btnMostraEstrazioniDati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDataEstrazioni;
        private System.Windows.Forms.TabPage tabEstrazioniMultiple;
        private System.Windows.Forms.Timer tmrControl;
        private System.Windows.Forms.GroupBox grpEstrazioneMultipla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEstrazioneMultipla;
        private System.Windows.Forms.RadioButton rdbEstrazioniMultipleNoReimmissione;
        private System.Windows.Forms.RadioButton rdbReimmissioneEstrazioneMultiple;
        private System.Windows.Forms.Label label4;
        private myGrid.myGrid dgvEstrazioniMultiple;
        private System.Windows.Forms.GroupBox grpEstrazioniMultiple;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostraDati;
        private System.Windows.Forms.ComboBox cmbSceltaColonna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSceltaNumeroEstrazione;
        private System.Windows.Forms.TabPage tabClassi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private RegexTextBox.RegexTextBox txtNClassi;
        private System.Windows.Forms.Label label10;
        private RegexTextBox.RegexTextBox txtXMax;
        private System.Windows.Forms.Label label9;
        private RegexTextBox.RegexTextBox txtXMin;
        private System.Windows.Forms.GroupBox groupBox4;
        private myGrid.myGrid dgvClassiPopolazione;
        private System.Windows.Forms.Button btnScegliColonnaClassiPopolazioneOk;
        private System.Windows.Forms.ComboBox cmbScegliColonnaPopolazione;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox5;
        private myGrid.myGrid myGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private RegexTextBox.RegexTextBox txtEstrazione;
        private RegexTextBox.RegexTextBox txtNumeroGruppi;
        private RegexTextBox.RegexTextBox txtPopolazioneEstrazioniMultiple;
    }
}

