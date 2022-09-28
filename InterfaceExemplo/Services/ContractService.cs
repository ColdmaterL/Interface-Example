using InterfaceExemplo.Entities;

namespace InterfaceExemplo.Services{
    class ContractService{
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService){
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int month){
            double finalValue;
            Installment installment;

            finalValue = _onlinePaymentService.Interest(contract.TotalValue, month);
            finalValue = _onlinePaymentService.PaymentFee(finalValue);

            installment = new Installment(contract.Date.AddMonths(month), finalValue);
            contract.Installment.Add(installment); 
        }
    }
}