namespace ConversorDeTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatura = int.Parse(textBox1.Text);
            double opção = comboBox1.SelectedIndex;
            double resultado = 0;

            switch (opção)
            {
                case 0:
                    resultado = (temperatura * 1.8) + 32;
                    break;
                case 1:
                    resultado = (temperatura - 32) / 1.8;
                    break;





            }
            textBox3.Text = resultado.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}