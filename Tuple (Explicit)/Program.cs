namespace ExplicitTuple
{
    class TupleDemo
    {
        
        //Explicit tuple
        public (int sum, int Product) Math(int x, int y)
        {
            int Sum = x+y;//Item1
            int Pro = x*y;
            return (Sum, Pro);
        }
       
        static void Main(string[]args)
        {
           TupleDemo td = new TupleDemo();
           var (sumResult, productResult) = td.Math(2, 6);
            Console.WriteLine(sumResult);
            Console.WriteLine(productResult);
        }
    }
}
