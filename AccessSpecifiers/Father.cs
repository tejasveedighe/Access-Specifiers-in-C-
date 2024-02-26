namespace AccessSpecifiers
{
    public class Father
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        protected void Test2()
        {
            Console.WriteLine("Protected Method");
        }
        public void Test3()
        {
            Console.WriteLine("Public Method");
        }

        // accessible only in the same project not from other project
        internal void Test4()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Protected Internal Method");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // class can only be public and internal and cannot have any other scope
    internal class Test
    {
        
    }
}
