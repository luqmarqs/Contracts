using Contracts.Entities;

namespace Contracts.Services
{
    class PayPalService : IContractService
    {
        public double InterestTax { get; set; }
        public double PaymentTax { get; set; }
        public double BaseValue { get; set; }

        public PayPalService(double baseValue)
        {
            InterestTax = 0.01;
            PaymentTax = 0.02;
            BaseValue = baseValue;
        }

        public void InstallmentProcessing (Contract contract, int installmentNumber)
        {
            double value = BaseValue + BaseValue*InterestTax*installmentNumber + BaseValue*PaymentTax;
            DateTime dueTo = contract.ContractDate;

            dueTo = dueTo.AddMonths(installmentNumber);
            
            Installment installment = new Installment(dueTo, value);

            contract.Installments.Add(installment);

        }
    }
}
