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
            CustomTryParse("aggg", out int a);
           
             Console.WriteLine(a);
           
          



        }
    }
}