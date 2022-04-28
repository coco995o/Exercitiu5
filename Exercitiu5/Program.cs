using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
    public class FitByte 
    {
        int age;
        int restingHeartRate;
        public FitByte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
        public double TargetHeartRate(double percentageOfMaximum) 
        {
            var maxHeartRate = 206.3 - (0.711 * age);
            var targetHeartRate = (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
            return targetHeartRate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var assistent = new FitByte(30,60);
            double percentage = 0.5;

            while (percentage<1.0) 
            { 
                double target=assistent.TargetHeartRate(percentage);
                Console.WriteLine("Target" + (percentage*100)+"% of maximum: "+target);
                percentage = percentage + 0.1;
            }
        }
    }
}
