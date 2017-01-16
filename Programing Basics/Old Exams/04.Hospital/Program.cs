using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int calculationsDuration = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsSendedToOtherHospital = 0;
            int patientsChecked = 0;

            for (int days = 1; days <= calculationsDuration; days++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());

                if (days % 3 == 0 && patientsChecked < patientsSendedToOtherHospital)
                {
                    doctors++;
                }

                patientsSendedToOtherHospital = patientsPerDay <= doctors ? patientsSendedToOtherHospital += 0 :
                    patientsSendedToOtherHospital += patientsPerDay - doctors;
                patientsChecked = patientsPerDay <= doctors ? patientsChecked += patientsPerDay :
                    patientsChecked += doctors;
            }
            Console.WriteLine("Treated patients: {0}.", patientsChecked);
            Console.WriteLine("Untreated patients: {0}.", patientsSendedToOtherHospital);
        }
    }
}
