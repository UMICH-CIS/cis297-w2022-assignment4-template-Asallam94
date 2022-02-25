using System;

namespace PatientRecord
{
    class Program
    {   /// <summary>
        /// This program allowes user to search,add,display patients record.
        /// </summary>
        /// <Student>Amani Sallam</Student>
        /// <Class>CIS297</Class>
        /// <Semester>Winter 2022</Semester>
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("\nMain menu");
            Console.WriteLine("\n1. Save Patient's Record");
            Console.WriteLine("2. View All Record");
            Console.WriteLine("3. View Patient Record");
            Console.WriteLine("4. Get balance record");
            Console.WriteLine("5. Exit");
            string n = Console.ReadLine();
            if (n == "1")
            {
            start1:
                Console.Write("\nEnter Patient ID: ");
                int id = 0;
                try
                {
                    id = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nInvalid input\n", e);
                    goto start1;
                }
                finally
                {

                }
                Console.Write("Enter Patient Name: ");
                string name = Console.ReadLine();
            start2:
                Console.Write("Enter current balance: ");
                float balance = 0;
                try
                {
                    balance = float.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("error ", e);
                    goto start2;
                }
                finally
                {

                }
                Patient patient = new Patient(id, name, balance);
                patient.saveData();
            }
            else if (n == "2")
            {
                AllRecord allRecord = new AllRecord();
                allRecord.PatientsRecord();
            }
            else if (n == "3")
            {
                SingleRecord singleRecord = new SingleRecord();
                singleRecord.PatientsRecord();
            }
            else if (n == "4")
            {
                Balance balance = new Balance();
                balance.PatientsRecord();
            }
            else if (n == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid input\n");
            }
            goto start;
        }
    }
}
