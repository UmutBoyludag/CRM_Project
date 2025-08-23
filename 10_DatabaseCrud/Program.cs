using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            #region Katagori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Katagori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=UMUTBOYLUDAG\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Katagori Ekleme İşlemi Başarılı");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=UMUTBOYLUDAG\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@p1, @p2, @p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Ekleme İşlemi Başarılı!");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=UMUTBOYLUDAG\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek İstediğiniz Ürünün ID'sini Giriniz: ");
            //int productId =int .Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=UMUTBOYLUDAG\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@p1", connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı!");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellemek İstediğiniz Ürünün ID'sini Giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellemek İstediğiniz Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellemek İstediğiniz Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=UMUTBOYLUDAG\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@p1, ProductPrice=@p2 Where ProductID=@p3", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Ürün Güncelleme İşlemi Başarılı!");


            #endregion



            Console.Read();

        }
    }
}
