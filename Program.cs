using System;

namespace CsutomApplicationException
{

    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get {
                return "Attempted to divide by odd number";
            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
           
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                if (y % 2 > 0)
                {

                       throw new DivideByOddNoException();
                }
                Console.WriteLine("result:" + z);
          
           
          
            Console.ReadLine();
        }
    }



}
