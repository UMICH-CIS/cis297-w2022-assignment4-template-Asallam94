using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatientRecord
{/// <summary>
 /// Patient class to search for information in file
 /// </summary>
 /// <Student>Amani Sallam</Student>
 /// <Class>CIS297</Class>
 /// <Semester>Winter 2022</Semester>
    class Patient
    {/// <summary>
    /// getters and settters for ID, Name ,and Balance
    /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        /// <summary>
        /// set patient id ,name and balance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="balance"></param>
        public Patient(int id, string name, float balance)
        {
            ID = id;
            Name = name;
            Balance = balance;
        }
        /// <summary>
        /// Method to save all patient records 
        /// </summary>
        public void saveData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] lines = File.ReadAllLines("PatientRecord.txt");
            foreach (string line in lines)
            {
                stringBuilder.Append(line + "\n");
            }
            TextWriter txt = new StreamWriter("PatientRecord.txt");
            txt.Write(stringBuilder.ToString() + ID + "\n" + Name + "\n" + Balance);
            txt.Close();
            Console.WriteLine(" Data Saved Successfully !");
        }
    }
}
