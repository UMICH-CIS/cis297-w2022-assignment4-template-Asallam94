using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatientRecord
{ 
    /// <summary>
    /// Balance class
    /// <summary>
    /// <Student>Amani Sallam</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
class Balance
    {/// <summary>
    /// default constractor
    /// </summary>
        public Balance()
        {

        }
        /// <summary>
        /// method for balance owed
        /// </summary>
        public void PatientsRecord()
        {
            Console.Write("\nEnter balance to get record: ");
            float balance = float.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("PatientRecord.txt");
            foreach (string line in lines)
            {
                if (i == 0 && float.Parse(lines[i + 2]) >= balance)
                {
                    Console.WriteLine("\nID: " + lines[i] + "\nName: " + lines[i + 1] + "\nBalance: " + lines[i + 2]);
                    j = j + 3;
                }
                else if (i == j)
                {
                    if (Int32.Parse(lines[i + 2]) >= balance)
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
