using System;
using System.Text;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào năm dương lịch: ");
            int namDuongLich = int.Parse(Console.ReadLine());
            string[] can = new string[] { "Canh", "Tân", "Nhâm", "Qúy", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chi = new string[] { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            int giaTriCan = namDuongLich % 10;
            int giaTriChi = namDuongLich % 12;
            Console.WriteLine("Năm âm lịch là: " + can[giaTriCan] + " " + chi[giaTriChi]);
        }
    }
}
