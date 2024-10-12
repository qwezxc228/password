using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static password.Form1;

namespace password
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Counter.Count += 1;
            if(Counter.Count ==2)
            {
                MessageBox.Show("ваш пароль: 123_qwe");
            }
            if (Counter.Count == 3)
            {
                MessageBox.Show("ваш пароль: qwe!_123");
            }
            if (Counter.Count == 4)
            {
                MessageBox.Show("ваш пароль: Qwe!_112342*&!3");
            }
            if (Counter.Count == 5)
            {
                MessageBox.Show("ваш пароль: sdfkj_^!14820_+=1");
            }
            if (Counter.Count == 6)
            {
                MessageBox.Show("ваш пароль: oJNEJjwef_1298u_Jmckz");
            }
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter.Count += 2;
            if (Counter.Count == 2)
            {
                MessageBox.Show("ваш пароль: 123_qwe");
            }
            if (Counter.Count == 3)
            {
                MessageBox.Show("ваш пароль: qwe!_123");
            }
            if (Counter.Count == 4)
            {
                MessageBox.Show("ваш пароль: Qwe!_112342*&!3");
            }
            if (Counter.Count == 5)
            {
                MessageBox.Show("ваш пароль: sdfkj_^!14820_+=1");
            }
            if (Counter.Count == 6)
            {
                MessageBox.Show("ваш пароль: oJNEJjwef_1298u_Jmckz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Counter.Count += 3;
            if (Counter.Count == 2)
            {
                MessageBox.Show("ваш пароль: 123_qwe");
            }
            if (Counter.Count == 3)
            {
                MessageBox.Show("ваш пароль: qwe!_123");
            }
            if (Counter.Count == 4)
            {
                MessageBox.Show("ваш пароль: Qwe!_112342*&!3");
            }
            if (Counter.Count == 5)
            {
                MessageBox.Show("ваш пароль: sdfkj_^!14820_+=1");
            }
            if (Counter.Count == 6)
            {
                MessageBox.Show("ваш пароль: oJNEJjwef_1298u_Jmckz");
            }
            Application.Exit();
        }

        
    }
}
