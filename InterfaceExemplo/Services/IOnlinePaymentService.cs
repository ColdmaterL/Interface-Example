namespace InterfaceExemplo.Services{
    interface IOnlinePaymentService{
        double PaymentFee(double amount);
        double Interest(double amount, int month);
    }
}