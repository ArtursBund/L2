using System;

namespace Uzd2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Uzd
            {
                Console.WriteLine("Kā tevi sauc?");
                string name = Console.ReadLine();
                Console.WriteLine("Sveiks, {0}.", name);
            }
            // 2 Uzd
            {
                Console.WriteLine("Kāds ir tavs vecums?");
                int age;
                string age_s = Console.ReadLine();
                bool age_t = int.TryParse(age_s, out age);
                while (age_t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    age_s = Console.ReadLine();
                    age_t = int.TryParse(age_s, out age);
                }
                bool tests = age >= 18;
                age += 1;
                if (tests == true)
                {
                    Console.WriteLine("Nākamgad tev paliks {0}, Tu esi pilngadīgs", age);
                }
                else
                {
                    Console.WriteLine("Nākamgad tev paliks {0}, Tu vēl neesi pilngadīgs", age);
                }
            }
            // 3 Uzd
            {
                Console.WriteLine("\nNoteiksim lielāko skaitli. \nIevadi skaitli 1:");
                string n_1s = Console.ReadLine();
                int n_1;
                bool n_1t = int.TryParse(n_1s, out n_1);
                while (n_1t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_1s = Console.ReadLine();
                    n_1t = int.TryParse(n_1s, out n_1);
                }

                Console.WriteLine("Un skaitli 2:");
                string n_2s = Console.ReadLine();
                int n_2;
                bool n_2t = int.TryParse(n_2s, out n_2);
                while (n_2t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_2s = Console.ReadLine();
                    n_2t = int.TryParse(n_2s, out n_2);
                }
                int n_Max = Math.Max(n_1, n_2);
                Console.WriteLine("Lielākais skaitlis ir: {0}", n_Max);
            }
            // 4 Uzd
            {
                Console.WriteLine("\nNoteiksim mazāko skaitli. \nIevadi skaitli 1:");
                string n_3s = Console.ReadLine();
                int n_3;
                bool n_3t = int.TryParse(n_3s, out n_3);
                while (n_3t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_3s = Console.ReadLine();
                    n_3t = int.TryParse(n_3s, out n_3);
                }

                Console.WriteLine("Un skaitli 2:");
                string n_4s = Console.ReadLine();
                int n_4;
                bool n_4t = int.TryParse(n_4s, out n_4);
                while (n_4t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_4s = Console.ReadLine();
                    n_4t = int.TryParse(n_4s, out n_4);
                }
                int n_Min = Math.Min(n_3, n_4);
                Console.WriteLine("Mazākais skaitlis ir: {0}", n_Min);
            }
            // 5 Uzd
            {
                Console.WriteLine("\nIegūsim atlikumu divu skaitļu dalījumam. \nIevadi skaitli 1:");
                string n_5s = Console.ReadLine();
                int n_5;
                bool n_5t = int.TryParse(n_5s, out n_5);
                while (n_5t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_5s = Console.ReadLine();
                    n_5t = int.TryParse(n_5s, out n_5);
                }

                Console.WriteLine("Un skaitli 2:");
                string n_6s = Console.ReadLine();
                int n_6;
                bool n_6t = int.TryParse(n_6s, out n_6);
                while (n_6t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_6s = Console.ReadLine();
                    n_6t = int.TryParse(n_6s, out n_6);
                }
                int n_Mod = n_5 % n_6;
                Console.WriteLine("Atlikums ir: {0}", n_Mod);
            }
            //6 Uzd
            {
                Console.WriteLine("\nNoteiksim vai skaitlis ir pāra vai nepāra. \nIevadi skaitli:");
                string n_7s = Console.ReadLine();
                int n_7;
                bool n_7t = int.TryParse(n_7s, out n_7);
                while (n_7t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_7s = Console.ReadLine();
                    n_7t = int.TryParse(n_7s, out n_7);
                }

                if (n_7 % 2 == 0)
                {
                    Console.WriteLine("Skaitlis ir pāra");
                }
                else
                {
                    Console.WriteLine("Skaitlis ir nepāra");
                }
            }
            //7 Uzd
            {
                Console.WriteLine("\nNoteiksim taisntūra laukumu. \nPirmās malas garums:");
                string n_8s = Console.ReadLine();
                double n_8;
                bool n_8t = double.TryParse(n_8s, out n_8);
                while (n_8t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_8s = Console.ReadLine();
                    n_8t = double.TryParse(n_8s, out n_8);
                }

                Console.WriteLine("Otrās malas garums:");
                string n_9s = Console.ReadLine();
                double n_9;
                bool n_9t = double.TryParse(n_9s, out n_9);
                while (n_9t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_9s = Console.ReadLine();
                    n_9t = double.TryParse(n_9s, out n_9);
                }
                double Laukums = Math.Round(n_8 * n_9, 2);
                Console.WriteLine("Laukums ir: {0}", Laukums);
            }
            //8 Uzd
            {
                Console.WriteLine("\nNoteiksim vienādsānu trijstūra laukumu. \nMalas garums:");
                string n_10s = Console.ReadLine();
                double n_10;
                bool n_10t = double.TryParse(n_10s, out n_10);
                while (n_10t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    n_10s = Console.ReadLine();
                    n_10t = double.TryParse(n_10s, out n_10);
                }

                double Laukums = (n_10 * n_10) / 2;
                Console.WriteLine("Laukums ir: {0}", Laukums);
            }
            //9 Uzd
            {
                Console.WriteLine("\nUn tad vēlreiz.... Kā tevi sauc?");
                string name_2 = Console.ReadLine();
                Console.WriteLine("Un kāds ir tavs vecums?");
                int age_2;
                string age_2s = Console.ReadLine();
                bool age_2t = int.TryParse(age_2s, out age_2);


                while (age_2t == false)
                {
                    Console.WriteLine("Nav ievadīts skaitlis, pamēģini vēlreiz:");
                    age_2s = Console.ReadLine();
                    age_2t = int.TryParse(age_2s, out age_2);
                }

                string interpolatedtext = $"Sveiks {name_2}, tavs vecums ir {age_2}.";
                Console.WriteLine(interpolatedtext);
            }
        }
    }
}
