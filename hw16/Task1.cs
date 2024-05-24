
namespace hw16
{
    class Task1
    {
        public List<int> PairNumInArray(int[] ints)
        {
            var result = new List<int>();
            foreach (var i in ints) 
            {
                if(i % 2 == 0) result.Add(i);
            }
            return result;
        }
        public List<int> UnPairNumInArray(int[] ints)
        {
            var result = new List<int>();
            foreach (var i in ints)
            {
                if (i % 2 != 0) result.Add(i);
            }
            return result;
        }
        public List<int> PrimeNumInArray(int[] ints)
        {
            var result = new List<int>();
            foreach(var i in ints)
            {
                if (IsPrime(i)) result.Add(i);
            }
            return result;
        }
        public List<int> FibonacciNumInArray(int[] ints)
        {
            var result = new List<int>();
            foreach (var i in ints)
            {
                if (Math.Sqrt(5 * Math.Pow(i, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(i, 2) + 4) % 1 == 0 && i > 0)
                    result.Add(i);
            }
            return result;
        }
        public bool IsPrime(int x)
        {
            bool result = true;
            if (x > 1)
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
