using System;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            A classExemp = new A(new A(new B(), new B()), new B());
        }
    }
}
