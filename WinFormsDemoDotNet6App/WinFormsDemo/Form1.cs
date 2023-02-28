namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");
            Form2 frm  = new Form2();
            frm.ShowDialog();
        }
    }
}