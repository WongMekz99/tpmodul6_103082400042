using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace tpmodul6_103082400042
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // 3.C: Validasi Prekondisi (Panjang judul max 100 dan tidak null)
            Debug.Assert(title != null && title.Length <= 100, "Judul video tidak boleh null dan maksimal 100 karakter."); 
        
            this.title = title;

            // 3.C: Generate id random 5 digit
            Random random = new Random();
            this.id = random.Next(10000, 99999); 
            this.playCount = 0; 
        }

        public void IncreasePlayCount(int count)
        {
            // 5.A.ii: Prekondisi input max 10.000.000
            Debug.Assert(count <= 10000000, "Input penambahan play count maksimal 10.000.000."); 

            // 5.B.i: Exception handling dengan checked untuk overflow
            try
            {
                checked
                {
                    this.playCount += count; 
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Penambahan play count melebihi batas integer (Overflow)!"); 
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}"); 
            Console.WriteLine($"Title: {this.title}"); 
            Console.WriteLine($"Play Count: {this.playCount}"); 
    }
    }
}
