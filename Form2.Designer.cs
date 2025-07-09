namespace PROG6221
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtReminderText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dTPReminderDate = new DateTimePicker();
            label4 = new Label();
            lstReminders = new ListBox();
            btnDeleteReminder = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Set A Reminder";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 160);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Input Reminder Text";
            // 
            // txtReminderText
            // 
            txtReminderText.Location = new Point(161, 152);
            txtReminderText.Name = "txtReminderText";
            txtReminderText.Size = new Size(210, 23);
            txtReminderText.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(702, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dTPReminderDate
            // 
            dTPReminderDate.Location = new Point(179, 233);
            dTPReminderDate.Name = "dTPReminderDate";
            dTPReminderDate.Size = new Size(232, 23);
            dTPReminderDate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 236);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 8;
            label4.Text = "Select Reminder Date";
            // 
            // lstReminders
            // 
            lstReminders.FormattingEnabled = true;
            lstReminders.ItemHeight = 15;
            lstReminders.Location = new Point(21, 275);
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(528, 154);
            lstReminders.TabIndex = 9;
            // 
            // btnDeleteReminder
            // 
            btnDeleteReminder.Location = new Point(590, 405);
            btnDeleteReminder.Name = "btnDeleteReminder";
            btnDeleteReminder.Size = new Size(55, 24);
            btnDeleteReminder.TabIndex = 10;
            btnDeleteReminder.Text = "Delete";
            btnDeleteReminder.UseVisualStyleBackColor = true;
            btnDeleteReminder.Click += btnDeleteReminder_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(85, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteReminder);
            Controls.Add(lstReminders);
            Controls.Add(label4);
            Controls.Add(dTPReminderDate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtReminderText);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtReminderText;
        private Button button1;
        private Button button2;
        private DateTimePicker dTPReminderDate;
        private Label label4;
        private ListBox lstReminders;
        private Button btnDeleteReminder;
        private TextBox textBox1;
    }
}