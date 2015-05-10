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
    public partial class Difficulties : Form
    {
        public Form1 form;
        public Game game;
        public Options options;

        public int GameDifficulty { get; set; }
        public bool easy { get; set; }
        public bool normal { get; set; }
        public bool hard { get; set; }
        public bool expert { get; set; }

        public Difficulties()
        {
            InitializeComponent();
            GameDifficulty = 0;
            easy = false;
            normal = false;
            hard = false;
            expert = false;
        }

        public Difficulties(Form1 f, Options o)
        {
            InitializeComponent();
            form = f;
            options = o;
            GameDifficulty = 0;

            easy = false;
            normal = false;
            hard = false;
            expert = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void Difficulties_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {      
            easy = true;
            normal = false;
            hard = false;
            expert = false;

            game = new Game(this, form, options);
            game.Show();
            this.Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            easy = false;
            normal = true;
            hard = false;
            expert = false;

            game = new Game(this, form, options);
            game.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {           
            easy = false;
            normal = false;
            hard = true;
            expert = false;

            game = new Game(this, form, options);
            game.Show();
            this.Hide();
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            easy = false;
            normal = false;
            hard = false;
            expert = true;

            game = new Game(this, form, options);
            game.Show();
            this.Hide();
        }
    }
}
