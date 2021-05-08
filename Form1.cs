using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6pg273_BaseAndSubConstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBaseClass myBaseClass = new MyBaseClass("test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySubclass mySubclass = new MySubclass("test", 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySubclass mySubclass = new MySubclass("test 2", 2);
        }
    }
}
