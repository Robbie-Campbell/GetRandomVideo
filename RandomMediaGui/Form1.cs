using RandomMediaGui.FileDefinitions.Abstraction;
using RandomMediaGui.FileDefinitions.Implementation;
using System.Reflection;

namespace RandomMediaGui
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            IEnumerable<FileType> exporters = typeof(FileType).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FileType)) && !t.IsAbstract).Select(t => (FileType)Activator.CreateInstance(t));
            foreach (FileType type in exporters) {
                comboBox1.Items.Add(type.getName());
            }
            comboBox1.SelectedIndex = 0;
        }

        private static object MagicallyCreateInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == className);

            return Activator.CreateInstance(type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileType type = (FileType)MagicallyCreateInstance(comboBox1.GetItemText(comboBox1.SelectedItem));
            FileList fileList = new FileList(textBox1.Text, type);
            new Open(fileList.getRandomFile());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetDirectoryName(folderBrowser.FileName);
            }
        }
    }
}