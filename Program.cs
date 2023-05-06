namespace ProgramReview2
{
    public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("string:" + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + "=");
                int cal = 0;
                for(int j=0;j<str.Length;j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);  
            }
            Console.ReadLine();
        }
    }
}