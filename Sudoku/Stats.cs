using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sudoku
{
    [Serializable]
    public partial class Stats : Form
    {
        public List<Person> players;
        public Form1 form;
        Stream str;
        BinaryFormatter bf;
        public Person player;

        public Stats()
        {
            InitializeComponent();
        }

        public Stats(List<Person> listPlayers, Form1 f)
        {
            InitializeComponent();
            players = new List<Person>();
            form = f;
            
        }

        private void ReadPlayers()
        {
            str = File.OpenRead("test.bin");
            bf = new BinaryFormatter();
            int j = 1;
            players.Clear();
            while(str.Length != str.Position)
            {
                Console.WriteLine(str.Length + " " + str.Position);
                player = bf.Deserialize(str) as Person;
                players.Add(player);
            }
            str.Close();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            lbPlayers.Items.Clear();
            lbPlayers.Items.Add(String.Format("{0, -5} {1, -10} {2}", "Nb.", "Player", "Time"));
          
            ReadPlayers();

            players = players.OrderBy(x => x.Time).ToList();
            
            for (int i = 0; i < players.Count; i++)
            {
                lbPlayers.Items.Add(String.Format("{0} {1, -5} {2}", i + 1, ".", players[i].ToString()));
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void Stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }        
    }
}
