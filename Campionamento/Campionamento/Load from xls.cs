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
    public partial class Load_from_xls : Form
    {
        public Load_from_xls()
        {
            InitializeComponent();
        }
        public string GetFileNameXls { get { return txtFilenameXls.Text; } }
        public string GetSheetSelected { get { return cmbSelezionaFoglio.Text; } }
        public bool InputCorrect { get; set; }
        private void Load_from_xls_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadXls_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Filter = "Xls Files (.xls)|*.xls";
            
            if (DialogResult.OK == opendlg.ShowDialog())
            {
                cmbSelezionaFoglio.Items.Clear();
                ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
                workbook = ExcelLibrary.SpreadSheet.Workbook.Load(opendlg.FileName);
                txtFilenameXls.Text = opendlg.FileName;
                Console.WriteLine("Sheets name in Xls: ");
                for (int i = 0; i < workbook.Worksheets.Count; i++)
                {
                    Console.WriteLine(workbook.Worksheets[i].Name);
                    cmbSelezionaFoglio.Items.Add(workbook.Worksheets[i].Name);
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InputCorrect = (txtFilenameXls.Text != string.Empty && cmbSelezionaFoglio.Text != string.Empty) ? true : false;
        }
    }
}
