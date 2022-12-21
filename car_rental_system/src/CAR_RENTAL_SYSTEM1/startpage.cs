namespace CAR_RENTAL_SYSTEM1
{
    public partial class startpage : Form
    {
        public startpage()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            Percentage.Text = "" + startpoint;
            if(Myprogress.Value ==100 )
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void startpage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}