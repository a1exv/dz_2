using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    partial class Auto
    {
        private string name;
        private int maxSpeed;
        private double weight;
        private char type;
        private string serialNo;
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed { get; set; }
        public double Weight { get; set; }
        public char Type { get; set; }
        public string SerialNo { get; set; }
        public void GetSerialNumber(ref string snum)
        {
            snum = serialNo;
        }
        public static int count;
        public static double totalWeight;
        public Auto()
        {
            count++;
            weight = 1000;
            name = "default";
            maxSpeed = 300;
            type = 'A';
            serialNo = "default";
            totalWeight += weight;
        }
        public Auto(string name, int maxSpeed, double weight, char type, string serialNo)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.weight = weight;
            this.type = type;
            this.serialNo = serialNo;
            count++;
            totalWeight += weight;
        }
         static Auto()
        {
            count = 0;
            totalWeight = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] arAuto = new Auto[5];

            for (var i = 0; i < arAuto.Length; i++)
            {
                arAuto[i] = new Auto();
                Console.WriteLine(arAuto[i].ToString());
            }
            Console.WriteLine(Auto.totalWeight);
        }
    }
}
