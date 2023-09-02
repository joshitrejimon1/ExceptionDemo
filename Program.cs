namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 0, res = 0;

            try
            {
                n2 = Convert.ToInt32(args[0]);
                res = n1 / n2;

            }

            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch(OverflowException of) 
            {
                Console.WriteLine(of.Message);
            }

            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            catch(DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }

            catch(Exception e) 
            { 
                Console.WriteLine(e.Message);
            
            }

            Console.WriteLine("RESULT IS "+res);
            Console.WriteLine("goodBYE");
        }
    }
}