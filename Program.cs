using System;

namespace TryCatchFinally_Hvatanje_Gresaka

{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] karakteri = { 'a', 'b', 'c', };
            try
            {
                Console.WriteLine(karakteri[1]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Doslo je do greske (ovo je poruka koju ja ostavljam)");
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("ovo ce raditi sta god da se desi radilo ili ne ovo gore"); 
            }
        }
    }
} 