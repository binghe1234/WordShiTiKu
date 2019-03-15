using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordShiTiKu
{
    public partial class Form1 : Form
    {
        //private AxDSOFramer.AxFramerControl axFramerControl11;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axFramerControl1.Open(@"D:\c#demo\WindowsFormsApp2-upan\新建 DOC 文档.doc");//注：_filePath为.doc或者.xls为后缀的文件
        }
    }
}
