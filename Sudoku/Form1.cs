using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Difficulties difficulties;
        public List<Person> players;
        public Options options;

        public Form1()
        {
            InitializeComponent();
            players = new List<Person>();
            options = new Options(this);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            difficulties = new Difficulties(this, options);
            difficulties.Show();
            this.Hide();  
        }

        public void setOptions(Options o)
        {
            options = o;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            options = new Options(this);
            options.Show();
            this.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(players, this);
            stats.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
