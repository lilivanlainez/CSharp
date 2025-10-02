namespace predicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3,4 , 5, 6, 7, 8, 9, 10 });
            //Declaramos delegado predicado
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);
            
            List<int> numPares=list.FindAll(elDelegadoPred);

            foreach(int i in numPares)
            {
                Console.WriteLine(i);
            }
        }
        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
    }
}
