using Contracts.Services;
namespace Contracts.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double TotalValue { get; set; }

        public List<Installment>? Installments { get; set; }

        public int TotalInstallments { get; set; }

        IContractService _contractService;

        public Contract(int contractNumber, DateTime contractDate, double totalValue, int totalInstallments, IContractService service)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            TotalValue = totalValue;
            Installments = new List<Installment>();
            _contractService = service;
            TotalInstallments = totalInstallments;

        }

        public void callService()
        {
            for (int i = 1; i <= TotalInstallments; i++)
            {
                _contractService.InstallmentProcessing(this, i);
            }
        }
    }
}
