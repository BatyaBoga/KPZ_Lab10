using KPZ_Lab10.ProxyPatern;

namespace KPZ_Lab10
{
    public partial class Form1 : Form
    {
        private IFile _file;

        public Form1()
        {
            InitializeComponent();

            _file = new FileProxy(new FileManager());

            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string content = _file.Read(openFileDialog1.FileName);
                    textBox1.Text = content;
                }   
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _file.Write(openFileDialog1.FileName, textBox1.Text);
            }

        }
    }
}