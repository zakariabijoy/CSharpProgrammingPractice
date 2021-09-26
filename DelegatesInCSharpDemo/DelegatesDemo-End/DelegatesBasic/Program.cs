using System;

namespace DelegatesBasic
{
    #region Single cast delegate


    ////Defining Delegates
    ////Note: The access specifeis, return type and the number, order and type of parameters of delegate
    ////should be same as the function it refers to.
    //public delegate void AddDelegate(int a, int b);
    //public delegate string GreetingsDelegate(string name);
    //public class Program
    //{
    //    //Defining Methods
    //    //NonStatic method
    //    public void Add(int x, int y)
    //    {
    //        Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
    //    }
    //    //Static Method
    //    public static string Greetings(string name)
    //    {
    //        return "Hello @" + name;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();

    //        //Instantiating delegate by passing the target function Name
    //        //The Add method is non static so here we are calling method using object
    //        AddDelegate ad = new AddDelegate(obj.Add);

    //        //Greetings method is static so here we are callling the method by using the class name
    //        GreetingsDelegate gd = Program.Greetings;

    //        //Invoking The Delegates
    //        ad(100, 50);                // output: The Sum of 100 and 50, is 150

    //        string GreetingsMessage = gd("Pranaya");

    //        //We can also use Invoke method to execute delegates
    //        // ad.Invoke(100, 50);
    //        // string GreetingsMessage = gd.Invoke("Pranaya");
    //        Console.WriteLine(GreetingsMessage);      // output:  Hello @Pranaya
    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region Multicast delegate

    //Defining Delegates
    //Note: The access specifeis, return type and the number, order and type of parameters of delegate
    //should be same as the function it refers to.
    delegate int NumberChanger(int n);
    public class Program
    {
        static int num = 10;  //field 

        //Defining Methods
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        //Defining Methods
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        //Defining Methods
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());  //output: Value of Num: 75
            Console.ReadKey();
        }
    }

    #endregion
}
