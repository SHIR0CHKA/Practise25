namespace Practise
{
    //класс, описывающий дробное число
    public class Fraction
    {
        //переменная целой части
        private long wholePart;
        //переменная дробной части
        private ushort fractionPart;

        private double fraction;



        //конструктор
        public Fraction(long wholePart, ushort fractionPart)
        {
            this.wholePart = wholePart;
            this.fractionPart = fractionPart;

            fraction = double.Parse(wholePart.ToString() + "," + fractionPart.ToString());
        }

        //функция сложения
        public double DAdd(Fraction other)
        {
            return this.fraction + other.fraction;
        }

        //функция вычитания
        public double DSubstact(Fraction other)
        {
            return this.fraction - other.fraction;
        }

        //функция умножения
        public double DMultiply(Fraction other)
        {
            return this.fraction * other.fraction;
        }

        //функция сравнения
        public string DCompare(Fraction other)
        {
            //обработка условия сравнения
            switch (this.fraction > other.fraction)
            {
                case true:
                    //вывод если первое число больше второго
                    return $"Число {this.fraction} больше числа {other.fraction} на {Math.Round(this.fraction - other.fraction, 4)}";
                    break;

                case false:
                    if (this.fraction < other.fraction)
                    {
                        //вывод если второе число больше первого
                        return $"Число {other.fraction} больше числа {this.fraction} на {Math.Round(other.fraction - this.fraction, 4)}";
                    }
                    else
                    {
                        //вывод если числа равны
                        return "Числа равны";
                    }
                    break;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целую и дробную часть первого числа");
            //объявление экземпляра класса
            Fraction num1 = new Fraction(long.Parse(Console.ReadLine()), ushort.Parse(Console.ReadLine()));

            Console.WriteLine("Введите целую и дробную часть второго числа");
            //объявление экземпляра класса
            Fraction num2 = new Fraction(long.Parse(Console.ReadLine()), ushort.Parse(Console.ReadLine()));

            double sum = num1.DAdd(num2);
            Console.WriteLine($"Сумма равна: {Math.Round(sum, 4)}");

            double substraction = num1.DSubstact(num2);
            Console.WriteLine($"Разность равна: {Math.Round(substraction, 4)}");

            double mul = num1.DMultiply(num2);
            Console.WriteLine($"Произведение равно: {Math.Round(mul, 4)}");

            Console.WriteLine(num1.DCompare(num2));
        }
    }
}