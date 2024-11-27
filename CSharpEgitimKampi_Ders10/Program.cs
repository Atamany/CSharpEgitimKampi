using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_Ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------");
			#region Kategori Ekleme İşlemi
			//Console.Write("Eklemek İstediğiniz Kategori Adı: ");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into Table_1 (CategoryName) values (@p1)",connection);
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.Write("Kategori başarıyla eklendi!");
			#endregion

			#region Ürün Ekleme İşlemi

			//string productName;
			//decimal productPrice;
			//bool productStatus;

			//Console.Write("Ürün Adı: ");
			//productName = Console.ReadLine();
			//Console.Write("Ürün Fiyatı: ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into Table_2 (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.Write("Ürün eklemesi başarılı!");

			#endregion

			#region Ürün Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * from Table_2", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//	Console.WriteLine();
			//}

			//connection.Close();
			#endregion

			#region Ürün Silme İşlemi

			//Console.Write("Silinecek Ürün ID: ");
			//int productID = int.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("Delete from Table_2 Where ProductID=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productID);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Silme işlemi başarılı!");
			#endregion

			#region Ürün Güncelleme İşlemi

			Console.Write("Güncellenecek Ürün ID: ");
			int productID = int.Parse(Console.ReadLine());

			Console.Write("Güncellenecek Ürün Adı: ");
			string productName = Console.ReadLine();

			Console.Write("Güncellenecek Ürün Fiyatı: ");
			decimal productPrice = decimal.Parse(Console.ReadLine());

			SqlConnection connection = new SqlConnection("Data Source=YIGITATAMANPC;initial Catalog=EgitimKampiDB;integrated Security=true");
			connection.Open();

			SqlCommand command = new SqlCommand("Update Table_2 Set productName=@ProductName,productPrice=@ProductPrice where productID=@ProductID", connection);
			command.Parameters.AddWithValue("@ProductID", productID);
			command.Parameters.AddWithValue("@ProductName", productName);
			command.Parameters.AddWithValue("@ProductPrice", productPrice);
			command.ExecuteNonQuery();
			connection.Close();
			Console.WriteLine("Güncelleme işlemi başarılı!");
			#endregion
			Console.Read();
		}
    }
}
