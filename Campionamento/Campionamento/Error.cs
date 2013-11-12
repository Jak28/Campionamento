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
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();
            foreach (string s in error.Split('\n'))
            {
                string temp = s;
                temp = s.Replace("\r", "");
                txtError.AppendText(temp + "\n");
            }
        }

        private void Error_Load(object sender, EventArgs e)
        {

        }
    }
}
