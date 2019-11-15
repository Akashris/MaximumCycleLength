using System;

namespace MaximumCycle
{
    class HalistoneSequence
    {
        int StartNum=-1, EndNum=-2;
        int[] SeriesArray = new int[100000];
        int MaxCycleLength = 0,TempCycleLength;

        //Getting Input From User
        public void getInput()
        {
            while (StartNum >= EndNum)
            {
                StartNum = -1;
                EndNum = -2;
                while (StartNum < 0)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the start number");
                        StartNum = Convert.ToInt32(Console.ReadLine());
                        if (StartNum < 0)
                        {
                            Console.WriteLine("Enter a positive number");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }


                while (EndNum < 0)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the End number");
                        EndNum = Convert.ToInt32(Console.ReadLine());
                        if (EndNum < 0)
                        {
                            Console.WriteLine("Enter a positive number");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }
                if(StartNum >= EndNum)
                {
                    Console.WriteLine("\nStart number must be smaller than End number");
                }
            }
        }

        //Finding The Series and Calculating Maximum Cycle Length
         public void getSeries()
          {
              int NumIndex, SeqIndex;

            for (NumIndex = StartNum; NumIndex <= EndNum; NumIndex++)
            {
                TempCycleLength = 0;
                SeriesArray[0] = NumIndex;
                if (SeriesArray[0] != 1)
                {
                    for (SeqIndex = 0; SeriesArray[SeqIndex] > 1; SeqIndex++)
                    {
                        if (SeriesArray[SeqIndex] % 2 == 0)
                        {
                            SeriesArray[SeqIndex + 1] = SeriesArray[SeqIndex] / 2;
                            
                            TempCycleLength += 1;
                        }
                        else
                        {
                            SeriesArray[SeqIndex + 1] = SeriesArray[SeqIndex] * 3 + 1;
                            
                            TempCycleLength += 1;
                        }
                    }
                    SeriesArray[SeqIndex + 1] = 1;
                    TempCycleLength += 1;
                }
                else
                {
                    TempCycleLength = 1;
                }
                                
                if(MaxCycleLength < TempCycleLength)
                {
                    MaxCycleLength = TempCycleLength;
                }
                
                

            }
            Console.WriteLine("\nThe Maximum Cycle Length is {0}", +MaxCycleLength);       
              Console.ReadKey();
         }

        
        //Main Calls The Two Functions
        static void Main(string[] args)
        {
            HalistoneSequence seq = new HalistoneSequence();
            seq.getInput();
            seq.getSeries();
        }
    }
}
