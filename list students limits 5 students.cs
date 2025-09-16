using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int maxLimit = 5; 
          
            String studentName = textBox1.Text;
            String studentId = textBox2.Text;
       

            if (listBox1.Items.Count < maxLimit)
            {
                listBox1.Items.Add(studentId + " - " + studentName);
            }
            else
            {
                MessageBox.Show("You can only add up to 5 Students!" );
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
                listBox1.Items.Remove(listBox1.SelectedItems);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
