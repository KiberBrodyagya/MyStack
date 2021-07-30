using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MyStack myStack;
        Stack<char> stack = new Stack<char>();

        private void Push()
        {
            try
            {
                myStack = new MyStack(textBox2.Text.Length);
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    myStack.Push(Convert.ToChar(textBox2.Text[i]));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Push();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var elem2 = myStack.Top().ToString();
                textBox2.Text = elem2.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(myStack == null)
            {
                MessageBox.Show("Stack is empty\n(underflow)");
            }
            else
            {
                var elem1 = myStack.Pop();
                textBox2.Text = elem1.ToString();
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(myStack == null)
                {
                    MessageBox.Show(true.ToString());
                }
                else
                {
                    var i = myStack.isEmpty();
                    MessageBox.Show(i.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myStack.elem.Clear();
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(Check(textBox2.Text) == true)
            {
                textBox3.Text = textBox2.Text;
                MessageBox.Show("Right");                
            }
            else
            {
                textBox3.Text = textBox2.Text;
                MessageBox.Show("Not right");              
            }
        }
        
        public bool Check(string s)
        {
            var brackets = new Stack<char>();

            var openBrackets = new List<char>() { '(', '[', '{' };
            var closeBrackets = new List<char>() { ')', ']', '}' };

            foreach (char bracket in myStack.elem)
            {
                try
                {
                    if (openBrackets.Contains(bracket))
                    {
                        brackets.Push(bracket);
                    }
                    else
                    {
                        if (openBrackets.IndexOf(brackets.Pop()) != closeBrackets.IndexOf(bracket))
                        {
                            return false;                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            if (brackets.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < myStack.length; i++)
            {
                textBox4.Text += myStack.elem[i].ToString();
            }
        }
    }
}
