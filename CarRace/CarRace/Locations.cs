using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Locations : Form1
    {
        public int RedCarLocationX { get; set; }
        public int RedCarLocationY { get; set; }
        public int YellowCarLocationX { get; set; }
        public int YellowCarLocationY { get; set; }

        public void MoveCar(System.Windows.Forms.PictureBox pictureBox, int speed, int locationX, int locationY)
        {
            pictureBox.Location = new Point(locationX + speed, locationY);
        }

    }
}
