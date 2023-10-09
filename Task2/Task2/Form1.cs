namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            int x = Random.Shared.Next(0, this.Size.Width - label1.Size.Width-30);
            int y = Random.Shared.Next(0,this.Size.Height - label1.Size.Height-30);    
          
            label1.Location = new Point(x,y);
        }
    }
}