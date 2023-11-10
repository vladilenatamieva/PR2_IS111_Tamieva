namespace PR2_IS111_Tamieva
{
    internal class з1
    {

        public interface IMoney
        {
            int Rubli { get; set; }
            int Kopeyki { get; set; }
            void Print();
        }

        public class Money : IMoney
        {
            public int Rubli { get; set; }
            public int Kopeyki { get; set; }

            public void Print()
            {
                Console.WriteLine("{0} руб. {1} коп.", Rubli, Kopeyki);
            }
        }

        public interface IGood
        {
            IMoney Price { get; set; }
            void DecreasePrice(int percent);
        }

        public class Good : IGood
        {
            public IMoney Price { get; set; }

            public void DecreasePrice(int percent)
            {
                double decreasePercent = percent / 100.0;
                int decreaseAmount = (int)(Price.Rubli * decreasePercent);

                Price.Rubli -= decreaseAmount;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Money money = new Money() { Rubli = 10, Kopeyki= 50 };
                money.Print(); 
                // Выводит: 10 руб. 50 коп.

                Good good = new Good() { Price = money };
                good.DecreasePrice(20);
                money.Print();
                // Выводит: 8 руб. 50 коп.
            }
        }
    }
}
