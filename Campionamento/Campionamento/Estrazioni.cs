using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campionamento
{
    class Estrazioni
    {
        public List<string> EstrazioneNoReimmisione(System.Windows.Forms.DataGridView dgv,int howMuch)
        {
            List<string> listGrid = RecordToList(dgv);
            List<string> random = new List<string>();
            Random rnd = new Random();
            for (int i = 0; i < howMuch; i++)
            {
                int r = rnd.Next(0, listGrid.Count);
                random.Add(listGrid[r]);
                listGrid.RemoveAt(r);
            }
            return random;
        }
        public List<string> EstrazioneConReimmissione(System.Windows.Forms.DataGridView dgv, int howMuch)
        {
            List<string> listGrid = RecordToList(dgv);
            List<string> random = new List<string>();
            Random rnd = new Random();
            for (int i = 0; i < howMuch; i++)
            {
                int r = rnd.Next(0, listGrid.Count);
                random.Add(listGrid[r]);
            }
            return random;
        }
        private List<string> RecordToList(System.Windows.Forms.DataGridView dgv)
        {
            List<string> ret = new List<string>();
            string line;
            for (int i = 0; i < dgv.RowCount-1; i++)
            {
                line = string.Empty;
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    line =line+ dgv[j, i].Value.ToString() + ';';
                }
                line = line.Remove(line.LastIndexOf(';'));
                ret.Add(line);
            }
            return ret;

        }
    }
}
