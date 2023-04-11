using System.Drawing;
using System.Windows.Forms;
using 建造者模式.建造者类;

namespace 建造者模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Red);
            Graphics gThin = pictureBox1.CreateGraphics();
            PernsonThinBuilder thinPerson = new PernsonThinBuilder(gThin, pen);
            PersonDirector director = new PersonDirector(thinPerson);

            director.CreatPerson();
            //实时刷新数据才能显示出来
            Refresh();
        }

    }
}
