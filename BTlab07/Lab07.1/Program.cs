using DongVat.AnCo;
using DongVat.AnThit;
using System;



namespace DongVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bo bo = new Bo(1, "Bo", 500);
            Trau trau = new Trau(2, "Trau", 600);
            De de = new De(3, "De", 60);

            CaSau caSau = new CaSau(4, "Ca Sau", 300);
            Ho ho = new Ho(5, "Ho", 200);
            SuTu suTu = new SuTu(6, "Su Tu", 220);

            // sử dụng phương thức để hiển thị thông tin
            Console.WriteLine(bo.GetInfo());
            Console.WriteLine(trau.GetInfo());
            Console.WriteLine(de.GetInfo());

            Console.WriteLine(caSau.GetInfo());
            Console.WriteLine(ho.GetInfo());
            Console.WriteLine(suTu.GetInfo());
        }
    }
}