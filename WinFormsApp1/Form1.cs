namespace WinFormsApp1
{
    public partial class Interface : Form
    {


        public Interface()
        {
            InitializeComponent();
        }

        public void Open_Click(object sender, EventArgs e)
        {
            var form2 = new WinFormsApp1.Notepad();
            form2.ShowDialog();
        }
    }

}
