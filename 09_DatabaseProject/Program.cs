using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ado.net

           
            Console.WriteLine();
            Console.WriteLine("********** C# Veri Tabanlı Ürün - Kategori Bİlgi Sistemi **********");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap.");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source=SAKULTA;initial Catalog=EgitimKampıDb;integrated security=true");
              
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From tblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            connection.Close();

            foreach(DataRow row in datatable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
            }





            Console.Read();

        }

    }
}
