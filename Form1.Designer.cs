
namespace ComGraph_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RTrack = new System.Windows.Forms.TrackBar();
            this.aTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label4 = new System.Windows.Forms.Label();
            this.yTrack = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.xTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.pointAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bTrack = new System.Windows.Forms.TrackBar();
            this.bTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(322, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 647);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPaint);
            // 
            // RTrack
            // 
            this.RTrack.Location = new System.Drawing.Point(58, 177);
            this.RTrack.Maximum = 200;
            this.RTrack.Name = "RTrack";
            this.RTrack.Size = new System.Drawing.Size(204, 45);
            this.RTrack.TabIndex = 1;
            this.RTrack.Value = 100;
            this.RTrack.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // aTrack
            // 
            this.aTrack.Location = new System.Drawing.Point(58, 228);
            this.aTrack.Minimum = 1;
            this.aTrack.Name = "aTrack";
            this.aTrack.Size = new System.Drawing.Size(204, 45);
            this.aTrack.TabIndex = 2;
            this.aTrack.Value = 3;
            this.aTrack.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "y";
            // 
            // yTrack
            // 
            this.yTrack.Location = new System.Drawing.Point(58, 126);
            this.yTrack.Maximum = 647;
            this.yTrack.Name = "yTrack";
            this.yTrack.Size = new System.Drawing.Size(204, 45);
            this.yTrack.TabIndex = 8;
            this.yTrack.Value = 323;
            this.yTrack.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "x";
            // 
            // xTrack
            // 
            this.xTrack.Location = new System.Drawing.Point(58, 75);
            this.xTrack.Maximum = 791;
            this.xTrack.Name = "xTrack";
            this.xTrack.Size = new System.Drawing.Size(204, 45);
            this.xTrack.TabIndex = 10;
            this.xTrack.Value = 395;
            this.xTrack.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вид уравнения: ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(215, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "x = R[(1-b)cos(bt)+ab*cos((1-b)t)]";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(216, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "y = R[(1-b)sin(bt)-ab*sin((1-b)t)]";
            // 
            // xTextBox
            // 
            this.xTextBox.Enabled = false;
            this.xTextBox.Location = new System.Drawing.Point(268, 75);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(38, 20);
            this.xTextBox.TabIndex = 15;
            // 
            // yTextBox
            // 
            this.yTextBox.Enabled = false;
            this.yTextBox.Location = new System.Drawing.Point(268, 126);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(38, 20);
            this.yTextBox.TabIndex = 16;
            // 
            // RTextBox
            // 
            this.RTextBox.Enabled = false;
            this.RTextBox.Location = new System.Drawing.Point(268, 177);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(38, 20);
            this.RTextBox.TabIndex = 17;
            // 
            // aTextBox
            // 
            this.aTextBox.Enabled = false;
            this.aTextBox.Location = new System.Drawing.Point(268, 228);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(38, 20);
            this.aTextBox.TabIndex = 18;
            // 
            // pointAmount
            // 
            this.pointAmount.Location = new System.Drawing.Point(152, 334);
            this.pointAmount.Name = "pointAmount";
            this.pointAmount.Size = new System.Drawing.Size(100, 20);
            this.pointAmount.TabIndex = 19;
            this.pointAmount.Text = "100";
            this.pointAmount.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "К-во точек";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(87, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 79);
            this.button1.TabIndex = 24;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.paintBtn);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bTrack
            // 
            this.bTrack.Location = new System.Drawing.Point(58, 279);
            this.bTrack.Maximum = 100;
            this.bTrack.Name = "bTrack";
            this.bTrack.Size = new System.Drawing.Size(204, 45);
            this.bTrack.TabIndex = 25;
            this.bTrack.Value = 10;
            this.bTrack.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // bTextBox
            // 
            this.bTextBox.Enabled = false;
            this.bTextBox.Location = new System.Drawing.Point(268, 286);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(38, 20);
            this.bTextBox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 763);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bTrack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pointAmount);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTrack);
            this.Controls.Add(this.RTrack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar RTrack;
        private System.Windows.Forms.TrackBar aTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar yTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar xTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox pointAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar bTrack;
        private System.Windows.Forms.TextBox bTextBox;
    }
}

