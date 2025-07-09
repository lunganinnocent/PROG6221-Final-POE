namespace PROG6221
{
    partial class Form4
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lblQuestions = new Label();
            btn2 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(677, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.malware;
            pictureBox1.Location = new Point(12, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblQuestions
            // 
            lblQuestions.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestions.Location = new Point(12, 9);
            lblQuestions.Name = "lblQuestions";
            lblQuestions.Size = new Size(776, 62);
            lblQuestions.TabIndex = 2;
            lblQuestions.Text = "label1";
            lblQuestions.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestions.Click += label1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(371, 146);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 50);
            btn2.TabIndex = 3;
            btn2.Tag = "2";
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += checkAnswerEvent;
            // 
            // btn4
            // 
            btn4.Location = new Point(371, 329);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 50);
            btn4.TabIndex = 5;
            btn4.Tag = "4";
            btn4.Text = "button3";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += checkAnswerEvent;
            // 
            // btn5
            // 
            btn5.Location = new Point(561, 329);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 50);
            btn5.TabIndex = 6;
            btn5.Tag = "5";
            btn5.Text = "button4";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += checkAnswerEvent;
            // 
            // btn3
            // 
            btn3.Location = new Point(561, 146);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 50);
            btn3.TabIndex = 7;
            btn3.Tag = "3";
            btn3.Text = "button2";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += checkAnswerEvent;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(lblQuestions);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Play Quiz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label lblQuestions;
        private Button btn2;
        private Button btn4;
        private Button btn5;
        private Button btn3;
    }
}