using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThreadBeginInvoke.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ThreadBeginInvoke
{
    public partial class Form1 : Form
    {
        SynchronizationContext ctx;
        public Form1()
        {
            InitializeComponent();
            ctx = SynchronizationContext.Current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskProgressBar.StartProgressBars(ctx, progressBar1, progressBar2, progressBar3);


        }
        
            

        
    }
}
