using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatientRecord
{/// <summary>
 /// single record class
 /// </summary>
 /// <Student>Amani Sallam</Student>
 /// <Class>CIS297</Class>
 /// <Semester>Winter 2022</Semester>
    class SingleRecord
    {/// <summary>
    /// default constructor
    /// </summary>
        public SingleRecord()
        {

        }
        /// <summary>
        /// show and save all patient information
        /// </summary>
        public void PatientsRecord()
        {
        start:
            Console.Write("\nEnter Patient ID: ");
            int id = 0;
            try
            {
                id = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nInvalid input\n", e);
                goto start;
            }
            finally
            {

            }
            int i = 0;
            int j = 0;
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("PatientRecord.txt");
            foreach (string line in lines)
            {
                if (i == 0 && Int32.Parse(lines[i]) == id)
                {
                    Console.WriteLine("\nID: " + lines[i] + "\nName: " + lines[i + 1] + "\nBalance: " + lines[i + 2]);
                    j = j + 3;
                }
                else if (i == j)
                {
                    if (Int32.Parse(lines[i]) == id)
                    {
                        Console.WriteLine("\nID: " + lines[i] + "\nName: " + lines[i + 1] + "\nBalance: " + lines[i + 2]);
                    }
                    j = j + 3;
                }
                i++;
            }
        }
    }
}
