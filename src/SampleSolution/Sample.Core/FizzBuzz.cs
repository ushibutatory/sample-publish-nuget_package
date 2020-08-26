namespace Sample.Core
{
    public class FizzBuzz
    {
        public bool IsFizz(int n) => n % 3 == 0;

        public bool IsBuzz(int n) => n % 5 == 0;

        public bool IsFizzBuzz(int n) => IsFizz(n) && IsBuzz(n);

        public string Convert(int n)
        {
            if (n <= 0)
                return n.ToString();
            if (IsFizzBuzz(n))
                return "FizzBuzz";
            if (IsFizz(n))
                return "Fizz";
            if (IsBuzz(n))
                return "Buzz";

            return n.ToString();
        }
    }
}
