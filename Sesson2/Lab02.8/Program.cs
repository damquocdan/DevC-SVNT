using System;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Nhập số tiền gửi");
        double soTienGui = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập lai suat ngan hang ban(%): ");
        double laiSuatNam=double.Parse(Console.ReadLine())/100;
        Console.WriteLine("Nhap so thang gui");
        int soThangGui = int.Parse(Console.ReadLine());

        double laiSuatThang = laiSuatNam / 12;
        double soDu = soTienGui;
        Console.WriteLine("Tháng\t Số Dư \t Lãi");
        for (int thang = 1; thang <= soThangGui; thang++)
        {
            double lai = soDu * laiSuatThang;
            soDu += lai;
            Console.WriteLine($"{thang}\t{soDu:N2} \t{lai:N2}");
        }
        double tongLai = soDu - soTienGui;
        Console.WriteLine($"Tổng lãi sau{soThangGui} tháng:{tongLai:N2}");
    }
}