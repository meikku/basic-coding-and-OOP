using System;
using System.Collections.Generic;

namespace Exercise
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();


        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (!owners.ContainsKey(licensePlate))
            {
                owners.Add(licensePlate, owner);
                return true;

            }
            return false;
        }

        public string Get(LicensePlate licensePlate)
        {
            if (owners.ContainsKey(licensePlate))
            {
                return owners[licensePlate];
            }
            return "No such license";
        }

        public bool Remove(LicensePlate licensePlate)
        {
            if (owners.ContainsKey(licensePlate))
            {
                owners.Remove(licensePlate);
                return true;
            }
            return false;
        }

        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> keyValuePair in owners)
            {
                Console.WriteLine(keyValuePair.Key);
            }
        }

        public void PrintOwners()
        {
            List<string> namesOfOwners = new List<string>();
            foreach (KeyValuePair<LicensePlate, string> keyValuePair in owners)
            {
                if (!namesOfOwners.Contains(keyValuePair.Value))
                {
                    Console.WriteLine(keyValuePair.Value);
                    namesOfOwners.Add(keyValuePair.Value);
                }

            }
        }
    }
}