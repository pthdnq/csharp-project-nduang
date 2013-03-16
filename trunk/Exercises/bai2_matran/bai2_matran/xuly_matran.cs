using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai2_matran
{
    class xuly_matran
    {


        private int So_Hang;
        private int So_Cot;
        private int[,] MT;

        public void matran(int sh, int sc)
        {
            this.So_Hang = sh;
            this.So_Cot = sc;
            this.MT = new int[sh, sc];
        }

        public void NhapMT()
        {
            Console.Write("Nhap so hang cua ma tran: ");
            this.So_Hang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran: ");
            this.So_Cot = int.Parse(Console.ReadLine());
            matran(So_Hang, So_Cot);
            try
            {
                for (int i = 0; i < this.So_Hang; i++)
                    for (int j = 0; j < this.So_Cot; j++)
                    {
                        Console.Write("Nhap phan tu thu A[" + i + "," + j + "]: ");
                        this.MT[i, j] = int.Parse(Console.ReadLine());
                    }
            }
            catch (Exception)
            {
                Console.Write("khong nhap duoc");
                Console.ReadLine();

            }
            
        }

        public int demsoduong( out int dem1)
        {
            dem1 = 0;
            try
            {
                for (int i = 0; i < this.So_Hang; i++)
                    for (int j = 0; j < this.So_Cot; j++)
                    {
                        if (MT[i, j] > 0)
                        {
                            dem1++;
                        }
                    }
                return 0;
            }
            catch (Exception)
            {
                dem1 = 0;
                return -1;
            }
        }
    }
}
