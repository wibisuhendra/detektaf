using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyString;


namespace spellcheckerBIndo
{
    public partial class Main : Form
    {
        Mesin m;

        public Main()
        {
            InitializeComponent();
            M = new Mesin();
        }

        internal Mesin M { get => m; set => m = value; }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            //textHasil.Text = Levenshtein.Distance(textInput.Text,"apotek").ToString();
            textHasil.Text = String.Join("\n",M.cekPerkata(textInput.Text));
            textInput.Text = String.Join(" ", M.CekKata(textInput.Text));
            //textHasil.Text = FuzzyString.ComparisonMetrics.SorensenDiceDistance(textInput.Text, "sekadar").ToString();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textHasil.Text = "";
            textInput.Text = "";
        }

        private void buttonSunting_Click(object sender, EventArgs e)
        {
            Kamus kamus = new Kamus(this);
            kamus.ShowDialog();
        }
    }
}
