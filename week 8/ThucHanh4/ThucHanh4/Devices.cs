using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh4
{
    public interface I3G
    {
        void Using3G();
    }
    public interface IWifi
    {
        void UsingWifi();
    }
    public interface IGSM
    {
        void UsingGSM();
    }
    public interface IGPRS
    {
        void UsingGPRS();
    }
    public abstract class Devices : I3G, IWifi, IGSM, IGPRS
    {
        private string Name;
        private int Year;
        private string Color;
        private int Seri;
        public Devices (string name, int year, string color, int seri)
        {
            Name = name;
            Year = year;
            Color = color;
            Seri = seri;
        }
        public void Using3G()
        {
            Console.WriteLine("Su dung 3G");
        }

        public void UsingWifi()
        {
            Console.WriteLine("Su dung wifi");
        }
        public virtual void UsingGSM()
        {
            Console.WriteLine("Su dung GSM");
        }
        public void UsingGPRS()
        {
            Console.WriteLine("Su dung GPRS");
        }
        public virtual void HoatDong()
        {
            Console.WriteLine("Hoat dong cua thiet bi dung duoc 3G, Wifi hay GPRS, GSM: ");
        }
        public virtual void Information()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("So Seri: " + Seri);
        }
    }
}
