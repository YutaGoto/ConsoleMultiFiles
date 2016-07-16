namespace Prime
{
    internal class DecisionPrime
    {
        public bool IsPrime(int i)
        {
            if (i < 2)
                return false;

            int x = 2;
            while (i > x)
            {
                if (i % x == 0)
                    return false;
                x++;
            }
            return true;
        }
    }
}