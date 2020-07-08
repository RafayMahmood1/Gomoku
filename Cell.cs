using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Cell:Button
    {
        public int Ri, Ci;
        public bool Occupied;
        public int OccupierID;
        public Cell(int h, int w)
        {
            Occupied = false;
            OccupierID = -1;
            this.Height = h;
            this.Width = w;
        }
    }
}
