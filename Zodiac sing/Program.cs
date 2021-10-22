using System;

namespace Zodiac_sing
{
    class Program
    {
        static void Main(string[] args)
        {

            Biranje();
            Console.WriteLine("----------------------------------------");
            Datum();
            Console.WriteLine("-------------------------------------");
            Zapadnjacki();
            Console.WriteLine("proba");

            







            Console.ReadKey();
        }
        static void Biranje() //Method omogucava koji cete horoskop uneti i proverava da li se poklopa sa bazom horoskopa
        {
            string[,] vrste = new string[2, 5] { { "1", "2", "3", "4", "5" }, { "zapadnjacki", "kineski", "majanski", "indijanski", "romski" } };

            Console.WriteLine("Unesti ime horoskopa koji zelite: ");
            string unosProvera = Console.ReadLine();

            for (int row = 0; row < vrste.Length; row++)     
            {

                if (unosProvera == vrste[1, row])
                {
                    Console.WriteLine("Izabrali ste "+vrste[1,row]+" horoskop.");
                    break;
                }
                else
                    Console.WriteLine("Horoskop koji ste izabrali nije u nasoj bazi podataka, molimo vas pokusajte ponovo");
                

            }
        }
        static void Datum() //Metod koji konvertuje uneti string u datum i proverava validnos datuma(primer Exception Handling-a)
        {
            
            DateTime date = new DateTime();
            DateTime today = DateTime.Today;
            Console.WriteLine("Unesite datum rodjenja: ");
            string bDay = Console.ReadLine();
            date = Convert.ToDateTime(bDay);


            try
            {
                
                Console.WriteLine(date.ToString("dd/MM/yyyy") + " je datum koji ste uneli.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();

            }
            finally
            {
                int buducnost = Convert.ToInt32(today.ToString("yyyy"));
                int sadasnjost = Convert.ToInt32(date.ToString("yyyy"));

                if (sadasnjost > buducnost)
                {
                    Console.WriteLine("Datum koji ste uneli je u buducnosti.");

                }
                else
                    Console.WriteLine("Uneli ste validan datum");
            }
        }
        static void Zapadnjacki() //metod koji proveravanja poklapanje datuma u bazi i vraca horoskopski znak
        {
            
            string[,] zapadnjacki = new string[12, 4] {
                {"1", "01/21", "02/19", "Vodolija" },{"2", "02/20", "03/20", "Ribe"},{"3", "03/21", "04/20", "Ovan"},{"4", "04/21", "05/21", "Bik"},
                {"5", "05/22", "06/21", "Blizanci"}, {"6", "06/22", "07/22", "Rak"}, {"7", "07/23", "08/22", "Lav"}, {"8", "08/23", "09/22", "Devica"},
                {"9", "09/23", "10/23", "Vaga"}, {"10", "10/24", "11/22", "Skorpija"}, {"11", "11/23", "12/23", "Strelac"},{"12", "12/22", "01/20", "Jarac"} };

            DateTime datumOD = new DateTime();
            DateTime datumDO = new DateTime();
            DateTime unosMeseca = new DateTime();
            


            Console.WriteLine("Unesite datum rodjenja: ");
            string unosRodjenje = Console.ReadLine();
            unosMeseca = Convert.ToDateTime(unosRodjenje);

            for (int i = 0; i < zapadnjacki.GetLength(0); i++)
            {
                datumOD = Convert.ToDateTime(zapadnjacki[i, 1]);
                datumDO = Convert.ToDateTime(zapadnjacki[i, 2]);

                if ((unosMeseca > datumOD) && (unosMeseca < datumDO))
                {
                    Console.WriteLine("Vas znak je: " + zapadnjacki[i, 3]);
                    break;
                }
            }
        }
    }
}
