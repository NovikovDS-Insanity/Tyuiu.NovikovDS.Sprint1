using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovDS.Sprint1.Task1.V5.Lib
{
    public class DataService : ISprint1Task1V10
    {
       public double Calculate(double x, double y)
        {
            return (x + y) / (1 + x);
        }
    }

}
