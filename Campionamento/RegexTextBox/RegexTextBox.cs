using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace RegexTextBox
{
    public partial class RegexTextBox: System.Windows.Forms.TextBox
    {
        public RegexTextBox()
        {
            InitializeComponent();
        }

        public String Pattern
        {
            get;
            set;
        }
        private bool _checkTextBox = true;
        public bool CheckTextBox
        {
            get { return _checkTextBox; }
            set { _checkTextBox = value; }
        }
        private bool _isValid = false;
        public bool isValid
        {
            get { return _isValid; }
        }
        private void RegexTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(Pattern);
            this._isValid = ((bool)(this.Text != string.Empty)) ? ((this.CheckTextBox) ? ((regex.IsMatch(this.Text) ? true : false)) : true) : false;
        }
    }
}

