
namespace hw16
{
    class CreditCard
    {
        public string NumberOfCard { get; set; }
        public string PIP { get; set; }
        public DateOnly Complite { get; set; }
        public int PineCode { get; set; }
        public double CreditLimit { get; set; }
        public double AmountOfMoney { get; set; }

        public CreditCard() { }
        public void ShowInfo()
        {
            Console.WriteLine($"Number of card:\t\t{NumberOfCard}");
            Console.WriteLine($"PIP:\t\t\t{PIP}");
            Console.WriteLine($"Date work completion:   {Complite}");
            Console.WriteLine($"Pine-Code:\t\t{PineCode}");
            Console.WriteLine($"Credit Limit:\t{CreditLimit}");
            Console.WriteLine($"Amount of Money:\t{AmountOfMoney}");
        }
    }
}
