using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatientRecord
{/// <summary>
 /// class to read all records of patient 
 /// </summary>
 /// <Student>Amani Sallam</Student>
 /// <Class>CIS297</Class>
 /// <Semester>Winter 2022</Semester>
    class AllRecord
    {/// <summary>
    /// Default constructor
    /// </summary>
        public AllRecord()
        {

        }
        /// <summary>
        /// method to read data from file
        /// </summary>
        public void PatientsRecord()
        {
            int i = 0;
            int j = 0;
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("PatientRecord.txt");
            foreach (string line in lines)
            {
                if (i == 0)
                {
                    Console.WriteLine("\nID: " + lines[i] + "\nName: " + lines[i + 1] + "\nBalance: " + lines[i + 2]);
                    j = j + 3;
                }
                else if (i == j)
                {
                    Console.WriteLine("\nID: " + lines[i] + "\nName: " + lines[i + 1] + "\nBalance: " + lines[i + 2]);
                    j = j + 3;
                }
                i++;
            }
        }
    }
}
