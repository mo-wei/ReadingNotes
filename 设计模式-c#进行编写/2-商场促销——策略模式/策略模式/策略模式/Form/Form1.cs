using System;
using System.Windows.Forms;
using 策略模式.策略模式;
namespace 策略模式
{

    //不做任何打折的收银系统
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "满三百减一百"});
            cbxType.SelectedIndex = 0;
        }

        double total = 0.0d;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textPrice.Text != "" && textNum.Text != "" 
                && Convert.ToDouble(textPrice.Text) > 0 && Convert.ToDouble(textNum.Text) > 0)
            {
                CashContext cashContext = new CashContext(cbxType.SelectedItem.ToString());
                double totalPrices = 0d;
                totalPrices = cashContext.GetResult(Convert.ToDouble(textNum.Text) * Convert.ToDouble(textPrice.Text));

                textPrice.Text = "";
                textNum.Text = "";
                total = total + totalPrices;

                listBox1.Items.Add("单价： " + textPrice.Text + "数量： " + textNum.Text + "   " + cbxType.SelectedItem +
                    "  合计： " + totalPrices.ToString());

                lblResult.Text = total.ToString();
            }
            else
            {
                textPrice.Text = "";
                textNum.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cbxType.SelectedIndex = 0;
            textPrice.Text = "";
            textNum.Text = "";
            lblResult.Text = "";
        }
    }
}
