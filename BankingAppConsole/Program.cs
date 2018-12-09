using BankingApp.Configuration;
using BankingApp.Data;
using BankingApp.UI;
using BankingAppMemoryPerisitence;
using BankingAppEFCorePersistence;
using Newtonsoft.Json;
using System;

namespace BankingAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //new BankingAppConfig().SetPersistenceProvider(new MemoryPeristenceProvider());
            new BankingAppConfig().SetPersistenceProvider(new EFPersistenceProvider());
            var employeeActions = new EmployeeActions();

            while(true)
            {
                Console.Write(@"Wybierz działanie:
1 - Dodaj Klienta indywidualnego
2- Znajdź klienta indywidualnego po danych osoby
3 - Znajdź klienta indywidualnego po danych klienta
99 - Wyjdź
");
                var number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        {
                            var klient = employeeActions.CreateIndividualClient(BuildPersonData());
                            Console.WriteLine("Utworzono klienta:");
                            Console.WriteLine(JsonConvert.SerializeObject(klient));
                            break;
                        }
                    case "2":
                        {
                            var klient = employeeActions.FindIndividualClient(BuildPersonData());
                            Console.WriteLine("Znaleziono klienta:");
                            Console.WriteLine(JsonConvert.SerializeObject(klient));
                            break;
                        }
                    case "3":
                        {
                            var klient = employeeActions.FindIndividualClient(BuildClientData());
                            Console.WriteLine("Znaleziono klienta:");
                            Console.WriteLine(JsonConvert.SerializeObject(klient));
                            break;
                        }
                    case "99":
                        return;
                    default:
                        Console.WriteLine($"Nieznana operacja: [{number}]");
                        break;
                }
            }
        }

        private static PersonData BuildPersonData()
        {
            PersonData data = new PersonData();
            string input;

            Console.WriteLine("Podaj imię");
            input = Console.ReadLine();
            data.FirstName = input == "" ? null : input;

            Console.WriteLine("Podaj nazwisko");
            input = Console.ReadLine();
            data.LastName = input == "" ? null : input;

            Console.WriteLine("Podaj PESEL");
            input = Console.ReadLine();
            data.Pesel = input == "" ? null : input;

            Console.WriteLine("Podaj NIP");
            input = Console.ReadLine();
            data.Nip = input == "" ? null : input;

            Console.WriteLine("Podaj datę urodzenia");
            input = Console.ReadLine();
            DateTime dateOfBirth;
            DateTime.TryParse(input, out dateOfBirth);
            data.DateOfBirth = dateOfBirth;

            data.Deceased = false;

            return data;
        }

        private static ClientData BuildClientData()
        {
            ClientData data = new ClientData();
            string input;
            long id;

            Console.WriteLine("Podaj ID klienta");
            input = Console.ReadLine();

            data.clientId = long.TryParse(input, out id) ? id : (long?)null;

            Console.WriteLine("Podaj ID osoby");
            input = Console.ReadLine();
            data.personId = long.TryParse(input, out id) ? id : (long?)null;

            Console.WriteLine("Czy aktywny? Y/N");
            switch (Console.ReadKey().KeyChar)
            {
                case 'y': 
                case 'Y': data.active = true;
                    break;
                default:
                    data.active = false;
                    break;

            }

            return data;
        }
    }
}
