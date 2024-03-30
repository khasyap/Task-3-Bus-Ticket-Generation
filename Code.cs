namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bus Ticket Generation");
            string a, b, c, d,f;
            int e;
            Console.Write("Depo No            : ");
            a=Console.ReadLine();
            Console.Write("Date(DD/MM/YYYY): ");
            b=Console.ReadLine();
            Console.Write("Start              : ");
            c=Console.ReadLine();
            Console.Write("Destination        : ");
            d=Console.ReadLine();
            Console.Write("Vehile No          : ");
            f=Console.ReadLine();
            Console.Write("No. of Adult       : ");
            e=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Andhra Pradesh State Road Transport Corporation");
            Console.WriteLine("Depo No        : " + a);
            Console.WriteLine("Vehical No     : "+f);
            Console.WriteLine("Date           : " + b);
            Console.WriteLine();
            Console.WriteLine("From " + c  + "X"  +  "40" + " = " + (e * 40));
            Console.WriteLine();
            Console.WriteLine("Total          = " + (e * 40));
           
            Console.WriteLine("                  NOT TRASFERABLE");
        }
    }
}
