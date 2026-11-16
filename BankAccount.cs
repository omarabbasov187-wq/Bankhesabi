using System;
using System.Collections.Generic;
using System.Text;

namespace Ivraham.Midl
{
    public class BankAccount
    {
        public string AZ123 { get; set; }
        public string OmarAbbasov { get; set; }
        public decimal HesabdakıMebleg { get; set; }

        public BankAccount(string az123, string omarAbbasov, decimal hesabdakıMebleg)
        {
            AZ123 = az123;
            OmarAbbasov = omarAbbasov;
            HesabdakıMebleg = hesabdakıMebleg;
        }


        public void Deposit()
        {
            if (HesabdakıMebleg < 0)
            {
                HesabdakıMebleg += 1000;
                Console.WriteLine($"{1000} AZN hesaboniza əlavə olundu.");
            }
        }

        public void Withdraw()
        {
            if (HesabdakıMebleg >= 0)
            {
                HesabdakıMebleg -= 50;
                Console.WriteLine($"{50}AZN hesabinizdan cixildi");
            }


        }

        public void Transfer(BankAccount Ibrahim, decimal amount)
        {
            if (HesabdakıMebleg >= 100)
            {
                HesabdakıMebleg -= 100;
                Ibrahim.HesabdakıMebleg += 100;
                Console.WriteLine($"{100} AZN {Ibrahim} hesabindan transfer olundu.");

            }
           
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Hesab Nomresi: {AZ123}");
            Console.WriteLine($"Hesab Sahibinin Adi: {OmarAbbasov}");
            Console.WriteLine($"Hesabda olan Mebleg: {HesabdakıMebleg}");
        }


    }
}
