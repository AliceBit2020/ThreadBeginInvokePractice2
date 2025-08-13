using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadBeginInvoke.Controller
{
    public static  class TaskProgressBar
    {

        public static void StartProgressBars(SynchronizationContext ctx, ProgressBar pb1, ProgressBar pb2, ProgressBar pb3)
        {

            Action<SynchronizationContext, ProgressBar, int> action = SetProgressBar;

           IAsyncResult arr1= action.BeginInvoke(ctx, pb1,10000, null,null);
            IAsyncResult arr2 = action.BeginInvoke(ctx, pb2, 10000, null, null);
            IAsyncResult arr3 = action.BeginInvoke(ctx, pb3, 10000, null, null);

        }

        public static void SetProgressBar(SynchronizationContext ctx, ProgressBar pb, int count)
        {
            int number = 0;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                lock (ctx)
                {
                    number = random.Next(0, 100);
                    ctx.Send(s => pb.Value = number, null);
                     Thread.Sleep(100);
                }
                
            }


        }



    }
}
