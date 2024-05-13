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

        public string Add(Fraction other)
        {
            long newWholePart = this.wholePart + other.wholePart;
            ushort newFractionPart;
            if (other.wholePart < 0)
            {
                newFractionPart = (ushort)(this.fractionPart - other.fractionPart);
                
                String thisFracPart = this.fractionPart.ToString();
                String otherFracPart = other.fractionPart.ToString();

                while (thisFracPart.Length != otherFracPart.Length)
                {
                    if (thisFracPart.Length > otherFracPart.Length)
                    {
                        otherFracPart = otherFracPart + "0";
                    }
                    else
                    {
                        thisFracPart = thisFracPart + "0";
                    }
                }

                newFractionPart = (ushort)(ushort.Parse(thisFracPart) + ushort.Parse(otherFracPart));

                if (newFractionPart.ToString().Length > Math.Max(thisFracPart.Length, otherFracPart.Length))
                {

                    newWholePart++;
                    newFractionPart = (ushort)(newFractionPart - Math.Pow(10, newFractionPart.ToString().Length - 1));

                    string additionalPart = "";
                    for (int i = -1; i <= (newFractionPart.ToString().Length - otherFracPart.Length); i++)
                    {
                        additionalPart += "0";
                    }
                    return $"{newWholePart}." + additionalPart + $"{newFractionPart}";
                }
                else
                {
                    return $"{newWholePart}.{newFractionPart}";
                }
            }
            else
            {
                String thisFracPart = this.fractionPart.ToString();
                String otherFracPart = other.fractionPart.ToString();

                while (thisFracPart.Length != otherFracPart.Length)
                {
                    if (thisFracPart.Length > otherFracPart.Length)
                    {
                        otherFracPart = otherFracPart + "0";
                    }
                    else {
                        thisFracPart = thisFracPart + "0";
                    }
                }

                newFractionPart = (ushort)(ushort.Parse(thisFracPart) + ushort.Parse(otherFracPart));

                if (newFractionPart.ToString().Length > Math.Max(thisFracPart.Length, otherFracPart.Length)) {
                    
                    newWholePart++;
                    newFractionPart = (ushort)(newFractionPart - Math.Pow(10, newFractionPart.ToString().Length - 1));
                    
                    string additionalPart = "";
                    for (int i = -1; i <= (newFractionPart.ToString().Length - otherFracPart.Length); i++)
                    {
                        additionalPart += "0";
                    }
                    return $"{newWholePart}." + additionalPart + $"{newFractionPart}";
                } else {
                    return $"{newWholePart}.{newFractionPart}";
                }
            }
            
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction num1 = new Fraction(13, 370);
            Fraction num2 = new Fraction(3, 37);

            String sum = num1.Add(num2);
            Console.WriteLine(sum);
        }
    }
}