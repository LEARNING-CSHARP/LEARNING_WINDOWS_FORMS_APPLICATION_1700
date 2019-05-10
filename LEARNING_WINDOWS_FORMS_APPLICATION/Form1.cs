namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public MainForm MyMainForm { get; set; }

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MyMainForm.textBox1.Text = "Mr. Dariush Tasdighi";
		}
	}
}
