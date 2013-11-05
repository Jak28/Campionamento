using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<myGrid.Values> valoriGrigliaMain = new List<myGrid.Values>();
        private void btnLoadFromCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Filter = "CSV Files (.csv)|*.txt|All Files (*.*)|*.*";
            DialogResult ris = opendlg.ShowDialog();
            if (ris == DialogResult.OK)
            {
                dgvMain.loadFromCSV(opendlg.FileName);
                if (dgvMain.ColumnCount > 0 && dgvMain.RowCount > 0)
                {
                    valoriGrigliaMain = dgvMain.getValues();
                    loadComboBox();
                    pickUpEstrazione.Maximum = dgvMain.RowCount-1;
                }
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
                }
            }
        }
        private void loadComboBox()
        {
            foreach (myGrid.Values v in valoriGrigliaMain)
                cmbShow.Items.Add(v.HeaderCell);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbReimmissione.Checked = true;
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
    }
}
