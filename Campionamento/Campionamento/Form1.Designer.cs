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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadFromCSV = new System.Windows.Forms.Button();
            this.btnLoadFromDB = new System.Windows.Forms.Button();
            this.btnLoadFromXls = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMain = new myGrid.myGrid();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBox2);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnView);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbShow);
            this.groupBox2.Location = new System.Drawing.Point(274, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show data";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(5, 6);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(263, 350);
            this.dgvMain.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private myGrid.myGrid dgvMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFromCSV;
        private System.Windows.Forms.Button btnLoadFromDB;
        private System.Windows.Forms.Button btnLoadFromXls;
    }
}

