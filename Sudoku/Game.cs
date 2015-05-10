using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sudoku
{
    [Serializable]
    public partial class Game : Form
    {
        public ErrorProvider error;
        public Difficulties difficulties;
        public Options options;
        public Matrix matrix;
        public Form1 form;
        public TextBox[,] currentMatrix;
        public int[,] tempMatrix;
        public Person Player { get; set; }
        public Random random;
        private string tempTime;
        private int min;
        private int sec;
        private int numHints;
        private bool emptyField;
        private bool incorrectValue;
        private bool findField;
        private bool alReadyChecked = false;
        private SoundPlayer soundPlayer;
        Stream str;
        BinaryFormatter bf;

        public Game()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        public Game(Difficulties d, Form1 f, Options o)
        {
            InitializeComponent();
            error = new ErrorProvider();
            difficulties = d;
            form = f;
            options = o;
            matrix = new Matrix();
            currentMatrix = new TextBox[9, 9];
            tempMatrix = new int[9, 9];
            random = new Random();
            numHints = 5;
            form = f;
            str = File.Open("test.bin", FileMode.Append);
            bf = new BinaryFormatter();
            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);


            if (difficulties.easy == true)
            {
                matrix.easyMatrix();
                tempMatrix = matrix.List.ElementAt(random.Next(4));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Font font = new Font("Times New Roman", 16.0f, FontStyle.Bold | FontStyle.Italic);

                        currentMatrix[i,j] = new TextBox();
                        currentMatrix[i,j].Location = new Point(20 + 50 * i, 145 + 53 * j);
                        currentMatrix[i,j].Size = new System.Drawing.Size(45, 50);
                        currentMatrix[i,j].BackColor = Color.Wheat;
                        currentMatrix[i,j].Font = font;

                        if (((i % 4 == 0) && (j % 5 == 0)) || ((i % 3 == 0) && (j % 2 == 0)))
                        {
                            currentMatrix[i, j].Clear();
                        }
                        else
                        {
                            currentMatrix[i,j].AppendText(tempMatrix[j,i].ToString());
                            currentMatrix[i,j].Enabled = false;
                        }

                        this.Controls.Add(currentMatrix[i, j]);
                    }
                }
            }
            else if (difficulties.normal == true)
            {
                matrix.normalMatrix();
                tempMatrix = matrix.List.ElementAt(random.Next(4));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Font font = new Font("Times New Roman", 16.0f, FontStyle.Bold | FontStyle.Italic);

                        currentMatrix[i,j] = new TextBox();
                        currentMatrix[i,j].Location = new Point(20 + 50 * i, 145 + 53 * j);
                        currentMatrix[i,j].Size = new System.Drawing.Size(45, 50);
                        currentMatrix[i,j].BackColor = Color.Wheat;
                        currentMatrix[i,j].Font = font;

                        if (((i % 2 == 0) && (j % 5 == 0)) || ((i % 4 == 0) && (j % 2 == 0)) || ((i % 3 == 0) && (j % 4 == 0)))
                        {
                            currentMatrix[i,j].Clear();
                        }
                        else
                        {
                            currentMatrix[i,j].AppendText(tempMatrix[j,i].ToString());
                            currentMatrix[i,j].Enabled = false;
                        }

                        this.Controls.Add(currentMatrix[i, j]);
                    }
                }
            }
            else if (difficulties.hard == true)
            {
                matrix.hardMatrix();
                tempMatrix = matrix.List.ElementAt(random.Next(4));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Font font = new Font("Times New Roman", 16.0f, FontStyle.Bold | FontStyle.Italic);

                        currentMatrix[i,j] = new TextBox();
                        currentMatrix[i,j].Location = new Point(20 + 50 * i, 145 + 53 * j);
                        currentMatrix[i,j].Size = new System.Drawing.Size(45, 50);
                        currentMatrix[i,j].BackColor = Color.Wheat;
                        currentMatrix[i,j].Font = font;

                        if (((i % 2 == 0) && (j % 3 == 0)) || ((i % 3 == 0) && (j % 2 == 0)) || ((i % 2 == 0) && (j % 6 == 0)) || ((i % 7 == 0) && (j % 2 == 0)))
                        {
                            currentMatrix[i,j].Clear();
                        }
                        else
                        {
                            currentMatrix[i,j].AppendText(tempMatrix[j,i].ToString());
                            currentMatrix[i,j].Enabled = false;
                        }

                        this.Controls.Add(currentMatrix[i,j]);
                    }
                }
            }
            else if (difficulties.expert == true)
            {
                matrix.expertMatrix();
                tempMatrix = matrix.List.ElementAt(random.Next(4));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Font font = new Font("Times New Roman", 16.0f, FontStyle.Bold | FontStyle.Italic);

                        currentMatrix[i, j] = new TextBox();
                        currentMatrix[i, j].Location = new Point(20 + 50 * i, 145 + 53 * j);
                        currentMatrix[i, j].Size = new System.Drawing.Size(45, 50);
                        currentMatrix[i, j].BackColor = Color.Wheat;
                        currentMatrix[i, j].Font = font;

                        if (((i % 2 == 0) && (j % 3 == 0)) || ((i % 3 == 0) && (j % 2 == 0)) || ((i % 2 == 0) && (j % 6 == 0)) || ((i % 7 == 0) && (j % 2 == 0)) || ((i == 3) && (j % 2 == 0)) || ((j == 2) && (i % 2 == 0)))
                        {
                            currentMatrix[i, j].Clear();
                        }
                        else
                        {
                            currentMatrix[i, j].AppendText(tempMatrix[j, i].ToString());
                            currentMatrix[i, j].Enabled = false;
                        }

                        this.Controls.Add(currentMatrix[i, j]);
                    }
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                error.SetError(tbName, "The name of the player is necessary!");
                e.Cancel = true;
            }
            else
            {
                error.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            str.Close();
            timer1.Stop();
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
            difficulties.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            str.Close();
            timer1.Stop();
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
            
            difficulties.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempTime = lblTime.Text.ToString();
            string[] split = tempTime.Split(':');
            min = Convert.ToInt32(split[0]);
            sec = Convert.ToInt32(split[1]) + 1;

            if (sec == 60)
            {
                min += 1;
                sec = 0;
            }

            lblTime.Text = String.Format("{0:00}:{1:00}", min, sec);
        }

        private bool getHint()
        {
            findField = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (currentMatrix[i, j].Text.Trim().Length == 0)
                    {
                        currentMatrix[i, j].Text = tempMatrix[j, i].ToString();
                        findField = true;
                        break;
                    } 
                    
                }

                if (findField == true)
                {
                    return true;
                }
                
            }
            return false;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (numHints > 0)
            {
                if (getHint())
                {
                    numHints--;
                }             
            }
            else
            {
                MessageBox.Show("No more hints!");
            }
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            switch (options.getSelected())
            {
                case "Simple": soundPlayer = new SoundPlayer(Properties.Resources.Simple_Music); break;
                case "Maid": soundPlayer = new SoundPlayer(Properties.Resources.Maid); break;
                case "Pou": soundPlayer = new SoundPlayer(Properties.Resources.Pou_Soundtrack); break;
                default: break;
            }

            if(soundPlayer != null)
            {
                soundPlayer.Play();
            }

            if (options.getChecked() == "No")
            {
                btnHint.Visible = false;
            }

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
            if (tbName.Text.Trim().Length != 0)
            {
                difficulties.Show();
            }            
        }
    }
}
