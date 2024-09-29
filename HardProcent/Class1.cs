namespace HardProcent
{
    public class Checker
    {
       public static double HardProcentFunction(float startCapital, double procentstavka, int timeInYears, int countIncome)
        {
            int counter = 0;

            if (startCapital >= 0)
            {
                counter ++;
                if (procentstavka >= 0)
                {
                    counter += 1;
                    if (timeInYears >= 0)
                    {
                        counter += 1;
                        if (countIncome >= 0)
                        {
                            counter += 1;
                            double totalMoney = startCapital * Math.Pow((1 + (procentstavka / countIncome)), (countIncome * timeInYears));
                            return counter;
                        }

                    }
                }
            }
            return counter;
        }
    }
}
