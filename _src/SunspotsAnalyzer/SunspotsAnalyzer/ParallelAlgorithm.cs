using System;
using System.Collections.Generic;
using System.Text;
// NEW
using System.Threading;

namespace SunspotsAnalyzer
{
    abstract class ParallelAlgorithmPiece
    {
        // The element to begin processing
        private long priBegin = 0;
        // The element to end processing (inclusive)
        private long priEnd = 0;
        // The thread number
        private int priThreadNumber = 0;
        // The thread
        private Thread proThread;
        // Code added in the WaitHandle.WaitAll version
        // The AutoResetEvent instance for the thread
        private AutoResetEvent proAutoResetEvent;
        public AutoResetEvent poAutoResetEvent
        {
            get
            {
                return proAutoResetEvent;
            }
            set
            {
                proAutoResetEvent = value;
            }
        }
        // End of code added in the WaitHandle.WaitAll version

        public Thread poThread
        {
            get
            {
                return proThread;
            }
            set 
            {
                proThread = value;
            }
        }

        public long piBegin
        {
            get
            {
                return priBegin;
            }
            set
            {
                priBegin = value;
            }
        }

        public long piEnd
        {
            get
            {
                return priEnd;
            }
            set
            {
                priEnd = value;
            }
        }

        public long piThreadNumber
        {
            get
            {
                return priThreadNumber;
            }
        }

        // CHANGED TO ABSTRACT
        public abstract void ThreadMethod(object poThreadParameter);
        //{
            // This is the code that is going to be run by the thread
            // It has access to all the instance variable of this class
            // It receives the instance as a parameter
            // We must typecast poThreadParameter to ParallelAlgorithmPiece

            // When the work finishes, we must call
            // poAutoResetEvent.Set();
        //}

        public ParallelAlgorithmPiece(int priThreadNumberToAssign)
        {
            priThreadNumber = priThreadNumberToAssign;
        }
    }
    
    abstract class ParallelAlgorithm
    {
        public List<ParallelAlgorithmPiece> prloPieces;
        // Code added in the WaitHandle.WaitAll version
        // The AutoResetEvent instances array
        private AutoResetEvent[] praoAutoResetEventArray;
                
        public static void ForceGarbageCollection()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        // CHANGE IN CreateThreads
        // Replace the line prloPieces = ParallelAlgorithmPiece.CreatePieces(priTotalElements, priTotalParts);
        // with the call to a new method
        public void CreateThreads(long priTotalElements, int priTotalParts)
        {
            // priTotalParts should be Environment.ProcessorCount in most cases
            // CHANGED REPLACED 
            // Code added in the WaitHandle.WaitAll version
            // Create the AutoResetEvent array with the number of cores available
            praoAutoResetEventArray = new AutoResetEvent[priTotalParts];
            // End of the code added in the WaitHandle.WaitAll version

            prloPieces = CreatePieces(priTotalElements, priTotalParts);
            foreach (ParallelAlgorithmPiece loPiece in prloPieces)
            {
                // Create the new thread with parameters
                loPiece.poThread = new Thread(new ParameterizedThreadStart(loPiece.ThreadMethod));
                // Give the thread a name
                loPiece.poThread.Name = loPiece.piThreadNumber.ToString();

                // Code added in the WaitHandle.WaitAll version
                // Create a new AutoResetEvent instance for that thread with its initial state set to false
                loPiece.poAutoResetEvent = new AutoResetEvent(false);
                praoAutoResetEventArray[loPiece.piThreadNumber] = loPiece.poAutoResetEvent;
                // End of the code added in the WaitHandle.WaitAll version
            }
        }

        //CHANGE
        // NEW (MADE VIRTUAL)
        public abstract ParallelAlgorithmPiece CreateParallelAlgorithmPiece(int priThreadNumber);
        //{
            //return (new ParallelAlgorithmPiece(priThreadNumber));
        //}

        // CHANGE TO NON STATIC
        // REMOVE STATIC IDENTIFIER TO ALLOW THE CALL TO CreateParallelAlgorithmPiece
        // MOVED FROM ParallelAlgorithmPiece to ParallelAlgorithm
        public virtual List<ParallelAlgorithmPiece> CreatePieces(long priTotalElements, int priTotalParts)
        {
            // Always starts in element #0
            long liPieceSize;
            List<ParallelAlgorithmPiece> lloPieces;
            int i;
            long liTotalCovered = 0;

            liPieceSize = (long)(priTotalElements / priTotalParts);

            lloPieces = new List<ParallelAlgorithmPiece>(priTotalParts);
            for (i = 0; i < priTotalParts; i++)
            {
                // CHANGE
                // There was a mistake, you cannot assign before creating
                //lloPieces[i] = new ParallelAlgorithmPiece();
                lloPieces.Add(CreateParallelAlgorithmPiece(i));
                lloPieces[i].piBegin = liTotalCovered;
                lloPieces[i].piEnd = liTotalCovered + (liPieceSize - 1);
                // CHANGE
                // Commented
                //lloPieces[i].piThreadNumber = i;
                if (lloPieces[i].piEnd > (priTotalElements - 1))
                {
                    lloPieces[i].piEnd = priTotalElements;
                }
                liTotalCovered += liPieceSize;
                if (liTotalCovered >= priTotalElements)
                {
                    break;
                }
            }

            return lloPieces;
        }

        // CHANGED TO VIRTUAL
        public virtual void StartThreadsAsync()
        {
            foreach (ParallelAlgorithmPiece loPiece in prloPieces)
            {
                // Send the corresponding ParallelAlgorithmPiece instance as a parameter
                loPiece.poThread.Start(loPiece);
            }
        }

        public void RunInParallelSync()
        {
            StartThreadsAsync();
            WaitForMyThreadsToDie();
        }

        public void WaitForMyThreadsToDie()
        {
            // Previous version - without using WaitAll            
            //// A bool flag
            //bool lbContinue = true;
            //int liDeadThreads = 0;
            //while (lbContinue)
            //{
            //    foreach (ParallelAlgorithmPiece loPiece in prloPieces)
            //    {
            //        if (loPiece.poThread.IsAlive)
            //        {
            //            // One of the threads is still alive, exit the for loop and sleep 100 milliseconds
            //            break;
            //        }
            //        else
            //        {
            //            // Increase the dead threads count
            //            liDeadThreads++;
            //        }
            //    }
            //    if (liDeadThreads == prloPieces.Count)
            //    {
            //        // All the threads are dead, exit the while loop
            //        break;
            //    }
            //    Thread.Sleep(100);
            //    liDeadThreads = 0;
            //}
            // End of previous version - without using WaitAll
            // Code added in the WaitHandle.WaitAll version
            // Just wait for the threads to signal that every work item has finished
            WaitHandle.WaitAll(praoAutoResetEventArray);
        }

        // CHANGED TO VIRTUAL
        public abstract void CollectResults();
        //{
            // Enter the results collection iteration through the results left in each ParallelAlgorithmPiece
        //}
    }
}
