using System;
using System.Text;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Nhập vào năm dương lịch: ");
            //int namDuongLich = int.Parse(Console.ReadLine());
            //string[] can = new string[] { "Canh", "Tân", "Nhâm", "Qúy", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            //string[] chi = new string[] { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            //int giaTriCan = namDuongLich % 10;
            //int giaTriChi = namDuongLich % 12;
            //Console.WriteLine("Năm âm lịch là: " + can[giaTriCan] + " " + chi[giaTriChi]);

            //Bài 2:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            double[] daySo = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ " + i + " của mảng a[" + i + "]: ");
                daySo[i] = double.Parse(Console.ReadLine());
            }

            ////Tìm phần tử max, min và in ra vị trí:
            //double max = daySo[0], vitriMax = 0;
            //double min = daySo[0], vitriMin = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (daySo[i]>= max)
            //    {
            //        max = daySo[i];
            //        vitriMax = i+1;
            //    }
            //    if (daySo[i]<min)
            //    {
            //        min = daySo[i];
            //        vitriMin = i+1;
            //    }
            //}

            ////In ra màn hình giá trị max, min và vị trí
            //Console.WriteLine("Giá trị max là: " + max + ", ở vị trí thứ: " + vitriMax);
            //Console.WriteLine("Giá trị min là: " + min + ", ở vị trí thứ: " + vitriMin);

            //Bài 3: Sắp xếp dãy số theo thứ tự tăng dần, giảm dần:
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (daySo[i]>=daySo[j])
                    {
                        //Đổi chỗ 2 phần tử
                        double giaTriTrungGian = daySo[i];
                        daySo[i] = daySo[j];
                        daySo[j] = giaTriTrungGian;
                    }
                }
            }

            //In kết quả ra màn hình:
            Console.Write("Dãy số đã được sắp xếp theo thứ tự tăng dần là: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(daySo[i]+" ");
                
            }
            Console.WriteLine();
            Console.Write("Dãy số được sắp xếp theo thứ tự giảm dần là: ");
            for (int j = n-1; j >= 0; j--)
            {
                Console.Write(daySo[j] + " ");
            }
            


        }
    }
}
