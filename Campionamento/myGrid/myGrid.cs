using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
namespace myGrid
{
    public partial class myGrid: System.Windows.Forms.DataGridView
    {
        public myGrid()
        {
            InitializeComponent();
        }
        public void loadFromCSV(string filename)
        {
            if (!System.IO.File.Exists(filename))
                return;
            if (!(System.IO.Path.GetExtension(filename).Equals(".csv")))
                return;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
            {
                this.DataSource = null;
                this.Clear();
                string[] tmp = sr.ReadLine().Split(';');
                this.ColumnCount=tmp.Length;
                for (int i = 0; i < tmp.Length; i++)
                    this.Columns[i].HeaderCell.Value = tmp[i];
                while (sr.Peek() > -1)
                    this.Rows.Add(sr.ReadLine().Split(';'));
            }
            if (!checkGridIsCorrect())
                Clear();
        }
        public void loadFromXls(string filename, string SheetName)
        {
            this.DataSource = null;
            this.Columns.Clear();
            Workbook workbook = new Workbook();
            workbook = Workbook.Load(filename);
            Worksheet worksheet = null;
            bool find=true;
            for (int i = 0; i < workbook.Worksheets.Count && find; i++)
                if (workbook.Worksheets[i].Name.Equals(SheetName))
                {
                    worksheet = workbook.Worksheets[i];
                    find = false;
                }
            for (int i = 0; i <= worksheet.Cells.LastColIndex; i++)
                this.Columns.Add(string.Format("Column{0}", i.ToString()), worksheet.Cells[0, i].StringValue);
            for (int i = 0; i < worksheet.Cells.Rows.Count; i++)
            {
                    this.Rows.Add();
                for (int j = 0; j <= worksheet.Cells.LastColIndex; j++)
                    if (i != 0)
                        this.Rows[i].Cells[j].Value = worksheet.Cells[i, j].StringValue;
            }
            this.Rows.RemoveAt(0);
            if (!checkGridIsCorrect())
                Clear();
        }
        public void loadFromDB(string filename, string nomeTabella)
        {
            this.Clear();
            AdoNet ado = new AdoNet(filename);
            string query = string.Format("SELECT * FROM {0}", nomeTabella);
            ado.eseguiQuery(query, CommandType.Text);
            this.DataSource = ado.daTable;
            if (!checkGridIsCorrect())
                Clear();
            ado.chiudiConnessione(); 
        }
        public void Clear()
        {
            this.Columns.Clear();
            this.Rows.Clear();
        }
        private bool checkGridIsCorrect()
        {
            string error=string.Empty;
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]{1,}([.,][0-9]{0,})?$");
            for (int i = 0; i < this.ColumnCount; i++)
                for (int j = 0; j < this.RowCount - 1; j++)
                    if (this[i, j].Value != null)
                        if (!regex.IsMatch(this[i, j].Value.ToString()))
                            error = error + '\n' + string.Format("Error at column {0} row {1} value: {2}", i, j, this[i, j].Value.ToString());
            if (error != string.Empty)
            {
                Error errorForm = new Error(String.Format("Error{0} in table at:\n {1}", (counterChar(error, '\n') == 1) ? "s " : " ", error));
                errorForm.ShowDialog();
                return false;
            }
                return true;

        }
        private int counterChar(string s, char toFind)
        {
            int ret=0;
            foreach (char c in s)
                if (c == toFind)
                    ret++;
            return ret;
        }
        public List<Values> getValues()
        {
            List<Values> ret = new List<Values>();
            for (int i = 0; i < this.ColumnCount; i++)
            {
                Values results = new Values();
                results.Min = double.MaxValue;
                results.Max = double.MinValue;
                int popolazione = 0;
                double x, ssqx, sx;
                x = ssqx = sx = 0.0;
                results.HeaderCell = this.Columns[i].HeaderCell.Value.ToString();
                for (int j = 0; j < this.RowCount-1; j++)
                {
                    if (this[i, j].Value != null)
                    {
                        double.TryParse(this[i, j].Value.ToString(), out x);
                        ssqx += x * x;
                        sx += x;
                        popolazione++;
                        if (x < results.Min)
                            results.Min = x;
                        if (x > results.Max)
                            results.Max = x;
                    }
                }
                if (popolazione > 0)
                {
                    results.Media = sx / popolazione;
                    results.Var = 1.0 / popolazione * Math.Sqrt((popolazione * ssqx) - (sx * sx));
                }
                ret.Add(results);
            }
            return ret;
        }
        public List<GridInList> transformGridInList()
        {
            List<GridInList> ret = new List<GridInList>();
            for (int i = 0; i < this.ColumnCount; i++)
            {
                GridInList temp = new GridInList();
                
                temp.HeaderCellText = this.Columns[i].HeaderCell.Value.ToString();
                temp.ValueCells = new List<string>();
                for (int j = 0; j < this.RowCount; j++)
                    if(this[i,j]!=null && this[i,j].Value!=null)
                        temp.ValueCells.Add(this[i, j].Value.ToString());
                ret.Add(temp);
            }
            return ret;
        }
    }
}
