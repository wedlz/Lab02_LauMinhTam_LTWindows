using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_LauMinhTam_LTWindows
{
    internal class BTtailop1
    {
        static int[] NhapMang(int[] a, int n)
        {
            string input = Console.ReadLine();
            string[] nums;
            nums = input.Split(' ');
            for (int i = 0; i < n; i++)
            {
                //a[i] = Convert.ToInt32(nums[i]);
                a[i] = int.Parse(nums[i]);
            }
            return a;
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "]: {0}", a[i]);
            }
        }

        static int[][] NhapMang2Chieu(int[][] a, int n, int m)
        {
            string[][] nums = new string[n][];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                nums[i] = input.Split(' ');
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = Convert.ToInt32(nums[i][j]);
                }
            }
            return a;
        }

        static void XuatMang2Chieu(int[][] a, int n, int m)
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


        static void Mang2Chieu()
        {
            int n, m;
            int[][] a;
            Console.Write("Moi ban nhap so dong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Moi ban nhap so dong: ");
            m = Convert.ToInt32(Console.ReadLine());
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            NhapMang2Chieu(a, n, m);
            XuatMang2Chieu(a, n, m);
        }

        static bool ChuoiDoiXung()
        {
            string s;
            s = Console.ReadLine();
            char[] mangChuoi = s.ToCharArray();
            for (int i = 0; i < mangChuoi.Length; i++)
            {
                if (mangChuoi[i] != mangChuoi[mangChuoi.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static bool snt(int a)
        {
            if (a < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] a;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            XuatMang(a, n);
            Console.Write("Các phần tử lẻ ở vị trí chẵn là: ");
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0 && a[i] % 2 != 0) //4543543543543543543543543
                {
                    Console.Write("{0} ", a[i]); // các phần tử lẻ ở vị trí chẵn
                }
                if (max < a[i]) // tìm max
                {
                    max = a[i];
                }
                if (min > a[i]) // tìm min
                {
                    min = a[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++) // liệt kê số nguyên tố
            {
                if (snt(a[i]))
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++) // tìm phần tử âm
            {
                if (a[i] < 0)
                {
                    Console.Write("{0} ", a[i]);
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max trong day: {0}", max);
            Console.WriteLine("Min trong day: {0}", min);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Tong cac phan tu trong day = {0}", sum);
        }
    }
}

