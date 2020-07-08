using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Dim;
        Cell[,] Cs;
        Cell cc;
        int Player = 0, NOP = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void OnCellClickHvH(object sender, EventArgs e)
        {
           
            Cell clickedcell = (Cell)sender;

                    if (clickedcell.Occupied == true)
                    {
                        MessageBox.Show("Select Valid Box..!!!");
                        return;
                    }
                    if (Player == 0)
                    {
                        clickedcell.BackColor = Color.BlueViolet;
                        clickedcell.OccupierID = Player;
                        clickedcell.Occupied = true;
                        clickedcell.Text = "0";
                    }
                    else if (Player == 1)
                    {
                        clickedcell.BackColor = Color.DarkCyan;
                        clickedcell.OccupierID = Player;
                        clickedcell.Occupied = true;
                        clickedcell.Text = "1";
                    }


                if (IsWin(clickedcell.Ri, clickedcell.Ci))
                {
                    MessageBox.Show("Player " + Player.ToString() + " Wins..!!");
                    Grid.Controls.Clear();
                    return;
                }
                if (isDraw())
                {
                    MessageBox.Show("Game Draw...!!!");
                    Grid.Controls.Clear();
                    return;
                }

            TurnChange();
        }
        void OnCellClickHvC(object sender, EventArgs e)
        {

            Cell clickedcell = (Cell)sender;
            for(int i=0;i<2;i++)
            {
                if(i==0)
                {
                    if(clickedcell.OccupierID != -1)
                    {
                        MessageBox.Show("Select Valid Move...!!!");
                    }
                }
                else
                {
                    ComputerMove();
                }
                if (Player == 0)
                {
                    clickedcell.BackColor = Color.BlueViolet;
                    clickedcell.OccupierID = Player;
                    clickedcell.Occupied = true;
                    clickedcell.Text = "0";
                }
                if (IsWin(clickedcell.Ri, clickedcell.Ci))
                {
                    MessageBox.Show("Player " + Player.ToString() + " Wins..!!");
                    Grid.Controls.Clear();
                    return;
                }
                if (isDraw())
                {
                    MessageBox.Show("Game Draw...!!!");
                    Grid.Controls.Clear();
                    return;
                }
                //TurnChange();
            }

        }
        void ComputerMove()
        {
            int x = 0, y = 0;
            do
            {
                Random r = new Random();
                x = r.Next(0, Dim - 1);
                y = r.Next(0, Dim - 1);
            } while (Cs[x, y].OccupierID != -1);
            cc = Cs[x, y];

            //TurnChange();

            for (int i = 0;i<Dim;i++)
            {
                for(int j=0;j<Dim;j++)
                {
                    if(Cs[i,j].OccupierID==-1)
                    {
                        Cs[i, j].OccupierID = 1;
                        if (IsWin(Cs[i, j].Ri, Cs[i, j].Ci))
                        {
                            Cs[i, j].Occupied = true;
                            Cs[i, j].OccupierID = 1;
                            Cs[i, j].BackColor = Color.DarkCyan;
                            Cs[i, j].Text = "1";

                            //Cs[i, j].OccupierID = -1;
                            cc = Cs[i, j];
                            return;
                        }
                        else
                        {
                            Cs[i, j].OccupierID = -1;
                        }
                    }
                }
            }
            Cs[x, y].Occupied = true;
            Cs[x, y].OccupierID = 1;
            Cs[x, y].BackColor = Color.DarkCyan;
            Cs[x, y].Text = "1";
        }
        bool IsWin(int r,int c)
        {
            if (CheckHorizontal(r, c))
            {
                return true;
            }
            else if (CheckVertical(r, c))
            {
                return true;
            }
            else if (CheckDiagonalL2R(r, c))
            {
                return true;
            }
            else if (CheckDiagonalR2L(r, c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isDraw()
        {
            int check = 0;
            for(int i=0;i<Dim;i++)
            {
                for(int j=0;j<Dim;j++)
                {
                    if(Cs[i,j].Occupied==true)
                    {
                        check = 1;
                    }
                    else
                    {
                        check = 2;
                        return false;
                    }
                }
            }
            return true;
        }
        bool CheckHorizontal(int r, int c)
        {
            int count = 1;
            for (int j = -1; j < 2; j += 2)
            {
                int v = 1;
                if (j == -1)
                    v = 0;
                for (int i = c + v; (j == 1) ? i < Dim : i > 0; i += j)
                {
                    if (Cs[r, i].Occupied && Cs[r, i - 1].Occupied && Cs[r, i].OccupierID == Cs[r, i - 1].OccupierID)
                    {
                        count++;
                        if (count == 5)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        bool CheckVertical(int r, int c)
        {
            int count = 1;
            for (int j = -1; j < 2; j += 2)
            {
                int v = 1;
                if (j == -1)
                    v = 0;
                for (int i = r + v; (j == 1) ? i < Dim : i > 0; i += j)
                {
                    if (Cs[i, c].Occupied && Cs[i - 1, c].Occupied && Cs[i , c].OccupierID == Cs[i - 1, c].OccupierID)
                    {
                        count++;
                        if (count == 5)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        bool CheckDiagonalL2R(int r, int c)
        {
            int count = 0;
            for (int i = r, j = c; i < Dim && j < Dim; i++, j++)
            {
                if (Cs[i, j].Occupied == true && Cs[i, j].OccupierID == Player)
                {
                    count++;
                }
                if (count == 5)
                {
                    return true;
                }
            }
            for (int i = r -1 , j = c - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (Cs[i, j].Occupied == true && Cs[i, j].OccupierID == Player)
                {
                    count++;
                }
                if (count == 5)
                {
                    return true;
                }
            }
            return false;
        }
        bool CheckDiagonalR2L(int r, int c)
        {
            int count = 0;

            for (int i = r, j = c; i < Dim && j >= 0 ; i++ , j-- )
            {
                if (Cs[i, j].Occupied == true && Cs[i, j].OccupierID == Player)
                {
                    count++;
                }
                if (count == 5)
                {
                    return true;
                }
            }
            for (int i = r - 1, j = c + 1; i >= 0 && j < Dim; i--, j++)
            {
                if (Cs[i, j].Occupied == true && Cs[i, j].OccupierID == Player)
                {
                    count++;
                }
                if (count == 5)
                {
                    return true;
                }
            }
            return false;
        }
        void TurnChange()
        {
            Player = (Player + 1) % NOP;
        }
        void Init()
        {
            Grid.Controls.Clear();
            if(Dim==5)
            {
                Grid.Padding = new Padding(10,10,10,10);
            }
            else if(Dim ==10)
            {
                Grid.Padding = new Padding(20,20,20,20);
            }
            else if (Dim == 15)
            {
                Grid.Padding = new Padding(30, 30, 30, 30);
            }
            else if (Dim == 10)
            {
                Grid.Padding = new Padding(40, 40, 40, 40);
            }

            Cs = new Cell[Dim, Dim];
            for (int r = 0; r < Dim; r++)
            {
                for (int c = 0; c < Dim; c++)
                {
                    int H = Grid.Height / Dim - 10;
                    int W = Grid.Width / Dim - 10;
                    Cell block = new Cell(H, W);
                    block.Ri = r;
                    block.Ci = c;
                    if (HvH.Checked == true)
                    {
                        block.Click += new EventHandler(OnCellClickHvH);
                    }
                    else if (HvC.Checked == true)
                    {
                        block.Click += new EventHandler(OnCellClickHvC);
                    }
                    Grid.Controls.Add(block);
                    Cs[r, c] = block;
                }
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (HvH.Checked == false && HvC.Checked == false)
            {
                MessageBox.Show("Select b/w Human V Human Or Human Vs Computer");
                return;
            }

            if (FiveFive.Checked == true)
            {
                Dim = 5;
            }
            else if (TenTen.Checked == true)
            {
                Dim = 10;
            }
            else if (FifteenFifteen.Checked == true)
            {
                Dim = 15;
            }
            else if (TwentyTwenty.Checked == true)
            {
                Dim = 20;
            }

            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
