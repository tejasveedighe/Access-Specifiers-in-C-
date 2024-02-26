namespace AccessDemo2
{
    // using reference to other project and using inheritance 
    class Uncle : AccessSpecifiers.Father
    {
        static void Main(string[] args)
        {
            Uncle n = new Uncle();
            n.Test2(); // protected
            n.Test3(); // public
            n.Test5(); // protected internal

            // internal method cannot be access as Neighbour is not in the same class
            // all classes are internal by default
        }
    }
}
