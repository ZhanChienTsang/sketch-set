using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string txt = "";
        Graphics gs1;
        Brush br = new SolidBrush(Color.FromArgb(0, 0, 135));
        Font font = new Font("Arial", 12);  //Arial
        PointF pf = new PointF();
        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            //x = Convert.ToDouble(textBox1.Text);
            if (Double.TryParse(textBox1.Text, out x))
            {
                if (x > 100 || x<0) { label2.Text = "請輸入0 - 100的數字!"; label2.BackColor = Color.FromArgb(250, 240, 230); }
                //else if (x < 0) { label2.Text = "請輸入0 - 100的數字!"; label2.BackColor = Color.FromArgb(250, 240, 230); }
                else if (x >= 90) { label2.Text = "A級,頂呱呱"; label2.BackColor = Color.FromArgb(255, 255, 0); }
                else if (x >= 80) { label2.Text = "B級,少了一個呱"; label2.BackColor = Color.FromArgb(132, 206, 235); }
                else if (x >= 70) { label2.Text = "C級,努力肯定有天收"; label2.BackColor = Color.FromArgb(189, 252, 201); }
                else if (x >= 60) { label2.Text = "D級,甘巴爹"; label2.BackColor = Color.FromArgb(255, 192, 203); }
                else if (x >= 0) { label2.Text = "E級,麥擱睏了"; label2.BackColor = Color.FromArgb(255, 0, 0); }
            }
             else
                { label2.Text = "您輸了非數字相關東西哦!"; label2.BackColor = Color.FromArgb(250, 240, 230); }
            //if (x > 100) { label2.Text = $"請輸入0 - 100的數字!"; }
            //else if (x < 0) { label2.Text = $"請輸入0 - 100的數字!"; }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double n,m=0;
            //n= Convert.ToDouble(textBox1.Text);
            if (Double.TryParse(textBox1.Text, out n))
            {
                if (n >= 0 && n <= 100)    //使用&&(要且),不使用||(或) 原n >= 0 || n <= 100
                { m = (n >= 90 ? 1 : (n >= 80 ? 2 : (n >= 70 ? 3 : (n >= 60 ? 4 : 5)))); }
                else
                { label3.Text = "請輸入0 - 100的數字!"; label3.BackColor = Color.FromArgb(250, 240, 230); }
                switch (m)
                {
                    case 1: label3.Text = $" A級,頂呱呱"; label3.BackColor = Color.FromArgb(255, 255, 0); break;
                    case 2: label3.Text = $" B級,少了一個呱"; label3.BackColor = Color.FromArgb(132, 206, 235); break;
                    case 3: label3.Text = $"C級,努力肯定有天收"; label3.BackColor = Color.FromArgb(189, 252, 201); break;
                    case 4: label3.Text = $" D級,甘巴爹"; label3.BackColor = Color.FromArgb(255, 192, 203); break;
                    case 5: label3.Text = $" E級,麥擱睏了"; label3.BackColor = Color.FromArgb(255, 0, 0); break;
                }
            }
            else { label3.Text = "您輸了非數字相關東西哦!"; label3.BackColor = Color.FromArgb(250, 240, 230); }

        }
         
        private void button4_Click(object sender, EventArgs e)
        {
            string n = "";
            for(int i = 1; i <=9; i++)
            {
                for(int j = 1; j <=9; j++)
                {
                    n+= $"{i,1}*{j,1}={i * j,2} ";
                }
                n += '\n';
            }
            label4.Text = n;
            label4.Font = new Font("標楷體", 10);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            gs1 = this.tabPage3.CreateGraphics();
            string n = "";
            
            for (int i = 1; i <= 9; i++)
            {
                txt =n.ToString();
                for (int j = 1; j <= 9; j++)
                {
                    //n += $"{i,1}*{j,1}={i * j,2} ";
                    n += (i + "*" + j + "=" + (i * j).ToString("00") + "\t");
                    pf.X = 60;
                    pf.Y = 30;
                    gs1.DrawString(txt, font, br, pf);
                }
                n += '\n'; 
            }
            //label5.Text = n;
            //pf = new Point(0, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str1;
            string s = "★"; string t = "　";
            int i, j, k, n, o;
            n = Convert.ToInt32(textBox2.Text);
            o = Convert.ToInt32(textBox3.Text);


            if (o > 0 && o < 4)
            { o = o <= 1 ? 1 : (o <= 2 ? 2 : 3); }
            else
            { label10.Text = "請輸入1~3!!!"; label10.BackColor = Color.FromArgb(250, 240, 230); }

            switch (o)
            {
                case 1:
                    str1 = ""; //正三
                    for (i = 1; i <= n; i++)
                    {
                        for (k = 0; k < n - i; k++)
                        { str1 += t; }
                        for (j = 1; j <= i; j++)
                        { str1 = str1 + s + t; }
                        str1 += "\n\n";
                    }
                    label6.Text += "" + str1;
                    break;
                case 2:
                    str1 = ""; //倒立正三角
                    for (i = 1; i <= n; i++)
                    {
                        for (k = 0; k < i - 1; k++)
                        { str1 += t; }
                        for (j = n; j >= i; j--)   //for (j=1;j<=n+1;j++)   
                        { str1 = str1 + s + t; }
                        str1 += "\n\n";
                    }
                    label6.Text += ""+str1;
                    break;
                case 3:
                    str1 = ""; //菱形
                    for (i = 1; i <= n; i++)
                    {
                        for (k = 0; k < n - i; k++)
                        { str1 += t; }
                        for (j = 1; j <= i; j++)
                        { str1 = str1 + s + t; }
                        str1 += "\n\n";
                    }

                    for (i = 1; i <= n; i++)
                    {
                        for (k = 0; k < i; k++)
                        { str1 += t; }
                        for (j = n - 1; j >= i; j--)
                        { str1 = str1 + s + t; }
                        str1 += "\n\n";
                    }
                    label6.Text += "" + str1;
                    break;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = 0;
            int column = 0;
            int row = 0;
            int times = 81;
            string s = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)                                                                           // s += $"{i,1}*{j,1}={i * j,2} ";         s += '\n';
                {
                    TextBox tbx = new TextBox();
                    tbx.Location = new Point(30 + (column * 80), 80 + (row * 30)); //new Point(0 + (75 * (j - 1)), 0 + (30 * (i - 1)));new Point(50 + (column * 80), 80 + (row * 30));
                    tbx.Text = $"{i,2}*{j,2}={i * j,2} ";
                    tbx.Name = tbx.Text;
                    tbx.Size = new Size(75, 30);                                                               //new Size(70, 10);   new Size(75, 30);
                    tbx.TabIndex = count + 1;   
                    this.tabPage5.Controls.Add(tbx);
                    count += 1;
                    column += 1;
                    if (count % 9 == 0)
                    {
                        column = 0;
                        row += 1;
                    }
                }

            }
        }
    }
}
