using System;

namespace tpmodul6_103082400042
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.F: Judul sesuai format [cite: 207]
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Andra");

            // 5.C: Menguji exception overflow dengan for loop 
            // Kita tambah 10 juta sebanyak 215 kali biar ngelewatin batas int (2,1 Miliar)
            for (int i = 0; i < 215; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            video.PrintVideoDetails();
        }
    }
}