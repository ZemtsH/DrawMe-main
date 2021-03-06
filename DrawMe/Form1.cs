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
        AbstractFigure _crntFigure;
        Color _crntColor;
        int _crntWidth;
        IFactory _factory;


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

            _factory = new BrushFactory(); // на старте задаем кисть 
            _action = new DrawAction();

// хз это наверно вообще не нужно
            _MD = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_MD && _crntFigure != null)
            {
                var actionParameter = new ActionParamter()
                {
                    Point = e.Location,
                };

                _action.OnMouseMove(_crntFigure, actionParameter);
                pictureBox1.Image = Canvas.Instanse.GetTempBitmap();
            }
        }

        //Actions
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
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _MD = false;
            _action.OnMouseUp(_crntFigure, new ActionParamter());
        }

        // parameter
        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            _crntWidth = (int)widthBox.Value;
        }

        private void whiteSmoke_Click(object sender, EventArgs e)
        {
            _crntColor = ((Button)sender).BackColor;
        }

        //figures
        private void rightTraingle_Click(object sender, EventArgs e)
        {
            _factory = new RightTraingleFactory();
            _action = new DrawAction();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _factory = new RectangleFactory();
            _action = new DrawAction();
        }

        private void isoscelesTraingle_Click(object sender, EventArgs e)
        {
            _factory = new IsoscelesTraingleFactory();
            _action = new DrawAction();

        }

        private void line_Click(object sender, EventArgs e)
        {
            _factory = new LineFactory();
            _action = new DrawAction();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _factory = new SquareFactory();
            _action = new DrawAction();
        }

        private void brush_Click(object sender, EventArgs e)
        {
            _factory = new BrushFactory();
            _action = new DrawAction();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _factory = new CircleFactory();
            _action = new DrawAction();
        }

        //clear
        private void clear_Click(object sender, EventArgs e)
        {
            Canvas.Instanse.SetBitmap(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            Canvas.Instanse.SetTempBitmap();
            Canvas.Instanse._figures = new List<AbstractFigure>();
            pictureBox1.Image = Canvas.Instanse.GetBitmap();
            _action = new DrawAction();
        }

        //actions
        private void mover_Click(object sender, EventArgs e)
        {
            _action = new MoveAction();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            _action = new ChangeColorAction();
        }


        private void rotate_Click(object sender, EventArgs e)
        {
            
        }

        private void movePoint_Click(object sender, EventArgs e)
        {
            _action = new MovePointAction();
        }

        private void width_Click(object sender, EventArgs e)
        {
            _action = new ChangeWidthAction();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            _action = new DeleteAction();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.ShowHelp = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName);
                       
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        Canvas.Instanse.SetBitmap(new Bitmap(openDialog.FileName));
                    Canvas.Instanse.SetTempBitmap();
                    pictureBox1.Image = Canvas.Instanse.GetBitmap();
                }
                catch
                {
                    MessageBox.Show("Не удалось", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
