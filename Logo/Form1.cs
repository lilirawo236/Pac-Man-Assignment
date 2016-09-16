﻿/*This program was created by Lily Raworth Marshall in September, 2016
for the purpose of a school project in ICS3U*/
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

            /*Refresh(); //new screen and the countdown starts at 3
            countdownBox.Text = "The game will start in: 3";
            Thread.Sleep(1000);

            Refresh(); //countdown is at 2
            countdownBox.Text = "The game will start in: 2";
            Thread.Sleep(1000);

            Refresh(); //countdown is at 1
            countdownBox.Text = "The game will start in: 1";
            Thread.Sleep(1000);

            Refresh();
            countdownBox.Text = "The game will start in: 0"; //it won't actually
            Thread.Sleep(1000);*/ //show the count of zero
            this.BackColor = Color.MidnightBlue;

            Refresh(); //the countdown text disappears
            countdownBox.Visible = false;

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 5);
            Pen drawPen2 = new Pen(Color.Black, 3);
            SolidBrush drawBrush = new SolidBrush (Color.FloralWhite);
            SolidBrush drawBrush2 = new SolidBrush(Color.MidnightBlue);

            formGraphics.DrawEllipse(drawPen, 87, 60, 200, 200);
            formGraphics.FillEllipse(drawBrush, 87, 60, 200, 200);
            formGraphics.FillEllipse(drawBrush2, 85, 80, 150, 150);
            formGraphics.DrawEllipse(drawPen2, 85, 80, 150, 150);
            formGraphics.FillRectangle(drawBrush2, 60, 110, 50, 70);

            Font drawFont = new Font("Segoe Script", 20, FontStyle.Regular);
            Thread.Sleep(3000);

            formGraphics.Clear(Color.White);
        }
    }
}
