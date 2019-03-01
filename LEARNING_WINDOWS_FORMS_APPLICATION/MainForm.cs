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
			// Step (1)
			Form1 form = new Form1();

			form.Show();

			int intSomeNumber = 1;
			// /Step (1)

			// Step (2)
			//Form1 form = new Form1();

			//form.Show();

			//textBox1.Text = "Hello, World!";
			// /Step (2)

			// Step (3)
			//Form1 form = new Form1();

			//form.MyMainForm = this;

			//form.Show();
			// /Step (3)
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// Step (1)
			Form1 form = new Form1();

			form.ShowDialog();

			int intSomeNumber = 1;
			// /Step (1)

			// Step (2)
			//Form1 form = new Form1();

			//form.ShowDialog();

			//textBox1.Text = "Hello, World!";
			// /Step (2)

			// Step (3)
			//Form1 form = new Form1();

			//form.MyMainForm = this;

			//form.ShowDialog();
			// /Step (3)
		}
	}
}
