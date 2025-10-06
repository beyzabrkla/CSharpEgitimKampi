using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabasePeoject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net   C# programlama dilinde sql yapılarını kullanmamızı sağlayan bir çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber; 

            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
           
            tableNumber = Console.ReadLine();
            
            Console.WriteLine("-------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=BEYZA\\BEYZA_DEV; Initial Catalog=EgitimKampiDb; integrated security=true;");
            //sınıf        nesne         
            connection.Open(); //bağlantı açıldı
           
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //yazılan sql sorgusunun düzgün çalışması için bağladığımız db nin adresini çağırdık.
            SqlDataAdapter adapter = new SqlDataAdapter(command); //sql dataadapter= c# kodlarıyla sql sunucusu arasında köprü görevi görür
            DataTable dataTable = new DataTable(); //DataTable verileri ram belleğe almasını sağlayacak
            adapter.Fill(dataTable); 

            connection.Close(); //bağlantı kapatıldı.

            foreach (DataRow row in dataTable.Rows) 
            {
                foreach (var item in row.ItemArray) //satırdan gelen dizinin içeriğini okumak 
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
