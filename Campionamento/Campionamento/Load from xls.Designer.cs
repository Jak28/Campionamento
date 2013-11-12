namespace Campionamento
{
    partial class Load_from_xls
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilenameXls = new System.Windows.Forms.TextBox();
            this.btnLoadXls = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelezionaFoglio = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percorso file xls";
            // 
            // txtFilenameXls
            // 
            this.txtFilenameXls.Location = new System.Drawing.Point(105, 21);
            this.txtFilenameXls.Name = "txtFilenameXls";
            this.txtFilenameXls.ReadOnly = true;
            this.txtFilenameXls.Size = new System.Drawing.Size(181, 20);
            this.txtFilenameXls.TabIndex = 1;
            // 
            // btnLoadXls
            // 
            this.btnLoadXls.Location = new System.Drawing.Point(297, 18);
            this.btnLoadXls.Name = "btnLoadXls";
            this.btnLoadXls.Size = new System.Drawing.Size(39, 23);
            this.btnLoadXls.TabIndex = 2;
            this.btnLoadXls.Text = "...";
            this.btnLoadXls.UseVisualStyleBackColor = true;
            this.btnLoadXls.Click += new System.EventHandler(this.btnLoadXls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleziona foglio xls";
            // 
            // cmbSelezionaFoglio
            // 
            this.cmbSelezionaFoglio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelezionaFoglio.FormattingEnabled = true;
            this.cmbSelezionaFoglio.Location = new System.Drawing.Point(105, 62);
            this.cmbSelezionaFoglio.Name = "cmbSelezionaFoglio";
            this.cmbSelezionaFoglio.Size = new System.Drawing.Size(181, 21);
            this.cmbSelezionaFoglio.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(105, 101);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Load_from_xls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 136);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbSelezionaFoglio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadXls);
            this.Controls.Add(this.txtFilenameXls);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Load_from_xls";
            this.Text = "Load_from_xls";
            this.Load += new System.EventHandler(this.Load_from_xls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilenameXls;
        private System.Windows.Forms.Button btnLoadXls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelezionaFoglio;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}