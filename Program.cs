namespace chytKrtka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casovyLimit = 30;
            Hra hra = new Hra(casovyLimit);
            hra.SpustSe();
        }
    }
}
