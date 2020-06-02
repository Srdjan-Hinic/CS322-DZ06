using System;

namespace DZ06
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo v1 = new Kamion { max_tezina = 100 };
            Vozilo v2 = new Avion { id = 5, tezina = 300 };
            Vozilo v3 = new Automobil();

            Console.WriteLine("Created Objects:");
            Console.WriteLine(v1.GetType());
            Console.WriteLine(v2.GetType());
            Console.WriteLine(v3.GetType());
            Console.WriteLine("\nObject.toString() invoked:");
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }
    }

    public abstract class Vozilo
    {

        public int id { get; set; }
        public int tezina { get; set; }
        int top_speed { get; set; }
    }



    public class Automobil : Vozilo
    {
        public Automobil() { }

        public Automobil(int max_putnici)
        {
            this.max_putnici = max_putnici;
        }

        public int max_putnici { get; set; }
        public override string ToString() => "Automobil - Max Putnici: " + max_putnici;
    }


    public class Kamion : Vozilo
    {
        public Kamion()
        {
        }

        public Kamion(int max_tezina)
        {
            this.max_tezina = max_tezina;
        }

        public int max_tezina { get; set; }
        public override string ToString() => "Kamion - Max Tezina: " + max_tezina;
    }

    public class Avion : Vozilo
    {
        public Avion()
        {
        }

        public Avion(int raspon_krila, int max_visina)
        {
            this.raspon_krila = raspon_krila;
            this.max_visina = max_visina;
        }

        int raspon_krila { get; set; }
        int max_visina { get; set; }
        public override string ToString() => "Avion - Max visina: " + max_visina + ", Raspon krila: " + raspon_krila;
    }
}


