﻿namespace DrawMe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rightTraingle = new System.Windows.Forms.Button();
            this.isoscelesTraingle = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.whiteSmoke = new System.Windows.Forms.Button();
            this.silver = new System.Windows.Forms.Button();
            this.dimGray = new System.Windows.Forms.Button();
            this.gainsboro = new System.Windows.Forms.Button();
            this.darkGray = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.lightGray = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.mover = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.changeColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(355, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 655);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кисть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(12, 176);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(192, 49);
            this.line.TabIndex = 2;
            this.line.Text = "Линия";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ломанная";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Прямоугольник";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Квадрат";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "Окружность";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 451);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "Эллипс";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 506);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 49);
            this.button8.TabIndex = 8;
            this.button8.Text = "Треугольник по трем";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // rightTraingle
            // 
            this.rightTraingle.Location = new System.Drawing.Point(12, 562);
            this.rightTraingle.Name = "rightTraingle";
            this.rightTraingle.Size = new System.Drawing.Size(192, 49);
            this.rightTraingle.TabIndex = 9;
            this.rightTraingle.Text = "Треугольник 90";
            this.rightTraingle.UseVisualStyleBackColor = true;
            this.rightTraingle.Click += new System.EventHandler(this.rightTraingle_Click);
            // 
            // isoscelesTraingle
            // 
            this.isoscelesTraingle.Location = new System.Drawing.Point(12, 617);
            this.isoscelesTraingle.Name = "isoscelesTraingle";
            this.isoscelesTraingle.Size = new System.Drawing.Size(192, 49);
            this.isoscelesTraingle.TabIndex = 10;
            this.isoscelesTraingle.Text = "Равнобедренный";
            this.isoscelesTraingle.UseVisualStyleBackColor = true;
            this.isoscelesTraingle.Click += new System.EventHandler(this.isoscelesTraingle_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 672);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 49);
            this.button11.TabIndex = 11;
            this.button11.Text = "N-угольник";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 727);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(192, 49);
            this.button12.TabIndex = 12;
            this.button12.Text = "Правильный N-угольник";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 632);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.HotPink;
            this.clear.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(1081, 31);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(145, 59);
            this.clear.TabIndex = 14;
            this.clear.Text = "Начини всё с чистого листа";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Панель инструментов:";
            // 
            // whiteSmoke
            // 
            this.whiteSmoke.BackColor = System.Drawing.Color.WhiteSmoke;
            this.whiteSmoke.Location = new System.Drawing.Point(285, 176);
            this.whiteSmoke.Name = "whiteSmoke";
            this.whiteSmoke.Size = new System.Drawing.Size(52, 49);
            this.whiteSmoke.TabIndex = 16;
            this.whiteSmoke.UseVisualStyleBackColor = false;
            this.whiteSmoke.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // silver
            // 
            this.silver.BackColor = System.Drawing.Color.Silver;
            this.silver.Location = new System.Drawing.Point(285, 341);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(52, 49);
            this.silver.TabIndex = 17;
            this.silver.UseVisualStyleBackColor = false;
            this.silver.Click += new System.EventHandler(this.silver_Click);
            // 
            // dimGray
            // 
            this.dimGray.BackColor = System.Drawing.Color.DimGray;
            this.dimGray.Location = new System.Drawing.Point(285, 506);
            this.dimGray.Name = "dimGray";
            this.dimGray.Size = new System.Drawing.Size(52, 49);
            this.dimGray.TabIndex = 18;
            this.dimGray.UseVisualStyleBackColor = false;
            this.dimGray.Click += new System.EventHandler(this.dimGray_Click);
            // 
            // gainsboro
            // 
            this.gainsboro.BackColor = System.Drawing.Color.Gainsboro;
            this.gainsboro.Location = new System.Drawing.Point(285, 231);
            this.gainsboro.Name = "gainsboro";
            this.gainsboro.Size = new System.Drawing.Size(52, 49);
            this.gainsboro.TabIndex = 19;
            this.gainsboro.UseVisualStyleBackColor = false;
            this.gainsboro.Click += new System.EventHandler(this.gainsboro_Click);
            // 
            // darkGray
            // 
            this.darkGray.BackColor = System.Drawing.Color.DarkGray;
            this.darkGray.Location = new System.Drawing.Point(285, 396);
            this.darkGray.Name = "darkGray";
            this.darkGray.Size = new System.Drawing.Size(52, 49);
            this.darkGray.TabIndex = 20;
            this.darkGray.UseVisualStyleBackColor = false;
            this.darkGray.Click += new System.EventHandler(this.darkGray_Click);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Gray;
            this.gray.Location = new System.Drawing.Point(285, 451);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(52, 49);
            this.gray.TabIndex = 21;
            this.gray.UseVisualStyleBackColor = false;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // lightGray
            // 
            this.lightGray.BackColor = System.Drawing.Color.LightGray;
            this.lightGray.Location = new System.Drawing.Point(285, 286);
            this.lightGray.Name = "lightGray";
            this.lightGray.Size = new System.Drawing.Size(52, 49);
            this.lightGray.TabIndex = 22;
            this.lightGray.UseVisualStyleBackColor = false;
            this.lightGray.Click += new System.EventHandler(this.lightGray_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(227, 562);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(52, 49);
            this.white.TabIndex = 23;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(285, 562);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(52, 49);
            this.black.TabIndex = 24;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(285, 121);
            this.widthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(48, 22);
            this.widthBox.TabIndex = 25;
            this.widthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // mover
            // 
            this.mover.Location = new System.Drawing.Point(355, 42);
            this.mover.Name = "mover";
            this.mover.Size = new System.Drawing.Size(192, 49);
            this.mover.TabIndex = 26;
            this.mover.Text = "Двигай";
            this.mover.UseVisualStyleBackColor = true;
            this.mover.Click += new System.EventHandler(this.mover_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(576, 42);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(192, 49);
            this.rotate.TabIndex = 27;
            this.rotate.Text = "Вращай";
            this.rotate.UseVisualStyleBackColor = true;
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(793, 42);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(192, 49);
            this.changeColor.TabIndex = 28;
            this.changeColor.Text = "Меняй цвет";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1238, 638);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.mover);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.black);
            this.Controls.Add(this.white);
            this.Controls.Add(this.lightGray);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.darkGray);
            this.Controls.Add(this.gainsboro);
            this.Controls.Add(this.dimGray);
            this.Controls.Add(this.silver);
            this.Controls.Add(this.whiteSmoke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.isoscelesTraingle);
            this.Controls.Add(this.rightTraingle);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.line);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button rightTraingle;
        private System.Windows.Forms.Button isoscelesTraingle;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button whiteSmoke;
        private System.Windows.Forms.Button silver;
        private System.Windows.Forms.Button dimGray;
        private System.Windows.Forms.Button gainsboro;
        private System.Windows.Forms.Button darkGray;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button lightGray;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.Button mover;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button changeColor;
    }
}

