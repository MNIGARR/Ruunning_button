namespace Ruunning_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 689);
            int y = rnd.Next(0, 412);
            button1.Location = new Point(x, y);
        }
    }
}