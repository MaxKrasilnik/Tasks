using System;

namespace Exceptions
{

    class Program//https://metanit.com/sharp/tutorial/2.28.php
    {
        static void Main(string[] args)
        {
            //1
            //throw new Exception();

            //int x = 0;
            //int y = 0;

            //try
            //{

            //    int result = x / y;
            //}
            //catch (DivideByZeroException) when (y == 0 && x == 0)
            //{
            //    Console.WriteLine("y не должен быть равен 0");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hello world!!!");
            //}


            //2
            //try
            //{
            //    Console.WriteLine("Block try");
            //    ShowExceptionTryFinnaly();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Block catch");
            //}


            //3
            try
            {
                Console.WriteLine("Block try in the Main");
                ShowExceptionThrow();
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch in the Main");
            }

        }

        static void ShowExceptionTryFinnaly()
        {
            int x = 1, y = 0;
            try
            {
                int z = x / y;
            }
            finally
            {
                Console.WriteLine("Block finally");
            }
        }

        static void ShowExceptionThrow()
        {
            int x = 1, y = 0;
            try
            {
                Console.WriteLine("Block try in the ShowExceptionThrow");
                int z = x / y;
            }
            catch
            {
                Console.WriteLine("Block catch in the ShowExceptionThrow");
                throw;
            }
            
        }

    }
}
