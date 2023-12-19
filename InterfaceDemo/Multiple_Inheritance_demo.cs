using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
    //Implementation of interface methods using inheritance 
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine(FaxContent);
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine(PrintDuplexContent);
        }
    }
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
    public class Multiple_Inheritance_demo
    {
        static void Main(string[] args)
        {
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Scan("Scan Services by HPLaserJetPrinter");
            hPLaserJetPrinter.Print("Print Services by HPLaserJetPrinter");
            hPLaserJetPrinter.Fax("Fax Services by HPLaserJetPrinter");
            hPLaserJetPrinter.PrintDuplex("Print Duplex Services by HPLaserJetPrinter");
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Scan("Scan Services by LiquidInkjetPrinter");
            liquidInkjetPrinter.Print("Print Services by LiquidInkjetPrinter");
            //Fax and PrintDuplex are not available in LiquidInkjetPrinter
            //liquidInkjetPrinter.Fax("Fax Services");
            //liquidInkjetPrinter.PrintDuplex("Print Duplex Services");
            Console.Read();
        }
    }
}
