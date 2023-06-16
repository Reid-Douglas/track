using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track
{
    public partial class Form1 : Form
    {
        Pen blackPen = new Pen(Color.White, 5);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        SolidBrush blue = new SolidBrush(Color.Blue);
        Pen redPen = new Pen(Color.Red, 5);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        //list

        List<Rectangle> trackLimits = new List<Rectangle>();


        //check points

        Rectangle check1 = new Rectangle(480, 30, 7, 100);
        Rectangle redCheck = new Rectangle(530, 30, 7, 100);
        Rectangle check2 = new Rectangle(790, 30, 7, 100);
        Rectangle check3 = new Rectangle(865, 175, 100, 7);
        Rectangle check4 = new Rectangle(865, 540, 100, 7);
        Rectangle check5 = new Rectangle(790, 613, 7, 60);
        Rectangle check6 = new Rectangle(175, 613, 7, 60);
        Rectangle check7 = new Rectangle(15, 555, 80, 7);
        Rectangle check8 = new Rectangle(15, 395, 80, 7);
        Rectangle check9 = new Rectangle(175, 225, 7, 100);
        Rectangle check10 = new Rectangle(253, 395, 80, 7);
        Rectangle check11 = new Rectangle(450, 525, 7, 80);
        Rectangle check12 = new Rectangle(575, 450, 125, 7);
        Rectangle check13 = new Rectangle(575, 290, 120, 7);
        Rectangle check14 = new Rectangle(485, 150, 7, 70);
        Rectangle check15 = new Rectangle(125, 147, 7, 73);
        Rectangle check16 = new Rectangle(125, 33, 7, 105);



        public Form1()
        {
            InitializeComponent();
        }
        public void onStart()
        {
            trackLimits.Add(new Rectangle(0, 217, 500, 8));
            trackLimits.Add(new Rectangle(-5, 0, 9, 750));
            trackLimits.Add(new Rectangle(0, 210, 80, 20));
            trackLimits.Add(new Rectangle(978, 0, 984, 750));
            trackLimits.Add(new Rectangle(0, 683, 985, 749));
            trackLimits.Add(new Rectangle(0, -5, 985, 28));
            trackLimits.Add(new Rectangle(713, 185, 135, 360));
            trackLimits.Add(new Rectangle(113, 380, 125, 180));
            trackLimits.Add(new Rectangle(5, 0, 30, 60));
            trackLimits.Add(new Rectangle(-10, 0, 25, 225));
            trackLimits.Add(new Rectangle(10, 175, 18, 40));
            trackLimits.Add(new Rectangle(350, 270, 210, 160));
            trackLimits.Add(new Rectangle(340, 227, 160, 35));
            trackLimits.Add(new Rectangle(280, 137, 515, 10));
            trackLimits.Add(new Rectangle(690, 149, 130, 38));
            trackLimits.Add(new Rectangle(958, 20, 40, 40));
            trackLimits.Add(new Rectangle(195, 603, 600, 3));
            trackLimits.Add(new Rectangle(150, 555, 110, 40));
            trackLimits.Add(new Rectangle(695, 550, 135, 40));
            trackLimits.Add(new Rectangle(600, 590, 210, 10));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 5);
            SolidBrush grayBrush = new SolidBrush(Color.Gray);

            g.DrawLine(blackPen, 0, 0, 300, 500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // start line
            // side one
            e.Graphics.FillRectangle(blackBrush, 487, 33, 25, 25);
            e.Graphics.FillRectangle(whiteBrush, 487, 58, 25, 25);
            e.Graphics.FillRectangle(blackBrush, 487, 83, 25, 25);
            e.Graphics.FillRectangle(whiteBrush, 487, 108, 25, 25);




            // side two
            e.Graphics.FillRectangle(whiteBrush,507,33,25, 25);
            e.Graphics.FillRectangle(blackBrush, 507, 58, 25, 25);
            e.Graphics.FillRectangle(whiteBrush, 507, 83, 25, 25);
            e.Graphics.FillRectangle(blackBrush, 507, 108, 25, 25);







            //racetrack
            e.Graphics.DrawLine(blackPen, 900, 675, 50, 675);
            e.Graphics.DrawLine(blackPen, 800, 610, 175, 610);
            e.Graphics.DrawLine(blackPen, 100, 565, 100, 400);
            e.Graphics.DrawLine(blackPen, 10, 635, 10, 300);
            e.Graphics.DrawLine(blackPen, 250, 525, 250, 400);
            e.Graphics.DrawLine(blackPen, 335, 300, 335, 450);
            e.Graphics.DrawLine(blackPen, 577, 350, 574, 450);
            e.Graphics.DrawLine(blackPen, 700, 250, 700, 525);
            e.Graphics.DrawLine(blackPen, 970, 600, 970, 125);
            e.Graphics.DrawLine(blackPen, 860, 550, 860, 175);
            e.Graphics.DrawLine(blackPen, 892, 30, 125, 30);
            e.Graphics.DrawLine(blackPen, 800, 130, 270, 130);
            e.Graphics.DrawLine(blackPen, 400, 155, 600, 155);
            e.Graphics.DrawLine(blackPen, 125, 215, 500, 215);
            e.Graphics.DrawLine(blackPen, 579, 300, 574, 450);
            e.Graphics.DrawArc(blackPen, 100, 510, 200, 100, 95, 83);
            e.Graphics.DrawArc(blackPen, 10, 580, 150, 100, 125, 57);
            e.Graphics.DrawArc(blackPen, 100, 325, 150, 150, 175, 190);
            e.Graphics.DrawArc(blackPen, 9, 225, 325, 150, 175, 185);
            e.Graphics.DrawArc(blackPen, 250, 448, 450, 150, 360, 180);
            e.Graphics.DrawArc(blackPen, 335, 348, 240, 180, 360, 180);
            e.Graphics.DrawArc(blackPen, 800, 546, 170, 130, -10, 90);
            e.Graphics.DrawArc(blackPen, 700, 480, 160, 130, -10, 90);
            e.Graphics.DrawArc(blackPen, 810, 30, 160, 210, -90, 90);
            e.Graphics.DrawArc(blackPen, 704, 130, 160, 140, -90, 75);
            e.Graphics.DrawArc(blackPen, 125, 130, 700, 25, 90, 180);
            e.Graphics.DrawArc(blackPen, 25, 30, 200, 185, 90, 180);
            e.Graphics.DrawArc(blackPen, 380, 214, 200, 185, -90, 90);
            e.Graphics.DrawArc(blackPen, 490, 155, 210, 191, -90, 90);


            // slow borders
            //e.Graphics.FillRectangle(solidBrush, 0, 217, 500, 8);
            //e.Graphics.FillRectangle(solidBrush, -5, 0, 9, 750);
            //e.Graphics.FillRectangle(solidBrush, 0, 210, 80, 20);
            //e.Graphics.FillRectangle(solidBrush, 978, 0, 984, 750);
            //e.Graphics.FillRectangle(solidBrush, 0, 683, 985, 749);
            //e.Graphics.FillRectangle(solidBrush, 0, -5, 985, 28);
            //e.Graphics.FillRectangle(solidBrush, 713, 185, 135, 360);
            //e.Graphics.FillRectangle(solidBrush, 113, 380, 125, 180);
            //e.Graphics.FillRectangle(solidBrush, 5, 0, 30, 60);
            //e.Graphics.FillRectangle(solidBrush, -10, 0, 25, 225);
            //e.Graphics.FillRectangle(solidBrush, 10, 175, 18, 40);
            //e.Graphics.FillRectangle(solidBrush, 350, 270, 210, 160);
            //e.Graphics.FillRectangle(solidBrush, 340, 227, 160, 35);
            //e.Graphics.FillRectangle(solidBrush, 280, 137, 515, 10);
            //e.Graphics.FillRectangle(solidBrush, 690, 149, 130, 38);
            //e.Graphics.FillRectangle(solidBrush, 958, 20, 40, 40);
            //e.Graphics.FillRectangle(solidBrush, 195, 603, 600, 3);
            //e.Graphics.FillRectangle(solidBrush, 150, 555, 110, 40);
            //e.Graphics.FillRectangle(solidBrush, 695, 550, 135, 40);
            //e.Graphics.FillRectangle(solidBrush, 600, 590, 210, 10);

            //check points
            //e.Graphics.FillRectangle(blue, 480, 30, 7, 100);
            //e.Graphics.FillRectangle(solidBrush,530,30,7,100);
            //e.Graphics.FillRectangle(blue, 790, 30, 7, 100);
            //e.Graphics.FillRectangle(blue, 865, 175, 100, 7);
            //e.Graphics.FillRectangle(blue, 865, 540, 100, 7);
            //e.Graphics.FillRectangle(blue, 790, 613, 7, 60);
            //e.Graphics.FillRectangle(blue, 175, 613, 7, 60);
            //e.Graphics.FillRectangle(blue, 15, 555, 80, 7);
            //e.Graphics.FillRectangle(blue, 15, 395, 80, 7);
            //e.Graphics.FillRectangle(blue, 175, 225, 7, 100);
            //e.Graphics.FillRectangle(blue, 253, 395, 80, 7);
            //e.Graphics.FillRectangle(blue, 450, 525, 7, 80);
            //e.Graphics.FillRectangle(blue, 575, 450, 125, 7);
            //e.Graphics.FillRectangle(blue, 575, 290, 120, 7);
            //e.Graphics.FillRectangle(blue, 485, 150, 7, 70);
            //e.Graphics.FillRectangle(blue, 125, 147, 7, 73);
            //e.Graphics.FillRectangle(blue, 125, 33, 7, 105);
        }

        
    }
}
   