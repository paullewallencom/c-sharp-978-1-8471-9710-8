using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SMSEncryption
{
    public partial class frmSMSEncryptionEngine : Form
    {
        // The thread
        private Thread proThreadEncryption;
        
        // The string list with SMS messages to encrypt (input)
        private List<string> prlsSMSToEncrypt;

        // The string list with SMS messages encrypted (output)
        private List<List<string>> prlsEncryptedSMS;
        // The number of the last encrypted string
        private List<int> priLastEncryptedString;
        // The threads list
        private List<Thread> prloThreadList;

        // The number of the last encrypted string shown in the UI
        private int priLastEncryptedStringShown;
        // The number of the previous last encrypted string shown in the UI
        private int priOldLastEncryptedStringShown;

        // The number of processors or cores available in the computer for this application
        private int priProcessorCount = Environment.ProcessorCount;

        public frmSMSEncryptionEngine()
        {
            InitializeComponent();
        }

        public string Decrypt(string psText)
        {
            // The decrypted text to return
            string lsDecryptedText;

            // The char position being decrypted
            int i;
            // The random char
            char loRandomChar;

            lsDecryptedText = "";
            for (i = 0; i <= (psText.Length - 1); i+=3)
            {
                // Retrieve the previously random generated char XOR 125 XOR 65535 - i (but previous i)
                loRandomChar = (char)(psText[i +1] ^ 125 ^ (65535 - (i / 3)));
                // Char XOR random generated char
                lsDecryptedText += ((char)(psText[i] ^ 125 ^ loRandomChar)).ToString();
            }

            return lsDecryptedText;
        }

        public string Encrypt(string psText)
        {
            string lsEncryptedText;
            string lsEncryptedTextWithFinalXOR;
            // A Random number generator
            Random loRandom = new Random();
            
            // The char position being encrypted
            int i;
            char loRandomChar;

            // Debug
            // Show the original text in the Immediate Window
            System.Diagnostics.Debug.Print("Original text:" + psText);

            lsEncryptedText = "";
            for (i = 0; i <= (psText.Length - 1); i++)
            {
                loRandomChar = (char)(loRandom.Next(65535));
                // Current char XOR random generated char

                // Debug
                // Show the random char code (in numbers) generated in the Immediate Window
                System.Diagnostics.Debug.Print("Random char generated:" +  ((int) loRandomChar).ToString());

                lsEncryptedText += ((char)(psText[i] ^ loRandomChar)).ToString();
                // Random generated char XOR 65535 - i
                // It is saved because we need it later for the decryption process
                lsEncryptedText += ((char)(loRandomChar ^ (65535 - i))).ToString();
                // Another random generated char but just to add garbage to confuss the hackers
                loRandomChar = (char)(loRandom.Next(65535));
                lsEncryptedText += loRandomChar.ToString();

                // Debug
                // Show how the encrypted text is being generated in the Immediate Window
                System.Diagnostics.Debug.Print("Partial encryption result char number: " + i.ToString() + ": " + lsEncryptedText);

            }

            lsEncryptedTextWithFinalXOR = "";
            // Now, every character XOR 125
            for (i = 0; i <= (lsEncryptedText.Length - 1); i++)
            {
                lsEncryptedTextWithFinalXOR += ((char)(lsEncryptedText[i] ^ 125)).ToString();
            }

            // Debug
            // Show how the encrypted text is being generated in the Immediate Window
            System.Diagnostics.Debug.Print("Final encryption result with XOR: " + lsEncryptedTextWithFinalXOR);

            return lsEncryptedTextWithFinalXOR;
        }

        private void butTest_Click(object sender, EventArgs e)
        {
            // The encrypted text
            string lsEncryptedText;

            // For each line in txtOriginalSMS TextBox
            foreach (string lsText in txtOriginalSMS.Lines)
            {
                lsEncryptedText = Encrypt(lsText);
                // Append a line with the Encrypted text
                txtEncryptedSMS.AppendText(lsEncryptedText + Environment.NewLine);
                // Append a line with the Encrypted text decrypted to test everything is as expected
                txtEncryptedSMS.AppendText(Decrypt(lsEncryptedText) + Environment.NewLine);
            }
        }

        private void ThreadEncryptProcedure(object poThreadParameter)
        {
            string lsEncryptedText;
            // Retrieve the thread number received in object poThreadParameter
            int liThreadNumber = (int)poThreadParameter;
            // ThreadNumber + 1
            int liStringNumber;

            // Create a new string list for the prlsSMSToEncrypt corresponding to the thread
            prlsEncryptedSMS[liThreadNumber] = new List<string>((prlsSMSToEncrypt.Count / priProcessorCount));

            priLastEncryptedString[liThreadNumber] = 0;

            liStringNumber = 0;
            int i;
            // steps the thread number
            string lsText;
            // Iterate through each string in the prlsSMSToEncrypt string list stepping by priProcessorCount
            // To distribute the work among each concurrent thread
            for (i = liThreadNumber; i < prlsSMSToEncrypt.Count; i += priProcessorCount)
            {
                lsText = prlsSMSToEncrypt[i];
                lsEncryptedText = Encrypt(lsText);
                // Append a string with the Encrypted text
                prlsEncryptedSMS[liThreadNumber].Add(lsEncryptedText);

                priLastEncryptedString[liThreadNumber]++;
                liStringNumber++;
            }
        }

        private void butRunInThread_Click(object sender, EventArgs e)
        {
            // Give the main thread a name
            Thread.CurrentThread.Name = "Main thread";
            
            // Prepare everything the thread needes from the UI
            // For each line in txtOriginalSMS TextBox
            prlsSMSToEncrypt = new List<string>(txtOriginalSMS.Lines.GetLength(0));
            // Add the lines in txtOriginalSMS TextBox
            prlsSMSToEncrypt.AddRange(txtOriginalSMS.Lines);

            // Thread number
            int liThreadNumber;
            // Create the thread list and string lists
            prloThreadList = new List<Thread>(priProcessorCount);
            prlsEncryptedSMS = new List<List<string>>(priProcessorCount);
            priLastEncryptedString = new List<int>(priProcessorCount);

            // Initialize the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                // Just to occupy the number
                prlsEncryptedSMS.Add(new List<string>());
                // Just to occupy the number
                priLastEncryptedString.Add(0);
                // Add the new thread, with a parameterized start (to allow parameters)
                prloThreadList.Add(new Thread(new ParameterizedThreadStart(ThreadEncryptProcedure)));
            }

            // Now, start the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                // Give the thread a name
                prloThreadList[liThreadNumber].Name = "Encryption #" + liThreadNumber.ToString();
                // Start the thread
                prloThreadList[liThreadNumber].Start(liThreadNumber);
            }

            // Start the BackgroundWorker with an asynchronous execution
            bakShowEncryptedStrings.RunWorkerAsync();
        }

        private void bakShowEncryptedStrings_DoWork(object sender, DoWorkEventArgs e)
        {
            // Give the BackgroundWorker thread a name
            Thread.CurrentThread.Name = "bakShowEncryptedStrings";
            // Initialize the last encrypted string shown
            priLastEncryptedStringShown = 0;
            // Initialize the last encrypted string shown before
            priOldLastEncryptedStringShown = 0;
            // The iteration
            int i;
            // The last encrypted string (saved locally to avoid changes in the middle of the iteration)
            int liLast;

            // Wait until proThreadEncryption begins
            while ((priLastEncryptedString[0] < 1))
            {
                // Sleep the thread for 10 milliseconds)
                Thread.Sleep(10);
            }

            while (prloThreadList[0].IsAlive || (priLastEncryptedString[0] > priLastEncryptedStringShown))
            {
                liLast = priLastEncryptedString[0];
                if (liLast != priLastEncryptedStringShown)
                {
                    ((BackgroundWorker)sender).ReportProgress(liLast);
                    priLastEncryptedStringShown = liLast;
                }

                // Sleep the thread for 2 seconds (2000 milliseconds)
                Thread.Sleep(2000);
            }
        }

        private void bakShowEncryptedStrings_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The iteration
            int i;
            // Show the number of SMS messages encrypted by the concurrent proThreadEncryption thread
            lblNumberOfSMSEncrypted.Text = priLastEncryptedString[0].ToString();

            // Append each new string, from priOldLastEncryptedStringShown to the received parameter in e.ProgressPercentage - 1
            for (i = priOldLastEncryptedStringShown; i < (int)e.ProgressPercentage; i++)
            {
                // Append the string to the txtEncryptedSMS TextBox
                txtEncryptedSMS.AppendText(prlsEncryptedSMS[0][i] + Environment.NewLine);
                // Let the UI update
                Application.DoEvents();
            }
            // Update the old last encrypted string shown
            priOldLastEncryptedStringShown = priLastEncryptedStringShown;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void frmSMSEncryptionEngine_Load(object sender, EventArgs e)
        {

        }
    }
}