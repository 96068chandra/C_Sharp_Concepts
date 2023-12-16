using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class ElectricityBillCalculation
    {
        public abstract double GetRate();
        public void CalculateElectricBill(int units)
        {
            double rate=GetRate();
            Console.WriteLine($"Total Electricity bill is {rate * units} rupees");


        }
    }

    public class DomesticPlan : ElectricityBillCalculation
    {
        public override double GetRate()
        {
            return 5;
        }
    }
    public class CommercialPlan : ElectricityBillCalculation
    {
        public override double GetRate()
        {
            return 8;
        }
    }
    public class Plan
    {
        static void Main(string[] args)
        {
            DomesticPlan plan = new DomesticPlan();
            plan.CalculateElectricBill(5);
            CommercialPlan comm=new CommercialPlan();
            comm.CalculateElectricBill(8);
            Console.ReadKey();

        }
    }
}
