using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Campionamento
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public Form1()
        {
            InitializeComponent();
        }
        List<myGrid.Values> valoriGrigliaMain = new List<myGrid.Values>();
        List<myGrid.Values> valoriGrigliaCampionamento = new List<myGrid.Values>();
        List<List<myGrid.ValuesMultiExtracions>> valoriGrigliaEstrazioniMultiple = new List<List<myGrid.ValuesMultiExtracions>>();
        private void btnLoadFromCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Filter = "CSV Files (.csv)|*.csv|All Files (*.*)|*.*";
            DialogResult ris = opendlg.ShowDialog();
            if (ris == DialogResult.OK)
            {
                dgvMain.loadFromCSV(opendlg.FileName);
                if (dgvMain.ColumnCount > 0 && dgvMain.RowCount > 0)
                {
                    valoriGrigliaMain = dgvMain.getValues();
                    loadComboBox();
                    enableSettingsMainTab();
                }
            }
        }
        private void enableSettingsMainTab()
        {
            if (!((Control)this.tabEstrazioni).Enabled)
            {
                ((Control)this.tabEstrazioni).Enabled = true;
                grpMainTab.Enabled = true;
                ((Control)this.tabEstrazioniMultiple).Enabled = true;
            }
        }
        private void btnLoadFromDB_Click(object sender, EventArgs e)
        {
            Load_from_database load = new Load_from_database();
            DialogResult ris = load.ShowDialog();
            if (ris == DialogResult.OK)
            {
                dgvMain.loadFromDB(load.PathDB, load.Table);
                if (dgvMain.ColumnCount > 0 && dgvMain.RowCount > 0){
                    valoriGrigliaMain = dgvMain.getValues();
                    loadComboBox();
                    enableSettingsMainTab();
                }
            }
        }
        private void loadComboBox()
        {
            cmbShow.Items.Clear();
            foreach (myGrid.Values v in valoriGrigliaMain)
                cmbShow.Items.Add(v.HeaderCell);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            ((Control)this.tabEstrazioni).Enabled = false;
            ((Control)this.tabEstrazioniMultiple).Enabled = false;
            grpMainTab.Enabled = false;
            grpEstrazioni.Enabled = false;
            rdbReimmissione.Checked = true;
            tmrControl.Start();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbShow.Text != string.Empty)
            {
                myGrid.Values temp = valoriGrigliaMain.Single(s => s.HeaderCell == cmbShow.Text);
                MessageBox.Show(string.Format("Valore minimo: {0}\nValore massimo: {1}\nMedia: {2}\n Varianza: {3}", temp.Min, temp.Max, temp.Media, temp.Var), "Valori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Estrazioni estrazioni = new Estrazioni();
            if (rdbReimmissione.Checked)
                fillDataGridView(estrazioni.EstrazioneConReimmissione(dgvMain, (int)pickUpEstrazione.Value));
            else if (rdbNoReimmissione.Checked)
                fillDataGridView(estrazioni.EstrazioneNoReimmisione(dgvMain, (int)pickUpEstrazione.Value));
            valoriGrigliaCampionamento = dgvEstrazioni.getValues();
            cmbDataEstrazioni.Items.Clear();
            foreach (myGrid.Values v in valoriGrigliaCampionamento)
                cmbDataEstrazioni.Items.Add(v.HeaderCell);
            grpEstrazioni.Enabled = true;
        }
        private void fillDataGridView(List<string> list)
        {
            dgvEstrazioni.Clear();
            dgvEstrazioni.ColumnCount = dgvMain.ColumnCount;
            for (int i = 0; i < dgvEstrazioni.ColumnCount; i++)
                dgvEstrazioni.Columns[i].HeaderCell.Value = dgvMain.Columns[i].HeaderCell.Value;
            for (int i = 0; i < list.Count; i++)
                dgvEstrazioni.Rows.Add(list[i].Split(';'));
        }
        private void btnMostraEstrazioniDati_Click(object sender, EventArgs e)
        {
            if (cmbDataEstrazioni.Text != string.Empty)
            {
                myGrid.Values temp = valoriGrigliaCampionamento.Single(s => s.HeaderCell == cmbDataEstrazioni.Text);
                MessageBox.Show(string.Format("Valore minimo: {0}\nValore massimo: {1}\nMedia: {2}\n Varianza: {3}", temp.Min, temp.Max, temp.Media, temp.Var), "Valori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void rdbReimmissione_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void tmrControl_Tick(object sender, EventArgs e)
        {
            if (rdbReimmissione.Checked)
                pickUpEstrazione.Maximum = decimal.MaxValue;
            else
                pickUpEstrazione.Maximum = (decimal)dgvMain.RowCount - 1;
            if (rdbReimmissioneEstrazioneMultiple.Checked)
                pickUpPopolazioneEstrazioniMultiple.Maximum = decimal.MaxValue;
            else
                pickUpPopolazioneEstrazioniMultiple.Maximum = (decimal)dgvMain.RowCount - 1;
        }

        private void btnEstrazioneMultipla_Click(object sender, EventArgs e)
        {
            dgvEstrazioniMultiple.Clear();
            for (int i = 0; i < dgvMain.ColumnCount; i++)
            {
                dgvEstrazioniMultiple.ColumnCount++;
                dgvEstrazioniMultiple.Columns[i].HeaderCell.Value = dgvMain.Columns[i].HeaderCell.Value;
            }
            if (rdbReimmissioneEstrazioneMultiple.Checked)
            {
 
            }
            else if (rdbEstrazioniMultipleNoReimmissione.Checked)
            {
 
            }
        }
        private myGrid.ValuesMultiExtracions loadMultipleValues(List<string> resultOfEstraction)
        {
            myGrid.ValuesMultiExtracions ret = new myGrid.ValuesMultiExtracions();
            return ret;
        }
    }
}
