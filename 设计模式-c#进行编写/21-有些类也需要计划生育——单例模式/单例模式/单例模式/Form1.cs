using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void 复制CtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.SelectedText);
        }

        private void 粘贴CtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = (string)Clipboard.GetDataObject().GetData(DataFormats.Text);
        }

        private void 剪切CtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormToolBox.GetInstance().Show();
            textBox1.SendToBack();
        }
    }
}
