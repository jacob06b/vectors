using System;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector P = new Vector(3, 4);
            Vector Q = new Vector(7, 0);
            Vector R = new Vector(2, 2);
            Console.WriteLine(P.magnitude());
            P.ScalarMultiplication(3);
            Console.WriteLine(P.magnitude());
            Console.WriteLine(Q.getAngle(R));

        }
        public class Vector
        {
            private double x;
            private double y;
            public Vector(double X, double Y)
            {
                x = X;
                y = Y;
            }
            public Vector ScalarMultiplication(double k)
            {
                Vector z = this;
                z.x = z.x * k;
                z.y = z.y * k;
                return z;
            }
            public double magnitude()
            {
                return (Math.Sqrt(this.x * this.x + this.y * this.y));
            }
            public Vector addition(Vector a, Vector b)
            {
                Vector c = new Vector(0, 0);
                c.x = a.x + b.x;
                c.y = a.y + b.y;
                return c;
            }
            public double dotProduct(Vector a, Vector b)
            {
                double total;
                total = (a.x * b.x) + (a.y * b.y);
                return total;
            }
            public double getAngle(Vector a)
            {
                return (Math.Acos(dotProduct(this, a) / (this.magnitude() * a.magnitude()))) * 360 / (2*Math.PI);
            }
        }
    }
}