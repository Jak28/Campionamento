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
using System.Data.OleDb;
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
                string conn=String.Empty;
                if (System.IO.Path.GetExtension(txtPath.Text).Equals(".mdb"))
                    conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtPath.Text;
                else if (System.IO.Path.GetExtension(txtPath.Text).Equals(".accdb"))
                    conn = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + txtPath.Text;
                OleDbConnection con = new OleDbConnection(conn);
                con.Open();
                Console.WriteLine("Made the connection to the database");

                Console.WriteLine("Information for each table contains:");
                DataTable tables = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                Console.WriteLine("The tables are:");
                foreach (DataRow row in tables.Rows)
                    cmbTableName.Items.Add(row[2]);


                con.Close();
                
            }
        }

        private void Load_from_database_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
