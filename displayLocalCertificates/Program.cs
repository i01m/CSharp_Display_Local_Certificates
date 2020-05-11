using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace displayLocalCertificates
{
    class Program
    {
        static void Main(string[] args)
        {
            X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);

            store.Open(OpenFlags.ReadOnly);

            Console.WriteLine("Friendly Name \t\t\t\t\t Expiration Date");
            foreach (X509Certificate2 certificate in store.Certificates)
                Console.WriteLine("{0}\t{1}", certificate.FriendlyName, certificate.NotAfter);
            Console.ReadKey();

        }
    }
}
