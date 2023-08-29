namespace NewTask
{
    public class Program
    {
        public static bool CustomTryParse(string input, out int a)
        {
            try
            {
                a = int.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                a = 0;
                return false;
                
            }
                
        }
        static void Main(string[] args)
        {
            if( CustomTryParse("19", out int a))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Failed");
            }



        }
    }
}