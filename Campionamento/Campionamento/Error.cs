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
            txtError.Text = error;
        }

        private void Error_Load(object sender, EventArgs e)
        {

        }
    }
}
