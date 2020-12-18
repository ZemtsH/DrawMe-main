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
using DrawMe.Actions;

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

        IAction _action;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            Canvas.Instanse.Height = pictureBox1.Height;
            Canvas.Instanse.Width = pictureBox1.Width;
            Canvas.Instanse._figures = new List<AbstractFigure>();
            
            _crntColor = Color.Black;
            _crntWidth = 5;
            _figures = new List<AbstractFigure>();

            _factory = new BrushFactory(); // на старте задаем кисть 
            _action = new DrawAction();

            pen = new Pen(_crntColor, _crntWidth); // хз это наверно вообще не нужно
            prev = new Point(0, 0);
            _MD = false;
            action = "Draw";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_MD && _crntFigure != null)
            {
                var actionParameter = new ActionParamter()
                {
                    Color = _crntColor,
                    Point = e.Location,
                    Width = _crntWidth,
                    Factory = _factory
                };

                pictureBox1.Image = _action.OnMouseMove(_crntFigure, actionParameter);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var actionParameter = new ActionParamter()
            {
                Color = _crntColor,
                Point = e.Location,
                Width = _crntWidth,
                Factory = _factory
            };

            _action.OnMouseDown(out _crntFigure, actionParameter);
            pictureBox1.Image = Canvas.Instanse.GetTempBitmap();

            _MD = true;
            switch (action)
            {
                case "ChangeP":
                    _crntFigure = null;
                    foreach (AbstractFigure figure in _figures)
                    {
                       if (figure.CheckFigure(e.Location))
                            {
                                _crntFigure = figure;
                                _figures.Remove(_crntFigure);
                                DrawAll();
                            for (int p = 0; p < _crntFigure.Points.Count(); p++)
                            {
                                if (_crntFigure.CheckFigurePoint(_crntFigure.Points[p], e.Location))
                                {

                                    break;
                                }
                            }   
                                pictureBox1.Image = Canvas.Instanse.GetTempBitmap();
                                break;
                            }
                        
                    }
                        break;
            }
            
        }

        private void DrawAll()
        {
            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));


            foreach (AbstractFigure figure in Canvas.Instanse._figures)
            {
                var bitmap = figure.Mover.MoveFigure(figure.Color, figure.Width, figure.Points.ToArray());
                Canvas.Instanse.SetBitmap(bitmap);
                
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            _MD = false;
            
          
            if (_crntFigure != null && _crntFigure.CheckDraw())
            {
                //_figures.Add(_crntFigure);
                Canvas.Instanse.AddFigure(_crntFigure);
                //_figures = Canvas.Instanse._figures;
            }
            Canvas.Instanse.SetBitmap(Canvas.Instanse.GetTempBitmap());
        }

        private void rightTraingle_Click(object sender, EventArgs e)
        {
            _factory = new RightTraingleFactory();
            action = "Draw";
            _action = new DrawAction();
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
            _action = new DrawAction();

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
            _action = new MoveAction();
        }

        private void line_Click(object sender, EventArgs e)
        {
            _factory = new LineFactory();
            _action = new DrawAction();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            action = "ChangeColor";
            _action = new ChangeColorAction();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _factory = new SquareFactory();
            _action = new MoveAction();
            action = "Draw";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _factory = new BrushFactory();
            action = "Draw";
            _action = new DrawAction();
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

        private void rotate_Click(object sender, EventArgs e)
        {
            action = "ChangeP";
            Canvas.Instanse.SetTempBitmap();
            Graphics graphics = Graphics.FromImage(Canvas.Instanse.GetTempBitmap());
            Pen pen = new Pen(Color.Red, 3);
            foreach (AbstractFigure abs in _figures)
            {
                if (!(abs is BrushFigure)) 
                {
                    for (int p = 0; p < abs.Points.Count(); p++)
                    {
                        graphics.DrawEllipse(pen, abs.Points[p].X, abs.Points[p].Y, 2, 2);
                    }
                }
            }
            pictureBox1.Image = Canvas.Instanse.GetTempBitmap();
        }
    }
}
