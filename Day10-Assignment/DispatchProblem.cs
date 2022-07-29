using System;

namespace DisptachProblem
{
    public class A
    {
        public virtual void M(IVisitor visitor)
        {
            visitor.Visit(this);
            Console.WriteLine("A.M");
        }
    }

    public class B : A
    {
        public override void M(IVisitor visitor)
        {
            visitor.Visit(this);
            Console.WriteLine("B.M");
        }
    }

    public interface IVisitor
    {
        void Visit(B item);
        void Visit(A item);
    }

    public sealed class Visitor : IVisitor
    {
        public void Visit(A item)
        {
            Console.WriteLine("C.A.N");
            Console.WriteLine(item);
            //item.M();
        }

        public void Visit(B item)
        {
            Console.WriteLine("C.B.N");
            Console.WriteLine(item);
            //item.M();
        }
    }

    public class Program
    {
        public static void Main()
        {
            var visitor = new Visitor();
            A obj = new B();
            obj.M(visitor);
            Console.Read();
        }
    }
}