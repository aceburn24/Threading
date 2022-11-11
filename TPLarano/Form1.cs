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

namespace TPLarano
{
    public partial class Form1 : Form
    {
        Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
        Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
        Thread ThreadC = new Thread(new ThreadStart(MyThreadClass.Thread2));
        Thread ThreadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";

        }
    }
}
