using System.Text;
using System.Windows.Forms;

namespace BearingsAndDistancesParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutputToFile_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            textBox1.Text = String.Empty;
            foreach (BearingDistance bearingDistance in flowLayoutPanel1.Controls)
            {
                stringBuilder.Append(bearingDistance.GetLineTranslation());
            }
            stringBuilder.Append("to the Place of Beginning.");
            textBox1.Text = stringBuilder.ToString();
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            int size = -1;
            flowLayoutPanel1.Controls.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    List<Line> lines = new List<Line>();
                    using (StreamReader reader = new StreamReader(file))
                    {
                        var line = string.Empty;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (!line.StartsWith("Boundary:") && !line.StartsWith("Start") && !line.StartsWith("Area"))
                            {
                                var lineObj = GetLineHeader(line);

                                if(!lines.Any() || lines.FirstOrDefault().Point != lineObj.Point)
                                {
                                    var lineData = reader.ReadLine();
                                    lines.Add(BuildLine(lineObj, lineData));
                                    flowLayoutPanel1.Controls.Add(new BearingDistance(lineObj));
                                }
                            }
                        }
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private Line GetLineHeader(string headerRow)
        {
            var headerRowValues = headerRow.Replace("\t", " ").Replace("\n", " ").Replace("\r", " ").Replace("\v", " ").Replace("\f", " ").Split(' ');
            return new Line(int.Parse(headerRowValues[0]), headerRowValues[1]);
        }

        private Line BuildLine(Line line, string lineData)
        {
            var escapedLine = lineData.Replace("\t", " ").Replace("\n", " ").Replace("\r", " ").Replace("\v", " ").Replace("\f", " ");
            var lineSegments = escapedLine.Trim().Split(' ', 7, StringSplitOptions.RemoveEmptyEntries);
            line.FirstValue = lineSegments[0];
            line.Direction1 = lineSegments[1];
            line.Degrees = lineSegments[2].Substring(0, lineSegments[2].Length -1);
            line.Minutes = lineSegments[3].Substring(0, lineSegments[3].Length - 1);
            line.Seconds = lineSegments[4].Substring(0, lineSegments[4].Length - 1);
            line.Direction2 = lineSegments[5];
            line.Distance = decimal.Parse(lineSegments[6]);
            return line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}