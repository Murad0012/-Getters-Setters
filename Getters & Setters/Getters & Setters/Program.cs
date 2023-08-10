namespace HomeWork
{
    public class SimCard
    {
        public string? CarrierName;
        public string? Number;
        public double Balance;
        public double Tarif;
        public double Amount;
        public void IncreaseBalance(double amount)
        {
             if(amount <= 0) {return;}
             Balance += amount;
        }

        public void Call(double amount) 
        { 
            if(Tarif > Balance) {Console.WriteLine("not enough balance");return;}
            Balance -= amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomre1 = new SimCard
            {
                CarrierName = "Azercell",
                Number = "+9940555633438",
                Balance = 2,
                Tarif = 0.05,
                Amount = 2
            };
            //IncreaseBalance
            nomre1.IncreaseBalance(nomre1.Amount);
            Console.WriteLine(nomre1.Balance);

            //Call
            nomre1.Call(nomre1.Tarif);
            Console.WriteLine(nomre1.Balance);
        }
    }
}