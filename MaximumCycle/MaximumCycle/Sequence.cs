using System;

namespace MaximumCycle
{
    class Sequence
    {
        int startNum=-1, endNum=-2;
       int[] seriesArray = new int[100000];
        int maxCycleLength = 0,cycleLength;
        public void getInput()
        {
            while (startNum >= endNum)
            {
                startNum = -1;
                endNum = -2;
                while (startNum < 0)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the start number");
                        startNum = Convert.ToInt32(Console.ReadLine());
                        if (startNum < 0)
                        {
                            Console.WriteLine("Enter a positive number");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }


                while (endNum <0)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the End number");
                        endNum = Convert.ToInt32(Console.ReadLine());
                        if (endNum < 0)
                        {
                            Console.WriteLine("Enter a positive number");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }
                if(startNum >= endNum)
                {
                    Console.WriteLine("\nStart number must be smaller than End number");
                }
            }
            

        }
         public void getSeries()
          {
              int numIndex, seqIndex;

            for (numIndex = startNum; numIndex <= endNum; numIndex++)
            {
                cycleLength = 0;
                seriesArray[0] = numIndex;
                if (seriesArray[0] != 1)
                {
                    for (seqIndex = 0; seriesArray[seqIndex] > 1; seqIndex++)
                    {
                        if (seriesArray[seqIndex] % 2 == 0)
                        {
                            seriesArray[seqIndex + 1] = seriesArray[seqIndex] / 2;
                            //Console.Write("{0} ", seriesArray[seqIndex]);
                            cycleLength += 1;
                        }
                        else
                        {
                            seriesArray[seqIndex + 1] = seriesArray[seqIndex] * 3 + 1;
                            //Console.Write("{0} ", seriesArray[seqIndex]);
                            cycleLength += 1;
                        }
                    }
                    seriesArray[seqIndex + 1] = 1;
                    cycleLength += 1;
                    //Console.Write("{0} ", seriesArray[seqIndex + 1]);
                    //Console.WriteLine("\n");
                }
                else
                {
                    cycleLength = 1;
                }
                                
                if(maxCycleLength<cycleLength)
                {
                    maxCycleLength = cycleLength;
                }
                
            }
            Console.WriteLine("\nThe Maximum Cycle Length is {0}", +maxCycleLength);
            //Console.Write(maxCycleLength + " ");
              
              Console.ReadKey();
         }

        

        static void Main(string[] args)
        {
            Sequence seq = new Sequence();
            seq.getInput();
            seq.getSeries();
        }
    }
}
