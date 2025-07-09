using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG6221
{
    public partial class Form4 : Form
    {
        int qTotal = 7;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;



        public Form4()
        {
            InitializeComponent();
            setOfQuestions(qNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                scoreNum++;
            }
            if (qNumber == qTotal)
            {
                MessageBox.Show("Quizz Ended" + Environment.NewLine +
                    "Your Score" + scoreNum + " / " + qTotal + Environment.NewLine +
                    "Click ok to paly again "
                    );
                scoreNum = 0;
                qNumber = 0;
                setOfQuestions(qNumber);

            }
            qNumber++;
              setOfQuestions(qNumber);


        }

        private void setOfQuestions(int question_number)
        {
            switch (question_number)
            {
                case 1: 
                    pictureBox1.Image = Properties.Resources.trojanHorese;
                    lblQuestions.Text = "malicious software disguised as legitimate software";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "horse";
                    btn4.Text = "spyware";
                    btn5.Text = "malware";

                    correctAnswer = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.hacker;
                    lblQuestions.Text = "someone who uses their technical knowledge to gain unauthorized access to computer systems, networks, or data.";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "firewall";
                    btn4.Text = "Hacker";
                    btn5.Text = "OK";

                    correctAnswer = 4;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.firewall;
                    lblQuestions.Text = "a network security system designed to monitor and control incoming and outgoing network traffic based on predetermined security rules.";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "Hacker";
                    btn4.Text = "OK";
                    btn5.Text = "firewall";

                    correctAnswer = 5;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.virus;
                    lblQuestions.Text = "a type of malware that attaches itself to a legitimate program or file and replicates itself to spread to other files and systems, often causing damage or disruption";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "virus";
                    btn4.Text = "OK";
                    btn5.Text = "Hacke";

                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.malware;
                    lblQuestions.Text = "any malicious software designed to harm or exploit computer systems, networks, or data.";
                    btn2.Text = "Hacker";
                    btn3.Text = "OK";
                    btn4.Text = "malware";
                    btn5.Text = "OK";

                    correctAnswer = 4;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.blagging;
                    lblQuestions.Text = "a social engineering tactic where an attacker fabricates a scenario to trick a victim into divulging sensitive information or performing actions that compromise security. ";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "OK";
                    btn4.Text = "Hacker";
                    btn5.Text = "blagging";

                    correctAnswer = 5;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.adware;
                    lblQuestions.Text = "malicious software designed to bombard a user with unwanted advertisements.";
                    btn2.Text = "Trojan Horse";
                    btn3.Text = "OK";
                    btn4.Text = "OK";
                    btn5.Text = "adware";

                    correctAnswer = 5;
                    break;

            }

        }

    }
}
