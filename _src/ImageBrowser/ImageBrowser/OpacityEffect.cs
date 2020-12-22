using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// NEW
using System.Windows.Forms;
using System.Threading;

namespace ImageBrowser
{
    class OpacityEffect
    {
        private frmMain proForm;
        public OpacityEffect(frmMain paroForm)
        {
            // Store a reference to the form
            proForm = paroForm;
        }

        private void ThreadProc(object poThreadParameter)
        {
            // An instance of OpacityEffect is passed in poThreadParameter
            OpacityEffect loOpacityEffect = (OpacityEffect)poThreadParameter;
            // Call the RunEffect method for the instance
            loOpacityEffect.RunEffect();
        }

        private void RunEffect()
        {
            for (double liOpacity = 0; liOpacity < 1; liOpacity += .05)
            {
                // Invoke the delegate to update the UI
                proForm.ChangeOpacity(liOpacity);
                // Sleep the thread for 100 milliseconds
                Thread.Sleep(100);
            }
            // To solve a horrible bug in +0.05 with double in some CPUs
            proForm.ChangeOpacity(1);
        }

        public void RunAsync()
        {
            // Add a new independent thread, with a parameterized start (to allow parameters)
            Thread loThread = new Thread(new ParameterizedThreadStart(ThreadProc));
            // The thread is going to be a background thread
            loThread.IsBackground = true;
            // Start the thread with an asynchronous execution
            loThread.Start(this);
        }
    }
}
