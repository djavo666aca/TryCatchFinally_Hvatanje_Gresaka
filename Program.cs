namespace Error_handling__Try_Catch_Finally__Rukovanje_greskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi neki broj");
            string ubacibr1 = Console.ReadLine();

            try 
            {
                int br1 = int.Parse(ubacibr1);
                Console.WriteLine($"Pomnozi br: {br1 * br1}");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: ubaci validan br");
            }
            catch (OverflowException) 
            {
            Console.WriteLine("OverflowException: broj je premali ili preveliki za int");
            }
            catch(Exception) 
            {
            Console.WriteLine("Doslo je do nepoznate gdeske: Molim te kontaktiraj me preko gmail.com");
            }
            finally 
            {
                Console.WriteLine("finally se izvrsava svakako bilo gresaka ili ne");
            }
            Console.ReadKey();
        }
    }
}