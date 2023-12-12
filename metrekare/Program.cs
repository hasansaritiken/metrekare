using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Evinizdeki oda sayısını giriniz: ");
            ushort odaSayisi = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Evinizin  alanını giriniz (metrekare olarak): ");
            double alan = Convert.ToDouble(Console.ReadLine());


            Ev ev1 = new Ev(odaSayisi, alan);
            ev1.EvBilgisi();

            Console.ReadLine();
        }
    }
}
class Ev
{
    private ushort odaSayisi;
    private double alan;


    public Ev(ushort odaSayisi, double alan)
    {
        this.odaSayisi = odaSayisi;
        this.alan = alan;
    }


    public void EvBilgisi()
    {

        Console.WriteLine("Evinizdeki oda sayısı = " +odaSayisi);
        Console.WriteLine("Evinizin alan = "+ alan);
    }
}