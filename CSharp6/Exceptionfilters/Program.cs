using System;
using static System.Console;

namespace Exceptionfilters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int errorCode = 404;
            try
            {
                throw new Exception(errorCode.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                WriteLine("This is Http Error");
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                WriteLine("This is Unathorized Error");
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                WriteLine("Forbidden");
            }
            ReadLine();
        }
    }
}
