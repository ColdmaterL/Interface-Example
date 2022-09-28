using InterfaceExemplo.Entities;

namespace InterfaceExemplo.Services{
    class PayPalService : IOnlinePaymentService{
        public double PaymentFee(double amount){
            return amount + (2 * amount/100);
        }
        public double Interest(double amount, int month){
            return amount + amount/100 * month;
        }
    }
}