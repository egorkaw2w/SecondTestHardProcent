namespace HardProcentFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static double HardProcent(float startCapital, double procentstavka, int timeInYears, int countIncome)
            {


                if (startCapital >= 0)
                {
                    if (procentstavka >= 0)
                    {
                        if (timeInYears >= 0)
                        {
                            if (countIncome >= 0)
                            {
                                double totalMoney = startCapital * Math.Pow((1 + (procentstavka / countIncome)), (countIncome * timeInYears));
                                return totalMoney;
                            }

                        }
                    }
                }
                return 0;
            };

        }
    }

}
