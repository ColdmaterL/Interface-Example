using System.Text;

namespace InterfaceExemplo.Entities{
    class Contract{
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }

        public Contract (int number, DateTime date, double totalValue){
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Installment inst in Installment){
                sb.Append(inst.DueDate.ToString("dd/MM/yyyy") + " - " + inst.Amount + "\n");
            }
            return sb.ToString();
        }
        
    }
}