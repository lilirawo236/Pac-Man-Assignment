/*This program was created by Lily Raworth Marshall in September, 2016
for the purpose of a school project in ICS3U*/
//still missing a sound
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Logo
{
    public partial class window1 : Form
    {
        public window1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false; //makes start button disappear
            this.BackColor = Color.White; //changes it to loading screen

            Refresh(); //new screen and the countdown starts at 3
            countdownBox.Text = "The game will start in: 3";
            Thread.Sleep(1000);

            Refresh(); //countdown is at 2
            countdownBox.Text = "The game will start in: 2";
            Thread.Sleep(1000);

            Refresh(); //countdown is at 1
            countdownBox.Text = "The game will start in: 1";
            Thread.Sleep(1000);

            Refresh();
            countdownBox.Text = "The game will start in: 0"; //it won't actually show the count of zero
            Thread.Sleep(1000);
            this.BackColor = Color.Black; //changing the background colour for the logo

            Refresh(); //the countdown text disappears
            countdownBox.Visible = false;

            Graphics formGraphics = this.CreateGraphics(); //creating two pens and two brushes
            Graphics fg = this.CreateGraphics(); //creates graphics for font later
            Pen drawPen = new Pen(Color.Black, 5); //first pen used for the logo (thicker, outside lines)
            Pen drawPen2 = new Pen(Color.Black, 3); //second pen used for logo (thinner, inside lines)
            SolidBrush drawBrush = new SolidBrush (Color.FloralWhite);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);

            formGraphics.DrawEllipse(drawPen, 87, 60, 200, 200); //setting up the moon shape
            formGraphics.FillEllipse(drawBrush, 87, 60, 200, 200);
            formGraphics.FillEllipse(drawBrush2, 85, 80, 150, 150); //inside of moon

            Font drawFont = new Font("Segoe Script", 110, FontStyle.Regular); //creating a font for inside of letter
            SolidBrush drawBrushFont = new SolidBrush(Color.FloralWhite); //created brush for the font

            fg.DrawString("L", drawFont, drawBrushFont, 85, 43); //creates letter for logo
            Thread.Sleep(3000); //waiting a few seconds before the logo dissapears

            formGraphics.Clear(Color.White); //clears screen for animation
            SolidBrush drawBrushFont2 = new SolidBrush(Color.Black);
            Font drawFont2 = new Font("Rockwell", 100, FontStyle.Underline); //new font for after logo (moved down for easier editing)
            fg.DrawString("Go!", drawFont2, drawBrushFont2, 55, 65);
            Thread.Sleep(2000);

            formGraphics.Clear(Color.Black); //clears screen for pac-man animation
            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow); //new brush for drawing pac-man
            formGraphics.FillPie(drawBrush3, 40, 230, 50, 50, 30, 300); //actually drawing pac-man
            formGraphics.FillEllipse(drawBrush, 120, 247, 15, 15); //drawing the dots
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 55, 230, 50, 50, 50, 280);
            formGraphics.FillEllipse(drawBrush, 120, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 70, 230, 50, 50, 70, 260);
            formGraphics.FillEllipse(drawBrush, 120, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 85, 230, 50, 50, 50, 280);
            formGraphics.FillEllipse(drawBrush, 120, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 100, 230, 50, 50, 30, 300);
            //got rid of a line of code (pac-man has now eaten the first dot)
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 115, 230, 50, 50, 10, 320);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 130, 230, 50, 50, 350, 340);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 145, 230, 50, 50, 0, 360);
            formGraphics.FillEllipse(drawBrush, 200, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 160, 230, 50, 50, 350, 340);
            //got rid of a line of code (pac-man has eaten the second dot)
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 175, 230, 50, 50, 10, 320);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(drawBrush3, 190, 230, 50, 50, 30, 300);
            formGraphics.FillEllipse(drawBrush, 280, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 87, 15, 15);
            formGraphics.FillEllipse(drawBrush, 280, 7, 15, 15);
            Thread.Sleep(500);

        }
    }
}
