namespace WinFormsApp8
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my BMI Calculator!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                double heightM = height / 100.0;
                double total = weight / (heightM * heightM);
                String bmiResult = total.ToString("F2");

                if (total < 18.5)
                {
                    MessageBox.Show("Your BMI: " + bmiResult + " Description: Underweight");
                }
                else if (total < 25)
                {
                    MessageBox.Show("Your BMI: " + bmiResult + " Description: Normal");
                }
                else if (total < 30)
                {
                    MessageBox.Show("Your BMI: " + bmiResult + " Description: Overweight");
                }
                else
                {
                    MessageBox.Show("Your BMI: " + bmiResult + " Description: Obese");
                }
              
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
