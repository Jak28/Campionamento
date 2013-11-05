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
    public partial class Load_from_database : Form
    {
        public Load_from_database()
        {
            InitializeComponent();
        }
        public string PathDB { get { return txtPath.Text; } }
        public string Table { get { return txtTableName.Text; } }
        private void btnLoadFromDb_Click(object sender, EventArgs e)
        {
             OpenFileDialog opendlg = new OpenFileDialog();
             opendlg.Filter = "MDB Files (.mdb)|*.mdb|ACCDB Files (.accdb)|*.accdb|All Files (*.*)|*.*";
            DialogResult ris = opendlg.ShowDialog();
            if (ris == DialogResult.OK)
                txtPath.Text = opendlg.FileName;
        }
    }
}
