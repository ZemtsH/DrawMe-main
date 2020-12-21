namespace DrawMe
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
            this.brush = new System.Windows.Forms.Button();
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
            this.movePoint = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(355, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 655);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // brush
            // 
            this.brush.Location = new System.Drawing.Point(12, 121);
            this.brush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(192, 49);
            this.brush.TabIndex = 1;
            this.brush.Text = "Кисть";
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(12, 176);
            this.line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ломанная";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 286);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Квадрат";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 396);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "Окружность";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 450);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "Эллипс";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 506);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 49);
            this.button8.TabIndex = 8;
            this.button8.Text = "Треугольник по трем";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // rightTraingle
            // 
            this.rightTraingle.Location = new System.Drawing.Point(12, 562);
            this.rightTraingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.isoscelesTraingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(192, 49);
            this.button12.TabIndex = 12;
            this.button12.Text = "Правильный N-угольник";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.HotPink;
            this.clear.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(1221, 28);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 64);
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
            this.whiteSmoke.Location = new System.Drawing.Point(253, 142);
            this.whiteSmoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.whiteSmoke.Name = "whiteSmoke";
            this.whiteSmoke.Size = new System.Drawing.Size(45, 39);
            this.whiteSmoke.TabIndex = 16;
            this.whiteSmoke.UseVisualStyleBackColor = false;
            this.whiteSmoke.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // silver
            // 
            this.silver.BackColor = System.Drawing.Color.Silver;
            this.silver.Location = new System.Drawing.Point(253, 273);
            this.silver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(45, 39);
            this.silver.TabIndex = 17;
            this.silver.UseVisualStyleBackColor = false;
            this.silver.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // dimGray
            // 
            this.dimGray.BackColor = System.Drawing.Color.DimGray;
            this.dimGray.Location = new System.Drawing.Point(253, 405);
            this.dimGray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dimGray.Name = "dimGray";
            this.dimGray.Size = new System.Drawing.Size(45, 39);
            this.dimGray.TabIndex = 18;
            this.dimGray.UseVisualStyleBackColor = false;
            this.dimGray.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // gainsboro
            // 
            this.gainsboro.BackColor = System.Drawing.Color.Gainsboro;
            this.gainsboro.Location = new System.Drawing.Point(253, 185);
            this.gainsboro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gainsboro.Name = "gainsboro";
            this.gainsboro.Size = new System.Drawing.Size(45, 39);
            this.gainsboro.TabIndex = 19;
            this.gainsboro.UseVisualStyleBackColor = false;
            this.gainsboro.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // darkGray
            // 
            this.darkGray.BackColor = System.Drawing.Color.DarkGray;
            this.darkGray.Location = new System.Drawing.Point(253, 318);
            this.darkGray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkGray.Name = "darkGray";
            this.darkGray.Size = new System.Drawing.Size(45, 39);
            this.darkGray.TabIndex = 20;
            this.darkGray.UseVisualStyleBackColor = false;
            this.darkGray.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Gray;
            this.gray.Location = new System.Drawing.Point(253, 361);
            this.gray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(45, 39);
            this.gray.TabIndex = 21;
            this.gray.UseVisualStyleBackColor = false;
            this.gray.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // lightGray
            // 
            this.lightGray.BackColor = System.Drawing.Color.LightGray;
            this.lightGray.Location = new System.Drawing.Point(253, 229);
            this.lightGray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lightGray.Name = "lightGray";
            this.lightGray.Size = new System.Drawing.Size(45, 39);
            this.lightGray.TabIndex = 22;
            this.lightGray.UseVisualStyleBackColor = false;
            this.lightGray.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(203, 450);
            this.white.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(45, 39);
            this.white.TabIndex = 23;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(253, 450);
            this.black.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(45, 39);
            this.black.TabIndex = 24;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.whiteSmoke_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(253, 97);
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
            5,
            0,
            0,
            0});
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // mover
            // 
            this.mover.Location = new System.Drawing.Point(355, 11);
            this.mover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mover.Name = "mover";
            this.mover.Size = new System.Drawing.Size(192, 49);
            this.mover.TabIndex = 26;
            this.mover.Text = "Двигай";
            this.mover.UseVisualStyleBackColor = true;
            this.mover.Click += new System.EventHandler(this.mover_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(572, 11);
            this.rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(192, 49);
            this.rotate.TabIndex = 27;
            this.rotate.Text = "Залей";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(791, 11);
            this.changeColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(192, 49);
            this.changeColor.TabIndex = 28;
            this.changeColor.Text = "Меняй цвет";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // movePoint
            // 
            this.movePoint.Location = new System.Drawing.Point(355, 70);
            this.movePoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movePoint.Name = "movePoint";
            this.movePoint.Size = new System.Drawing.Size(192, 49);
            this.movePoint.TabIndex = 29;
            this.movePoint.Text = "Двигай углы";
            this.movePoint.UseVisualStyleBackColor = true;
            this.movePoint.Click += new System.EventHandler(this.movePoint_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1000, 68);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(192, 49);
            this.save.TabIndex = 30;
            this.save.Text = "Сохрани";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(1000, 11);
            this.load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(192, 49);
            this.load.TabIndex = 31;
            this.load.Text = "Загрузи";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(791, 70);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(192, 49);
            this.width.TabIndex = 32;
            this.width.Text = "Меняй толщину";
            this.width.UseVisualStyleBackColor = true;
            this.width.Click += new System.EventHandler(this.width_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(572, 70);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(192, 49);
            this.delete.TabIndex = 33;
            this.delete.Text = "Удали";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1387, 801);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.width);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.movePoint);
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
            this.Controls.Add(this.brush);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button brush;
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
        private System.Windows.Forms.Button movePoint;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button width;
        private System.Windows.Forms.Button delete;
    }
}

