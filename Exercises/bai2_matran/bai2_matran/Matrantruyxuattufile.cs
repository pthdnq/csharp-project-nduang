using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace ConsoleApplication3
{
    class Matrantruyxuattufile
    {
        public bool ReadFile(String FilePath,out int M, out int N, out int[,] Mat)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            M = Convert.ToInt32(sr.ReadLine());
            N = Convert.ToInt32(sr.ReadLine());
            Mat = new int[M, N];

            string s = "";
            string[] S;

            for (int i = 0; i < M; i++)
            {
                s = sr.ReadLine();
                S = s.Split(' ');

                for (int j = 0; j < N; j++)
                {
                    Mat[i, j] = Convert.ToInt32(S[j]);
                    //if (i == j && Mat[i, i] != 35000)
                    //{
                    //    //MessageBox.Show("Matrix is not valid");
                    //    N = 0;
                    //    sr.Close();
                    //    fs.Close();
                    //    return false;
                    //}
                }
            }
            sr.Close();
            fs.Close();

            return true;
        }
    }
}
