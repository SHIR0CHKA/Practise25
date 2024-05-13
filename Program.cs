namespace Practise
{
    public class Fraction {
        
        private long wholePart;
        private ushort fractionPart;

        public Fraction(long wholePart, ushort fractionPart)
        {
            this.wholePart = wholePart;
            this.fractionPart = fractionPart;
        }

        public Fraction Add(Fraction other)
        {
            long newWholePart = this.wholePart + other.wholePart;
            ushort newFractionPart;
            if (other.wholePart < 0)
            {
                newFractionPart = (ushort)(this.fractionPart - other.fractionPart);
            }
            else
            {
                 newFractionPart = (ushort)(this.fractionPart + other.fractionPart);
                if (newFractionPart >= 100)
                {
                    newWholePart++;
                    newFractionPart -= 100;
                }
            }
            return new Fraction(newWholePart, newFractionPart);
        }

        public override string ToString()
        {
            return $"{wholePart}.{fractionPart}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction num1 = new Fraction(13, 37);
            Fraction num2 = new Fraction(3, 37);

            Fraction sum = num1.Add(num2);
            Console.WriteLine(sum.ToString());
        }
    }
}