using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stacks;

namespace GUImain
{
    public partial class Form1 : Form 
    {
        int[] Number;
        int sumScore,Score;
        Stack Stack;
        int N1, N2, N3, N4;
        public Form1()  
        {
            Stack = new LinkedStack();
            Number = new int[4];
            InitializeComponent();
            label4.Visible = false;
            setNum();
        }
        
        int seconds = 45;
        Random random = new Random();

        private void setNum()
        {
            N1 = random.Next(1, 9);
            N2 = random.Next(1, 9);
            N3 = random.Next(1, 9);
            N4 = random.Next(1, 9);
            Number1.Text = N1.ToString();
            Number2.Text = N2.ToString();
            Number3.Text = N3.ToString();
            Number4.Text = N4.ToString();
        }
        private void NumVisible(bool tf)
        {
            if (tf == true)
            {
                Number1.Visible = true;
                Number2.Visible = true;
                Number3.Visible = true;
                Number4.Visible = true;
            }
            else
            {
                Number1.Visible = false;
                Number2.Visible = false;
                Number3.Visible = false;
                Number4.Visible = false;
            }
        }
        private void unenable()
        {
            if (!Stack.isEmpty())
            {
                Undo.Enabled = true;
            }
        }
        private void Number1_Click(object sender, EventArgs e)
        {
            
            txt_score.Text += N1.ToString();
            Number1.Visible = false;
            Stack.push(1);
            unenable();

        } 
        private void Number2_Click(object sender, EventArgs e)
        {
            txt_score.Text += N2.ToString();
            Number2.Visible = false;
            Stack.push(2);
            unenable();
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            txt_score.Text += N3.ToString();
            Number3.Visible = false;
            Stack.push(3);
            unenable();
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            txt_score.Text += N4.ToString();
            Number4.Visible = false;
            Stack.push(4);
            unenable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setNum();
        }
        int stopAndStart = 0;
        private void Random_Click(object sender, EventArgs e)
        {
            

            if (stopAndStart == 0)
            {
                timer2.Stop();
                timer1.Enabled = true;
                stopAndStart = 1;
                Random.Text = "Stop";
                txt_score.Clear();
                NumVisible(true);
            }
            else {
                
                timer1.Enabled = false;
                stopAndStart = 0;
                Random.Text = "Random";
                timer2.Start();
            }
            richTextBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Undo_Click(object sender, EventArgs e)
        {

            int a = 0;
            if (Stack.isEmpty())
            {
                
                MessageBox.Show("ไม่มีข้อความอยู่ใน Text");
            }
            if (!Stack.isEmpty()) {
                a = (int)Stack.pop();

            }
           

            switch (a) {

                case 1:
                    Number1.Visible = true;
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length-1);
                    break;
                case 2:
                    Number2.Visible = true;
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 3:
                    Number3.Visible = true;
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 4:
                    Number4.Visible = true;
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 5:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 6:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 7:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 8:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 9:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 10:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;
                case 11:
                    txt_score.Text = txt_score.Text.Remove(txt_score.Text.Length - 1);
                    break;


            }

            }

        

        private void plus_Click(object sender, EventArgs e)
        {
            txt_score.Text += "+".ToString();
            Stack.push(5);
            unenable();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            txt_score.Text += "-".ToString();
            Stack.push(6);
            unenable();
        }

        private void Multiplied_Click(object sender, EventArgs e)
        {
            txt_score.Text += "*".ToString();
            Stack.push(7);
            unenable();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            txt_score.Text += "/".ToString();
            Stack.push(8);
            unenable();
        }

        private void parenthesesLeft_Click(object sender, EventArgs e)
        {
            txt_score.Text += "(".ToString();
            Stack.push(10);
            unenable();
        }

        private void parenthesesRight_Click(object sender, EventArgs e)
        {
            txt_score.Text += ")".ToString();
            Stack.push(11);
            unenable();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = seconds--.ToString();
            if (seconds < 0)
            {              
                timer2.Stop();
                MessageBox.Show("หมดเวลา", "notificationn");
                label1.Visible = true;
                label4.Visible = false;

            }
            
        }
       
        private void Time_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            seconds = 45;
            MessageBox.Show("โหมดจับเวลา", "notification");
            label4.Text = seconds.ToString();
            label1.Visible = false;
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lb_score.Text = "SCORE: " + score(0).ToString();
            richTextBox1.Clear();
            Solver solve = new Solver();
            int[] num = { int.Parse(Number1.Text), int.Parse(Number2.Text), int.Parse(Number3.Text), int.Parse(Number4.Text) };
            foreach(string str in solve.solve(num))
            {
                richTextBox1.Text += str+"\n";
            }
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double Evaluate(string expression)
            {
                var loDataTable = new DataTable();
                var loDataColumn = new DataColumn("Eval", typeof(double), expression);
                loDataTable.Columns.Add(loDataColumn);
                loDataTable.Rows.Add(0);
                return (double)(loDataTable.Rows[0]["Eval"]);
            }
            if (Evaluate(txt_score.Text) == 24)
            {
                MessageBox.Show("Pass", "notification");
                richTextBox1.Clear();
                seconds += 30;
                lb_score.Text = "SCORE: "+SumScore(score(100)).ToString();
                timer3.Start();
                setNum();
            }
            else {
                MessageBox.Show("Not pass", "notificationn");
                
                setNum();
            }
            txt_score.Clear();
            int a = Stack.size();
            for (int i = 0; i < a; i++)
            {
                Stack.pop();
            }
            if (Stack.isEmpty())
            {
                Undo.Enabled = false;
            }
            NumVisible(true);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โหมดไม่จับเวลา");
            timer2.Enabled = false;
            label1.Visible = true;
            label4.Visible = false;
        }

        private int score(int sc)
        {
            if(sc == 0)
            {
                return 0;
            }
            else
            {
                Score = 100;
                return Score;
            }
        }
        private int SumScore(int score)
        {
            if (Score != 0)
                sumScore = 0;
            else sumScore += Score;
            return sumScore;
        }
    }
}
