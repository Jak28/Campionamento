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
        List<myGrid.ValuesMultiExtracions> valoriGrigliaEstrazioniMultiple = new List<myGrid.ValuesMultiExtracions>();
        List<myGrid.GridInList> gridInList = new List<myGrid.GridInList>();
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
                ((Control)this.tabClassi).Enabled = true;
                gridInList = dgvMain.transformGridInList();
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
            cmbScegliColonnaPopolazione.Items.Clear();
            foreach (myGrid.Values v in valoriGrigliaMain)
                cmbScegliColonnaPopolazione.Items.Add(v.HeaderCell);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            ((Control)this.tabEstrazioni).Enabled = false;
            ((Control)this.tabEstrazioniMultiple).Enabled = false;
            grpMainTab.Enabled = false;
            grpEstrazioni.Enabled = false;
            grpEstrazioniMultiple.Enabled = false;
            rdbReimmissione.Checked = true;
            tmrControl.Start();
            ((Control)this.tabClassi).Enabled = false;
           
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
                pickUpPopolazioneEstrazioniMultiple.Maximum = (decimal)dgvMain.RowCount + ((dgvMain.RowCount == 0) ? 0 : -1);
        }
        private void btnEstrazioneMultipla_Click(object sender, EventArgs e)
        {
            valoriGrigliaEstrazioniMultiple.Clear();
            dgvEstrazioniMultiple.Clear();
            cmbSceltaNumeroEstrazione.Items.Clear();
            cmbSceltaColonna.Items.Clear();
            cmbSceltaNumeroEstrazione.Text = cmbSceltaColonna.Text = string.Empty;
            dgvEstrazioniMultiple.ColumnCount++;
            dgvEstrazioniMultiple.Columns[0].HeaderCell.Value = "Numero Estrazione";
            for (int i = 0; i < dgvMain.ColumnCount; i++)
            {
                dgvEstrazioniMultiple.ColumnCount++;
                dgvEstrazioniMultiple.Columns[i+1].HeaderCell.Value = dgvMain.Columns[i].HeaderCell.Value;
            }
            Estrazioni estrazioni=new Estrazioni();
            List<string> tmp = new List<string>();
            for (int i = 0; i < (int)pickUpNumeroCampione.Value; i++)
            {
                if (rdbReimmissioneEstrazioneMultiple.Checked)
                {
                    tmp = estrazioni.EstrazioneConReimmissione(dgvMain, (int)pickUpPopolazioneEstrazioniMultiple.Value);
                    valoriGrigliaEstrazioniMultiple.Add(loadMultipleValuesIntoList(tmp,i+1));
                    setIntoMultipleExtracionGrid(tmp, i + 1);
                    dgvEstrazioniMultiple.Rows.Add();
                }
                else if (rdbEstrazioniMultipleNoReimmissione.Checked)
                {
                    tmp = estrazioni.EstrazioneNoReimmisione(dgvMain, (int)pickUpPopolazioneEstrazioniMultiple.Value);
                    valoriGrigliaEstrazioniMultiple.Add(loadMultipleValuesIntoList(tmp,i+1));
                    setIntoMultipleExtracionGrid(tmp, i + 1);
                    dgvEstrazioniMultiple.Rows.Add();
                }
            }
            for (int i = 0; i < valoriGrigliaEstrazioniMultiple.Count; i++)
                cmbSceltaNumeroEstrazione.Items.Add(valoriGrigliaEstrazioniMultiple[i].TableName);
            grpEstrazioniMultiple.Enabled = true;
        }
        private void setIntoMultipleExtracionGrid(List<string> tmp, int n)
        {
            for (int i = 0; i < tmp.Count; i++)
                dgvEstrazioniMultiple.Rows.Add(string.Format("{0};{1}", n, tmp[i]).Split(';'));
        }
        private myGrid.ValuesMultiExtracions loadMultipleValuesIntoList(List<string> resultOfEstraction, int n)
        {
            myGrid.ValuesMultiExtracions results = new myGrid.ValuesMultiExtracions();
            DataGridView tmp = new DataGridView();
            results.TableName = "Estrazione " + n;
            tmp.ColumnCount = counterChar(resultOfEstraction[0], ';') + 1;
            for (int i = 0; i < tmp.ColumnCount; i++)
                tmp.Columns[i].HeaderCell.Value = dgvMain.Columns[i].HeaderCell.Value;
            for (int i = 0; i < resultOfEstraction.Count; i++)
                tmp.Rows.Add(resultOfEstraction[i].Split(';'));
            for (int i = 0; i < tmp.ColumnCount; i++)
            {
                myGrid.Values temp = new myGrid.Values();
                temp.Min = double.MaxValue;
                temp.Max = double.MinValue;
                int popolazione = 0;
                double x, ssqx, sx;
                x = ssqx = sx = 0.0;
                temp.HeaderCell = tmp.Columns[i].HeaderCell.Value.ToString();
                for (int j = 0; j < tmp.RowCount - 1; j++)
                {
                    if (tmp[i, j].Value != null)
                    {
                        double.TryParse(tmp[i, j].Value.ToString(), out x);
                        ssqx += x * x;
                        sx += x;
                        popolazione++;
                        if (x < temp.Min)
                            temp.Min = x;
                        if (x > temp.Max)
                            temp.Max = x;
                    }
                }
                if (popolazione > 0)
                {
                    temp.Media = sx / popolazione;
                    temp.Var = 1.0 / popolazione * Math.Sqrt((popolazione * ssqx) - (sx * sx));
                    
                }
                results.Values.Add(temp);
            }
            return results;
        }
        private int counterChar(string s, char c)
        {
            int ret = 0;
            foreach (char ch in s)
                if (ch == c)
                    ret++;
            return ret;
        }
        private void pickUpNumeroCampione_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cmbSceltaNumeroEstrazione_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSceltaNumeroEstrazione.Text != string.Empty)
            {
                var v = valoriGrigliaEstrazioniMultiple.Single(s => s.TableName == cmbSceltaNumeroEstrazione.Text);
                List<myGrid.Values> tmp = v.Values;
                cmbSceltaColonna.Items.Clear();
                for (int i = 0;i< tmp.Count; i++)
                    cmbSceltaColonna.Items.Add(tmp[i].HeaderCell);
            }
        }
        private void btnMostraDati_Click(object sender, EventArgs e)
        {
            if (cmbSceltaColonna.Text != string.Empty)
            {
                var v = valoriGrigliaEstrazioniMultiple.Single(s => s.TableName == cmbSceltaNumeroEstrazione.Text);
                var temp = v.Values.Single(s => s.HeaderCell == cmbSceltaColonna.Text);
                MessageBox.Show(string.Format("Valore minimo: {0}\nValore massimo: {1}\nMedia: {2}\n Varianza: {3}", temp.Min, temp.Max, temp.Media, temp.Var), "Valori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnScegliColonnaClassiPopolazioneOk_Click(object sender, EventArgs e)
        {
            bool correct = txtNClassi.isValid && txtXMax.isValid && txtXMin.isValid && cmbScegliColonnaPopolazione.Text != string.Empty;
            if (correct)
            {
                double xmin = Convert.ToDouble(txtXMin.Text);
                double xmax = Convert.ToDouble(txtXMax.Text);
                int nClassi = Convert.ToInt32(txtNClassi.Text);
                if (xmin < xmax && xmin > 0 && xmax <= dgvMain.RowCount - 1)
                {
                    myGrid.GridInList tempGridInList = new myGrid.GridInList();
                    foreach (myGrid.GridInList glt in gridInList)
                        if (glt.Equals(cmbScegliColonnaPopolazione.Text))
                        {
                            tempGridInList = glt;
                            break;
                        }
                    List<double> temp = new List<double>();
                    for (int i = 0; i < tempGridInList.ValueCells.Count; i++)
                        temp.Add(Convert.ToDouble(tempGridInList.ValueCells[i]));
                    temp.Sort();
                }
            }
        }
    }
}
