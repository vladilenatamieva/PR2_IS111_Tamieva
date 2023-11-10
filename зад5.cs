namespace зад5
{
    public abstract class Log
    {
        public abstract void Debug(string message);
        public abstract void Info(string message);
        public abstract void Warn(string message);
        public abstract void Error(string message);
        public abstract void Crit(string message);
    }

    public class ConsoleLog : Log
    {
        public override void Debug(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Debug: " + message);
            Console.ResetColor();
        }

        public override void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Info: " + message);
            Console.ResetColor();
        }

        public override void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: " + message);
            Console.ResetColor();
        }

        public override void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ResetColor();
        }

        public override void Crit(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Critical: " + message);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main()
        {
            ConsoleLog logger = new ConsoleLog();
            logger.Debug("Это сообщение debug");
            logger.Info("Это сообщение info");
            logger.Warn("Это сообщение warning");
            logger.Error("Это сообщение error");
            logger.Crit("Это сообщение critical");
        }
    }
}
