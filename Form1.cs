using System;
using System.Linq;
using System.Windows.Forms;

namespace StringArraySorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string[] stringArray = textBoxInput.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var sortedArray = stringArray.OrderBy(s => s).ToArray();

            textBoxOutput.Text = string.Join(Environment.NewLine, sortedArray);
        }
    }
}
