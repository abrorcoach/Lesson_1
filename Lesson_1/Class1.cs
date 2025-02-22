namespace Lesson_1
{
    public class Class1
    {
        public int ArifMath(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        public int Perimeter(int a)
        {
            return 4 * a;
        }

        public void Kvad(int a, int b)
        {
            Console.WriteLine($" S: {a * b}");
            Console.WriteLine($" P: {2 * (a + b)}");
        }

        public void Kub(int a)
        {
            Console.WriteLine($" V: {a * a * a}");
            Console.WriteLine($" S: {6 * a * a}");
        }

        public void Pow(int number)
        {
            Console.WriteLine($"{Math.Pow(number, 2)}");
        }

        public double Exchange(double number)
        {
            return number / 11200;
        }

        public int FirstThirdNumber(int number)
        {
            int first = number / 1000 % 100;
            int third = number / 10 % 10;
            return first * third;
        }

        public int FindThird(int number)
        {
            return number / 10 % 10;
        }

        public void PowSeven(int number)
        {
            Console.WriteLine(Math.Pow(number, 7));
        }

        public double SantimetersToMetr(double number)
        {
            return number * 0.01;
        }

        public void ex(string num)
        {
            string res = num.Substring(0, 1);
            string res2 = num.Substring(1, 2);
            Console.WriteLine(res2 + res);
        }

        public int ReverseNumber(int num)
        {
            int digitFirst = num % 10;
            int digitSecond = (num / 10) % 10;
            int digitThird = num / 100;

            int res = digitFirst * 100 + digitSecond * 10 + digitThird;
            return res;
        }

        public int FourthDigit(int num)
        {
            int numFirst = num / 1000;
            int numSecond = (num / 100) % 10;
            int numThird = (num / 10) % 10;
            int numFourth = num % 10;

            int res = numFirst * numSecond * numThird * numFourth;
            return res;
        }

        public int AddNum(int num)
        {
            int digitFirst = num % 10;
            int digitSecond = (num / 10) % 10;
            int digitThird = num / 100;

            int res = digitFirst + digitSecond + digitThird;
            return res;
        }

        public double ByteToKilobyte(double num)
        {
            return num * 0.001;
        }

        public void SecundToHoursAndMinutes(int num)
        {
            double hours = num / 3600;
            double minutes = (num % 3600) / 60;
            Console.WriteLine($"hours: {hours}, minutes: {minutes}");

        }

        public void ChangeNumber(int a, int b)
        {
            Console.WriteLine($"A:{b}, B: {a}");
        }

        public void HigherThen999(int num)
        {
            if (num > 999 || true)
            {
                int numSecond = (num / 100) % 10;
                Console.WriteLine(numSecond);
            }


        }

        public int ReverseNumberLastOne(int num)
        {
            int digitFirst = num / 100;
            int digitSecond = (num / 10) % 10;
            int digitThird = num % 10;

            int res = digitThird * 100 + digitFirst * 10 + digitSecond;
            return res;
        }

        public void HoursToMinut(int numSutka, int numHours)
        {
            int res1 = numSutka * 1440;
            int res2 = numHours * 60;

            int answ = res1 + res2;
            Console.WriteLine($"Minut: {answ}");
        }

        public double FindKm(double num)
        {
            double res = num / 7;
            return res;

        }

        public void WeakToHours(int numWeak, int numDay)
        {
            int res1 = numWeak * 168;
            int res2 = numDay * 24;

            int answ = res1 + res2;
            Console.WriteLine($"Hours: {answ}");
        }

        public void GbToKb(double numGb, double numKb)
        {
            double fileSizeKB = numGb * 1024 * 1024;
            double timeInSeconds = fileSizeKB / numKb;

            Console.WriteLine($"{numGb} GB ma'lumotni uzatish uchun {timeInSeconds} sekund kerak.");
        }

        public double SecundToHours(double numSec)
        {
            numSec = numSec / 3600;
            return numSec;
        }

        public int FindMultipleFromThird(int num)

        {
            int digitFirst = num / 100;
            int digitSecond = (num / 10) % 10;
            int digitThird = num % 10;

            int res = digitThird * digitFirst * digitSecond;
            return res;
        }

        public void FindLenght(double numR)
        {
            numR = numR * 2 * 3.14;
            Console.WriteLine($"Lenght: {numR} ");

        }

        public void FindByteFromKbyte(double num)
        {
            num = num * 1024;
            double res = num / 2;
            Console.WriteLine($"we use {res} byte");
        }

        public int OnXonNumTurnLeft(int num)
        {
            int digitFirst = num / 100;
            int digitSecond = (num / 10) % 10;
            int digitThird = num % 10;

            int res = digitSecond * 100 + digitFirst * 10 + digitThird;
            return res;
        }

        public bool IfHaveThreeTrue(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '3')
                {
                    return true;

                }

            }
            return false;
        }

        public void FindPositiveNegativeNum(int[] num)
        {
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    positive++;
                }
                else if (num[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }

            }

            Console.WriteLine($"Postive: {positive}");
            Console.WriteLine($"Negative: {negative}");
            Console.WriteLine($"Zero: {zero}");
        }

        public void FindMonth(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Januare");
                    break;
                case 2:
                    Console.WriteLine("Februare");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Ilun");
                    break;
                case 7:
                    Console.WriteLine("Ilul");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("Sentabr");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("Noverber");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("we dont have thi kind of moth");
                    break;

            }
        }

        public void Grades(int num)
        {
            if (num >= 0 && num <= 54)
            {
                Console.WriteLine("You get 2 score");
            }
            else if (num >= 55 && num <= 70)
            {
                Console.WriteLine("You get 3 score");
            }
            else if (num >= 71 && num <= 84)
            {
                Console.WriteLine("You get 4 score");
            }
            else if (num >= 71 && num <= 100)
            {
                Console.WriteLine("You get 5 score");
            }
            else
            {
                Console.WriteLine("it too high");
            }

        }

        public void FindEqualABC(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("=");
            }
            else if (a == b)
            {
                Console.WriteLine(c);
            }
            else if (a == c)
            {
                Console.WriteLine(b);
            }
            else if (b == c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} {b} {c}");
            }

        }

        public void AddTwoNum(int a, int b)
        {
            int res = a + b;

            if (res >= 10 && res <= 19)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine(res);
            }
        }

        public void FindThreeInDigit(int num)
        {

            int numSecond = (num / 100) % 10;
            if (numSecond == 3)
            {
                Console.WriteLine("There is 3 ");
            }
            else
            {
                Console.WriteLine("there isnt  3 ");
            }



        }
        public void AddOne(int a)
        {
            if (a > 0)
            {
                Console.WriteLine(a + 1);
            }
            else if (a < 0)
            {
                Console.WriteLine(Math.Abs(a) + 2);
            }
            else
            {
                Console.WriteLine(a / 100);
            }
        }

    }
}
