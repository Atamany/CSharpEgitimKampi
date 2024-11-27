using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_Ders9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# Veri Tabalı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
			Console.WriteLine();

            string tableNumber;

			Console.WriteLine("---------------------------");
            Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
			Console.WriteLine("---------------------------");

            SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Table_2", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

			Console.Read();
        }
    }
}
