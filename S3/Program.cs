namespace S3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object | instance from Car 
            Car C1;
            // 1. Allocate 4 Bytes in Stack => Null

            C1 = new Car(10,"Audi",500); // empty paramterless constructor


            Console.WriteLine(C1);
            //Console.WriteLine(C1.ToString);

        }
    }
}
