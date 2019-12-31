using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spellcheckerBIndo
{
    public partial class Kamus : Form
    {

        Main main;

        public Main Main { get => main; set => main = value; }

        public Kamus(Main ini)
        {
            InitializeComponent();
            Main = ini;
            textKamus.Text = String.Join("\n",main.M.Kata);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Main.M.saveKamus(textKamus.Text);
            this.Close();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            
            
            DialogResult dialogResult = MessageBox.Show("dengan menekan 'yes' anda akan mengembalikan kamus menjadi kamus awal dan tidak bisa diurungkan", "Yakin?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Main.M.setdefaultKamus();
                this.Close();
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
