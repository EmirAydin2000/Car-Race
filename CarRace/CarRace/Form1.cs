using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {          
            InitializeComponent();

            timer1.Interval = 5;
            timer1.Tick += new EventHandler(Timer1_Tick);            
        }

        private void BtnStartRace_Click(object sender, EventArgs e)
        {
            pbRedCar.Show();
            timer1.Start();           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Locations locations = new Locations();            
            CarSpeeds carSpeeds = new CarSpeeds();

            locations.RedCarLocationX = pbRedCar.Location.X;

            locations.RedCarLocationY = pbRedCar.Location.Y;

            locations.YellowCarLocationX = pbYellowCar.Location.X;

            locations.YellowCarLocationY = pbYellowCar.Location.Y;

            for (int i = 0; i < 2; i++)
            {
                carSpeeds.RedCarSpeed = RandomNumberGenerator_Counter.NumberBetween(1, 7);

                carSpeeds.YellowCarSpeed = RandomNumberGenerator_Counter.NumberBetween(1, 7);

                locations.MoveCar(pbRedCar, carSpeeds.RedCarSpeed, locations.RedCarLocationX, locations.RedCarLocationY);

                locations.MoveCar(pbYellowCar, carSpeeds.YellowCarSpeed, locations.YellowCarLocationX, locations.YellowCarLocationY);
            }

            locations.RedCarLocationX = pbRedCar.Location.X;

            locations.RedCarLocationY = pbRedCar.Location.Y;

            locations.YellowCarLocationX = pbYellowCar.Location.X;

            locations.YellowCarLocationY = pbYellowCar.Location.Y;

            if (locations.RedCarLocationX > pbFinishLine.Location.X || locations.YellowCarLocationX > pbFinishLine.Location.X)
            {
                timer1.Stop();
                if (locations.RedCarLocationX > locations.YellowCarLocationX)
                {
                    MessageBox.Show("Red Car WON!!!!!!");
                    pbYellowCar.Location = new Point(5, 122);

                    pbRedCar.Location = new Point(5, 14);

                    RandomNumberGenerator_Counter.CounterUpRed();

                    lblRedCar.Text = Convert.ToString(RandomNumberGenerator_Counter.CounterRed);
                }
                else
                {
                    MessageBox.Show("Yellow Car WON!!!!!!");
                    pbYellowCar.Location = new Point(5, 122);

                    pbRedCar.Location = new Point(5, 14);

                    RandomNumberGenerator_Counter.CounterUpYellow();

                    lblYellowCar.Text = Convert.ToString(RandomNumberGenerator_Counter.CounterYellow);
                }                
            }            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator_Counter.CounterYellow = 0;
            RandomNumberGenerator_Counter.CounterRed = 0;
            lblYellowCar.Text = Convert.ToString(RandomNumberGenerator_Counter.CounterYellow);
            lblRedCar.Text = Convert.ToString(RandomNumberGenerator_Counter.CounterRed);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
