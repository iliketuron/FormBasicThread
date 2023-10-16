using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);

            Thread threadA = new Thread(delThread);
            threadA.Name = "Thread A Process";
            Thread threadB = new Thread(delThread);
            threadB.Name = "Thread B Process";
            Console.WriteLine(label1.Text);

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "      - End of Threads -";
            Console.WriteLine(label1.Text);


        }
    }
}
