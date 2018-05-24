namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Solution (1)
			Form1 frm = new Form1();

			frm.Show();

			int intSomeNumber = 1;
			// /Solution (1)

			// Solution (2)
			//Form1 frm = new Form1();

			//frm.Show();

			//textBox1.Text = "Hello, World!";
			// /Solution (2)

			// Solution (3)
			//Form1 frm = new Form1();

			//frm.MyMainForm = this;

			//frm.Show();
			// /Solution (3)
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// Solution (1)
			Form1 frm = new Form1();

			frm.ShowDialog();

			int intSomeNumber = 1;
			// /Solution (1)

			// Solution (2)
			//Form1 frm = new Form1();

			//frm.ShowDialog();

			//textBox1.Text = "Hello, World!";
			// /Solution (2)

			// Solution (3)
			//Form1 frm = new Form1();

			//frm.MyMainForm = this;

			//frm.ShowDialog();
			// /Solution (3)
		}
	}
}
