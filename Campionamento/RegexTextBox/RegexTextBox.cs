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
        private Regex _pattern = new Regex(@"^[0-9]{0,2}\.?[0-9]{0,2}$");
        public Regex Pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
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
            this._isValid = ((bool)(this.Text != string.Empty)) ? ((this.CheckTextBox) ? ((this.Pattern.IsMatch(this.Text) ? true : false)) : true) : false;
        }
    }
}

