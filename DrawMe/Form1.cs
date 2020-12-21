﻿using DrawMe.Factory;
using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawMe.Canvases;

namespace DrawMe
{
    public partial class Form1 : Form
    {
        Bitmap _mainBM;
        Bitmap _tmpBM;

        AbstractFigure _crntFigure;
        Color _crntColor;
        int _crntWidth;
        List<AbstractFigure> _figures;
        IFactory _factory;
        Graphics graphics;

        string action;
        Pen pen;
        Point prev;
        bool _MD;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_mainBM = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            
            
            
            //_tmpBM = (Bitmap)_mainBM.Clone();
            _crntColor = Color.Black;
            _crntWidth = 1;
            _figures = new List<AbstractFigure>();

            _factory = new BrushFactory(); // на старте задаем кисть 

            pen = new Pen(_crntColor, _crntWidth); // хз это наверно вообще не нужно
            prev = new Point(0, 0);
            _MD = false;
            action = "Draw";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_MD && _crntFigure != null)
            {
                switch (action)
                {
                    case "Draw":
                        pictureBox1.Image = Canvas.Instanse.GetBitmap();
                        pictureBox1.Image = _crntFigure.Draw(e.Location);
                        break;
                    case "Mover":
                        //pictureBox1.Image = Canvas.Instanse.GetBitmap();
                        pictureBox1.Image= _crntFigure.Move(e.Location);
                        break;
                }
                //pictureBox1.Image = Canvas.Instanse.GetBitmap();
                //pictureBox1.Image = Canvas.Instanse.GetTempBitmap();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _MD = true;
            switch (action)
            {
                case "Draw":
                    _crntFigure = _factory.CreateFigure();
                    _crntFigure.Color = _crntColor;
                    _crntFigure.Width = _crntWidth;
                    _crntFigure.DoStart(e.Location);
                    break;
                case "Mover":
                    
                    _crntFigure = null;
                    foreach (AbstractFigure figure in _figures)
                    {
                        if (figure.CheckFigure(e.Location))
                        {
                            _crntFigure = figure;
                            _figures.Remove(_crntFigure);
                            DrawAll();
                            _crntFigure.DoStart(e.Location);
                            break;
                        }
                    }
                    break;
                case "ChangeColor":
                    _figures.Remove(_crntFigure);
                    DrawAll();
                    _crntFigure.ChangeColor(_crntColor, _mainBM);
                    pictureBox1.Image = _crntFigure.ShowBit();
                    break;
            }
            
        }

        private void DrawAll()
        {
            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));


            foreach (AbstractFigure figure in _figures)
            {
                Canvas.Instanse.SetBitmap(_crntFigure.drawing.DrawFigure(figure.Color, figure.Width, figure.Points.ToArray()));
                
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            _MD = false;
            
          
            if (_crntFigure != null && _crntFigure.CheckDraw())
            {
                _figures.Add(_crntFigure);
            }
            Canvas.Instanse.SetBitmap(Canvas.Instanse.GetTempBitmap());
        }

        private void rightTraingle_Click(object sender, EventArgs e)
        {
            _factory = new RightTraingleFactory();
            action = "Draw";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _factory = new RectangleFactory();
            action = "Draw";
            //_crntFigure = new RectangleFigure();
            //_crntFigure.Color = _crntColor;
            //_crntFigure.Width = _crntWidth;
        }

        private void isoscelesTraingle_Click(object sender, EventArgs e)
        {
            _factory = new IsoscelesTraingleFactory();
            action = "Draw";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            pictureBox1.Image = Canvas.Instanse.GetBitmap();
            _figures = new List<AbstractFigure>();
        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            _crntWidth = (int)widthBox.Value;
        }

        private void mover_Click(object sender, EventArgs e)
        {
            action = "Mover";
        }

        private void line_Click(object sender, EventArgs e)
        {
            _factory = new LineFactory();
            action = "Draw";
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            action = "ChangeColor";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _factory = new SquareFactory();
            action = "Draw";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Color
        private void whiteSmoke_Click(object sender, EventArgs e)
        {
            _crntColor = Color.WhiteSmoke;
        }

        private void gainsboro_Click(object sender, EventArgs e)
        {
            _crntColor = Color.Gainsboro;
        }

        private void lightGray_Click(object sender, EventArgs e)
        {
            _crntColor = Color.LightGray;
        }

        private void silver_Click(object sender, EventArgs e)
        {
            _crntColor = Color.Silver;
        }

        private void darkGray_Click(object sender, EventArgs e)
        {
            _crntColor = Color.DarkGray;
        }

        private void gray_Click(object sender, EventArgs e)
        {
            _crntColor = Color.Gray;
        }

        private void dimGray_Click(object sender, EventArgs e)
        {
            _crntColor = Color.DimGray;
        }

        private void black_Click(object sender, EventArgs e)
        {
            _crntColor = Color.Black;
        }

        private void white_Click(object sender, EventArgs e)
        {
            _crntColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _factory = new CircleFactory();
            action = "Draw";
        }
    }
}
