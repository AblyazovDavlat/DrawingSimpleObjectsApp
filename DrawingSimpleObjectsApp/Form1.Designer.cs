namespace DrawingSimpleObjectsApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.triangleRadio = new System.Windows.Forms.RadioButton();
            this.circleRadio = new System.Windows.Forms.RadioButton();
            this.lineRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.yellowRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusCircle = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthLine = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.squareSide = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.y3Triangle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.x3Triangle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.y2Triangle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.x2Triangle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.y1Triangle = new System.Windows.Forms.TextBox();
            this.x1Triangle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 381);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.squareRadio);
            this.groupBox1.Controls.Add(this.triangleRadio);
            this.groupBox1.Controls.Add(this.circleRadio);
            this.groupBox1.Controls.Add(this.lineRadio);
            this.groupBox1.Location = new System.Drawing.Point(618, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(109, 44);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(59, 17);
            this.squareRadio.TabIndex = 3;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            this.squareRadio.CheckedChanged += new System.EventHandler(this.radioFigure_CheckedChanged);
            // 
            // triangleRadio
            // 
            this.triangleRadio.AutoSize = true;
            this.triangleRadio.Location = new System.Drawing.Point(108, 20);
            this.triangleRadio.Name = "triangleRadio";
            this.triangleRadio.Size = new System.Drawing.Size(63, 17);
            this.triangleRadio.TabIndex = 2;
            this.triangleRadio.TabStop = true;
            this.triangleRadio.Text = "Triangle";
            this.triangleRadio.UseVisualStyleBackColor = true;
            this.triangleRadio.CheckedChanged += new System.EventHandler(this.radioFigure_CheckedChanged);
            // 
            // circleRadio
            // 
            this.circleRadio.AutoSize = true;
            this.circleRadio.Location = new System.Drawing.Point(17, 44);
            this.circleRadio.Name = "circleRadio";
            this.circleRadio.Size = new System.Drawing.Size(51, 17);
            this.circleRadio.TabIndex = 1;
            this.circleRadio.TabStop = true;
            this.circleRadio.Text = "Circle";
            this.circleRadio.UseVisualStyleBackColor = true;
            this.circleRadio.CheckedChanged += new System.EventHandler(this.radioFigure_CheckedChanged);
            // 
            // lineRadio
            // 
            this.lineRadio.AutoSize = true;
            this.lineRadio.Location = new System.Drawing.Point(17, 20);
            this.lineRadio.Name = "lineRadio";
            this.lineRadio.Size = new System.Drawing.Size(45, 17);
            this.lineRadio.TabIndex = 0;
            this.lineRadio.TabStop = true;
            this.lineRadio.Text = "Line";
            this.lineRadio.UseVisualStyleBackColor = true;
            this.lineRadio.CheckedChanged += new System.EventHandler(this.radioFigure_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.blueRadio);
            this.groupBox2.Controls.Add(this.yellowRadio);
            this.groupBox2.Controls.Add(this.greenRadio);
            this.groupBox2.Controls.Add(this.redRadio);
            this.groupBox2.Location = new System.Drawing.Point(618, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.ForeColor = System.Drawing.Color.Blue;
            this.blueRadio.Location = new System.Drawing.Point(109, 44);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(46, 17);
            this.blueRadio.TabIndex = 3;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue";
            this.blueRadio.UseVisualStyleBackColor = true;
            this.blueRadio.CheckedChanged += new System.EventHandler(this.colorPen_CheckedChanged);
            // 
            // yellowRadio
            // 
            this.yellowRadio.AutoSize = true;
            this.yellowRadio.ForeColor = System.Drawing.Color.Yellow;
            this.yellowRadio.Location = new System.Drawing.Point(17, 44);
            this.yellowRadio.Name = "yellowRadio";
            this.yellowRadio.Size = new System.Drawing.Size(56, 17);
            this.yellowRadio.TabIndex = 2;
            this.yellowRadio.TabStop = true;
            this.yellowRadio.Text = "Yellow";
            this.yellowRadio.UseVisualStyleBackColor = true;
            this.yellowRadio.CheckedChanged += new System.EventHandler(this.colorPen_CheckedChanged);
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenRadio.Location = new System.Drawing.Point(109, 20);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(54, 17);
            this.greenRadio.TabIndex = 1;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green";
            this.greenRadio.UseVisualStyleBackColor = true;
            this.greenRadio.CheckedChanged += new System.EventHandler(this.colorPen_CheckedChanged);
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.ForeColor = System.Drawing.Color.Red;
            this.redRadio.Location = new System.Drawing.Point(17, 20);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(45, 17);
            this.redRadio.TabIndex = 0;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red";
            this.redRadio.UseVisualStyleBackColor = true;
            this.redRadio.CheckedChanged += new System.EventHandler(this.colorPen_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radiusCircle);
            this.groupBox3.Location = new System.Drawing.Point(618, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // radiusCircle
            // 
            this.radiusCircle.Location = new System.Drawing.Point(7, 20);
            this.radiusCircle.Name = "radiusCircle";
            this.radiusCircle.Size = new System.Drawing.Size(66, 20);
            this.radiusCircle.TabIndex = 0;
            this.radiusCircle.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lengthLine);
            this.groupBox4.Location = new System.Drawing.Point(737, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 54);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "length";
            // 
            // lengthLine
            // 
            this.lengthLine.Location = new System.Drawing.Point(9, 20);
            this.lengthLine.Name = "lengthLine";
            this.lengthLine.Size = new System.Drawing.Size(43, 20);
            this.lengthLine.TabIndex = 0;
            this.lengthLine.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.squareSide);
            this.groupBox5.Location = new System.Drawing.Point(618, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 54);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Square";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // squareSide
            // 
            this.squareSide.Location = new System.Drawing.Point(9, 20);
            this.squareSide.Name = "squareSide";
            this.squareSide.Size = new System.Drawing.Size(43, 20);
            this.squareSide.TabIndex = 0;
            this.squareSide.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.y3Triangle);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.x3Triangle);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.y2Triangle);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.x2Triangle);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.y1Triangle);
            this.groupBox6.Controls.Add(this.x1Triangle);
            this.groupBox6.Location = new System.Drawing.Point(618, 306);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 87);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Triangle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "y3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 23;
            // 
            // y3Triangle
            // 
            this.y3Triangle.Location = new System.Drawing.Point(151, 46);
            this.y3Triangle.Name = "y3Triangle";
            this.y3Triangle.Size = new System.Drawing.Size(43, 20);
            this.y3Triangle.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "x3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 20;
            // 
            // x3Triangle
            // 
            this.x3Triangle.Location = new System.Drawing.Point(151, 20);
            this.x3Triangle.Name = "x3Triangle";
            this.x3Triangle.Size = new System.Drawing.Size(43, 20);
            this.x3Triangle.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "y2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 17;
            // 
            // y2Triangle
            // 
            this.y2Triangle.Location = new System.Drawing.Point(82, 46);
            this.y2Triangle.Name = "y2Triangle";
            this.y2Triangle.Size = new System.Drawing.Size(43, 20);
            this.y2Triangle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "x2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 14;
            // 
            // x2Triangle
            // 
            this.x2Triangle.Location = new System.Drawing.Point(83, 20);
            this.x2Triangle.Name = "x2Triangle";
            this.x2Triangle.Size = new System.Drawing.Size(43, 20);
            this.x2Triangle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "x1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // y1Triangle
            // 
            this.y1Triangle.Location = new System.Drawing.Point(9, 46);
            this.y1Triangle.Name = "y1Triangle";
            this.y1Triangle.Size = new System.Drawing.Size(43, 20);
            this.y1Triangle.TabIndex = 10;
            // 
            // x1Triangle
            // 
            this.x1Triangle.Location = new System.Drawing.Point(9, 20);
            this.x1Triangle.Name = "x1Triangle";
            this.x1Triangle.Size = new System.Drawing.Size(43, 20);
            this.x1Triangle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 404);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.RadioButton triangleRadio;
        private System.Windows.Forms.RadioButton circleRadio;
        private System.Windows.Forms.RadioButton lineRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.RadioButton yellowRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radiusCircle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox squareSide;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x1Triangle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox y3Triangle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox x3Triangle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox y2Triangle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox x2Triangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox y1Triangle;
    }
}

