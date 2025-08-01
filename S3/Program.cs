namespace S3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object | instance from Car 
            //Car C1;
            // 1. Allocate 4 Bytes in Stack => Null

            //C1 = new Car(10,"Audi",500); // empty paramterless constructor

            //C1 = new Car(10,"BMW");
            //Console.WriteLine(C1);
            //Console.WriteLine(C1.ToString);

            //Parent parent = new Parent(10,20);

            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());
            //parent.MyFun();

            Child child = new Child(10,20,30);
            Console.WriteLine(child);
            Console.WriteLine(child.Product());
            child.MyFun();

        }
    }
}
