namespace InterfaceExemplo.Entities{
    class Installment{
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime duedate, double amount){
            DueDate = duedate;
            Amount = amount;
        }
    }
}