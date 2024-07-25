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
            IDataObject clipboardData = Clipboard.GetDataObject();
            //var clipboardContent = clipboardData.GetData(typeof(string));
            var clipboardContent = clipboardData.GetData(DataFormats.StringFormat);
            System.Diagnostics.Debug.WriteLine(clipboardContent);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
