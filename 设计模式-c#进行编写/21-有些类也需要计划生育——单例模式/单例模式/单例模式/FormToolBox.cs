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
    public partial class FormToolBox : Form
    {
        #region 普通单例的使用
        private static FormToolBox ftb = null;
        private FormToolBox()//单例模式的构造方法私有，让外部不能直接new来生成它
        {
            InitializeComponent();
        }

        public static FormToolBox GetInstance()
        {
            if (ftb == null || ftb.IsDisposed)
            {
                ftb = new FormToolBox();
                ftb.MdiParent = Form1.ActiveForm;
            }
            return ftb;
        }
        #endregion

        #region 多线程时的单例
        /* private static FormToolBox ftb = null;
         private static readonly object locker = new object();//官方文档推荐使用
         private FormToolBox()//单例模式的构造方法私有，让外部不能直接new来生成它
         {
             InitializeComponent();
         }

         public static FormToolBox GetInstance()
         {
             if (ftb == null || ftb.IsDisposed)//避免非必要加锁
             {
                 lock (locker)//请锁定专用对象实例或者不可能被用作锁的实例，避免使用相同的lock对象导致死锁或者锁争用
                 {
                     if (ftb == null || ftb.IsDisposed)
                     {
                         ftb = new FormToolBox();
                         ftb.MdiParent = Form1.ActiveForm;
                     }
                 }
             }
             return ftb;
         }*/
        #endregion

        #region 静态初始化
        /*private static readonly FormToolBox ftb = new FormToolBox();
        private FormToolBox()//单例模式的构造方法私有，让外部不能直接new来生成它
        {
            InitializeComponent();
        }

        public static FormToolBox GetInstance()
        {
            return ftb;
        }*/
        #endregion
    }
}
