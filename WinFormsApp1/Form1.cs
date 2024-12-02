namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 1, overallChars = 0, average = 0;

            string message1 = "My name is Dima";
            string message2 = "I am 20 years old";
            string message3 = "I am an IT Step Student";

            overallChars += message1.Length;
            MessageBox.Show(message1, $"Message {index++}", MessageBoxButtons.OK);

            overallChars += message2.Length;
            MessageBox.Show(message2, $"Message {index++}", MessageBoxButtons.OK);

            overallChars += message3.Length;
            MessageBox.Show(message3, $"Message {index}", MessageBoxButtons.OK);

            MessageBox.Show($"Average characters : {overallChars / index}", "Character Count", MessageBoxButtons.OK);

        }
    }
}
