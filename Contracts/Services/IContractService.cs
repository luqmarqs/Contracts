using Contracts.Entities;

namespace Contracts.Services
{
    interface IContractService
    {
        public double InterestTax { get; set; }
        public double PaymentTax { get; set; }

        public void InstallmentProcessing(Contract contract, int InstallmentNumber);
    }
}
