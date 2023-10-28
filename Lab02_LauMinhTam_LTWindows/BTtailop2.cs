using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_LauMinhTam_LTWindows
{
    internal class BTtailop2
    {
        static void nhapMang(int[][] a, int n, int m)
        {
            string input;
            string[][] nums = new string[n][];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                nums[i] = input.Split(' ');
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = Convert.ToInt32(nums[i][j]);
                }
            }
        }

        static void xuatMang(int[][] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", a[i][j]);
                }
                Console.WriteLine();
            }
        }

        static int tongCacPhanTuDuong(int[][] a, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].Where(t => t > 0).Sum();
            }
            return sum;
        }

        static int tongCacPhanTuTrenDuongCheoChinh(int[][] a, int n, int m)
        {
            int sum = 0;
            if (n != m)
            {
                return 0;
            }
            for (int i = 0; i < n; i++)
            {
                sum += a[i][i];
            }
            return sum;
        }

        static int tongCacPhanTuTrongTamGiacTren(int[][] a, int n, int m)
        {
            int sum = 0;
            if (n != m)
            {
                return 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < m; j++)
                {
                    sum += a[i][j];
                }
            }
            return sum;
        }

        static bool soChan(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static int tongCacPhanTuChan(int[][] a, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].Where(t => soChan(t)).Sum();
            }
            return sum;
        }

        static int tongCacPhanTuDongThuI(int[][] a, int n, int m, int i)
        {
            int sum = 0;
            if (i > n - 1)
            {
                return 0;
            }
            sum += a[i].Sum();
            return sum;
        }

        static void Main(string[] args)
        {
            int[][] a;
            Console.Write("Nhap so hang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = Convert.ToInt32(Console.ReadLine());
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            nhapMang(a, n, m);
            xuatMang(a, n, m);
            Console.WriteLine("Tong cac phan tu duong: {0}", tongCacPhanTuDuong(a, n, m));
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh: {0}", tongCacPhanTuTrenDuongCheoChinh(a, n, m));
            Console.WriteLine("Tong cac phan tu trong tam giac tren: {0}", tongCacPhanTuTrongTamGiacTren(a, n, m));
            Console.WriteLine("Tong cac phan tu chan trong ma tran: {0}", tongCacPhanTuChan(a, n, m));
            Console.WriteLine("Tong cac phan tu o dong thu i: {0}", tongCacPhanTuDongThuI(a, n, m, 1));

        }
    }
}
