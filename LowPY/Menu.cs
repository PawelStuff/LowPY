using Microsoft.Win32;

namespace LowPY
{
    public partial class Menu : Form
    {

        Microsoft.Win32.RegistryKey key;

        public static string filePath;
        float timesclicked;
        

        public Menu()
        {
            InitializeComponent();



        }


        private void lpyLogo_Click(object sender, EventArgs e)
        {
            timesclicked += 1;

            if (timesclicked == 5)
            {

                var about = new About();

                about.Show();

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Python script files (*.py)|*.py";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    Editor.writepath = filePath;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string fileContent = reader.ReadToEnd();

                        this.Hide();

                        fileStream.Close();

                        var editor = new Editor();

                        editor.Show();

                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("set path is ; " + filePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Python script files (*.py)|*.py";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                Editor.writepath = filePath;

                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    writetemplate();

                    this.Hide();

                    

                    var editor = new Editor();

                    editor.Show();

                }
            }
        }

        void writetemplate()
        {

            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("# ----------------------------");
            sw.WriteLine("# LowPY Script Template");
            sw.WriteLine("# ----------------------------");
            sw.WriteLine();
            sw.WriteLine("x = 1");
            sw.WriteLine("");
            sw.WriteLine("print('the value of x is ;')");
            sw.WriteLine("print(x)");
            sw.Close();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}