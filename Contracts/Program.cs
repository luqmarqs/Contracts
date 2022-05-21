using Contracts.Entities;
using Contracts.Services;
using System.Globalization;


Console.WriteLine("Enter contract data: ");
Console.Write("Number: ");
int number  = int.Parse(Console.ReadLine());
Console.Write("Date: ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double totalValue = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int totalInstallments = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, totalValue, totalInstallments, new PayPalService(totalValue/totalInstallments));

contract.callService();

Console.WriteLine("Installments: ");

foreach(Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}
