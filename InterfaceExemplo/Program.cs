using System.Globalization;
using InterfaceExemplo.Entities;
using InterfaceExemplo.Services;

namespace InterfaceExemplo{
    class Program{
        static void Main(string[] args){
            int number, installments;
            double totalvalue;
            DateTime date;
            Contract contract;
            ContractService contractService;
            
            System.Console.WriteLine("Enter contract data:");
            System.Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            System.Console.Write("Date (dd/MM/yyyy): ");
            date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            System.Console.Write("Contract Value: ");
            totalvalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Enter number of installments: ");
            installments = int.Parse(Console.ReadLine());

            contract = new Contract(number, date, totalvalue/installments);
            contractService = new ContractService(new PayPalService());

            for(int i = 1; i <= installments; i++){
                contractService.ProcessContract(contract, i);
            }

            System.Console.WriteLine(contract);

        }
    }
}