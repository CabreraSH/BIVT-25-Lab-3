using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
// PROBLEM ONE---------------------------------------------------------------------------------------------------------------------------------------------START
            
            double answer = 0;
            for (int i = 1; i <=n; i = i + 1)
                
                {
                    double height;
                    double.TryParse(Console.ReadLine(), out height);
                    answer += height;
                }
            
            averageHeight = answer / n;

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
// PROBLEM TWO---------------------------------------------------------------------------------------------------------------------------------------------START

                bestResult = 1000000;
            
                for (int i = 1; i <= n; i++)
                {
                    double h;
                    double.TryParse(Console.ReadLine(), out h);
                    
                    if (h < bestResult)
                    {
                        bestResult = h;
                    }
                }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
// PROBLEM THREE---------------------------------------------------------------------------------------------------------------------------------------------START

            for (int i = 0; i < n; i=i+1)
                {
                    double time = double.Parse(Console.ReadLine());
                
                    if (time <= limit)
                        {
                            count=count+1;
                        }
                }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
// PROBLEM FOUR---------------------------------------------------------------------------------------------------------------------------------------------START

            for (int i = 1; i <= maxAmount; i=i+1)
                {
                    hours += i;
                }

            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
// PROBLEM FIVE---------------------------------------------------------------------------------------------------------------------------------------------START

            if (type == 1)
                {
                    area = r * r;
                }
            
                else if (type == 2)
                    {
                        area = Math.PI * (r * r);
                    }
            
                if (type == 3)
                    {
                        area = ((r * r) * Math.Sqrt(3)) / 4;
                    }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return area;
        }
    }

}
