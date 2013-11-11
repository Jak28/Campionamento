using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myGrid;
namespace Campionamento
{
    public partial class Load_from_database : Form
    {
        public Load_from_database()
        {
            InitializeComponent();
        }
        public string PathDB { get { return txtPath.Text; } }
        public string Table { get { return cmbTableName.Text; } }
        private void btnLoadFromDb_Click(object sender, EventArgs e)
        {
            cmbTableName.Items.Clear();
             OpenFileDialog opendlg = new OpenFileDialog();
             opendlg.Filter = "MDB Files (.mdb)|*.mdb|ACCDB Files (.accdb)|*.accdb|All Files (*.*)|*.*";
            DialogResult ris = opendlg.ShowDialog();
            if (ris == DialogResult.OK)
            {
                txtPath.Text = opendlg.FileName;
                if (!System.IO.File.Exists(txtPath.Text))
                    return;
                AdoNet ado = new AdoNet(txtPath.Text);
                string sql = @"SELECT  MSysObjects.Name FROM MsysObjects WHERE (Left$([Name],1)<>""~"")AND 
(Left$([Name],4) <> ""Msys"") AND (MSysObjects.Type)=1 ORDER BY MSysObjects.Name;";
                ado.eseguiQuery(sql, CommandType.Text);
                for (int i = 0; i < ado.daTable.Rows.Count; i++)
                    cmbTableName.DataSource = ado.daTable;
            }
        }

        private void Load_from_database_Load(object sender, EventArgs e)
        {

        }
    }
}
