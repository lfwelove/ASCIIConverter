using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIIConverter
{
    public partial class ASCIIConverter : Form
    {
        public ASCIIConverter()
        {
            InitializeComponent();
        }

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {
            rtbOutput.Text = ConverterToASCII(rtbInput.Text);
        }

        private void ASCIIConverter_Load(object sender, EventArgs e)
        {
            cbAddSpace.Checked = false;
            cbRemoveComma.Checked = false;
            cbRemoveOx.Checked = false;
        }

        string ConverterToASCII(string input)
        {
            char[] chars = input.ToArray<char>();
            StringBuilder sb = new StringBuilder();
            int len = chars.Length;
            int count = 0;
            foreach (char c in chars)
            {
                if (cbRemoveOx.Checked)
                    sb.Append(string.Format("{0:x}", (int)c));
                else
                    sb.Append(string.Format("0x{0:x}", (int)c));
                ++count;
                if (count == len)
                    continue;
                if (cbAddSpace.Checked)
                    sb.Append(" ");
                else if (!cbRemoveComma.Checked)
                    sb.Append(", ");
            }
            return sb.ToString();
        }

        private void cbRemoveOx_CheckedChanged(object sender, EventArgs e)
        {
            rtbOutput.Text = ConverterToASCII(rtbInput.Text);
        }

        private void cbAddSpace_CheckedChanged(object sender, EventArgs e)
        {
            rtbOutput.Text = ConverterToASCII(rtbInput.Text);
        }

        private void cbRemoveComma_CheckedChanged(object sender, EventArgs e)
        {
            rtbOutput.Text = ConverterToASCII(rtbInput.Text);
        }
    }
}
