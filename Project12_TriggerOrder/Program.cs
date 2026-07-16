
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project12_TriggerOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Db12Project20Entities1 context = new Db12Project20Entities1();


            String number;
            Console.WriteLine("Sipariş Stok Listesi");
            Console.WriteLine();
            Console.WriteLine("1-)Ürün Listesi");
            Console.WriteLine("2-)Sipariş Listesi");
            Console.WriteLine("3-)Kasa Durmu");
            Console.WriteLine("4-)Yeni Ürün Satışı");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.Write("Yapmak İstediginiz İşlemi Seciniz: ");
            number = Console.ReadLine();
            Console.WriteLine();

            if (number == "1")
            {

                var value = context.TblProduct.ToList();
                Console.WriteLine("Ürün Listesi\n----------------------------");
                foreach (var item in value)
                {
                    Console.WriteLine($"{item.ProductId}-) {item.ProductName} | Stok: {item.ProductStock} | Fiyat: {item.ProductPrice} TL");
                }

            }
            else if (number == "2") 
            {
                var value = context.TblOrder.ToList();
                Console.WriteLine("Ürün Listesi\n----------------------------");
                foreach (var item in value)
                {
                    Console.WriteLine($"{item.OrderId}-) {item.TblProduct.ProductName} | Fiyat: {item.UnitPrice} | Adet: {item.Quantity} Toplam Fiyat: {item.TotalPrice} TL");
                }
            }
            else if(number == "3")
            {
                var value = context.TblCashRegister.ToList();
                Console.WriteLine("Ürün Listesi\n----------------------------");
                foreach(var item in value)
                {
                    Console.WriteLine($"{item.CashRegisterId}-)Kasadaki toplam tutar \n{item.Balance}");
                }
            }
            else if (number == "4")
            {
                Console.WriteLine("----- Yeni Sipariş Girişi ----");
                Console.Write("Müşeti Adı: ");
                String name = Console.ReadLine();
                Console.Write("Ürün Id: ");
                int productId = int.Parse(Console.ReadLine());
                Console.Write("Ürün Adedi: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("---Ürün Bilgileri---");

                var productName = context.TblProduct.Where(x => x.ProductId == productId).Select(y=>y.ProductName).FirstOrDefault();
                Console.WriteLine("Ürün Adı: " + productName);

                
                var productPrice = context.TblProduct.Where(x => x.ProductId == productId).Select(y => y.ProductPrice).FirstOrDefault();
                Console.WriteLine("Birim Fiyatı: " + productPrice);
                
    
                decimal Totalprice = quantity* decimal.Parse(productPrice.ToString());
                Console.Write("Toplam Fiyat: " + Totalprice);

            }

            else if (number == "5")
            {
                var value = context.TblProces.Select(x => x.Process).FirstOrDefault();
                Console.WriteLine("Toplam İşlem Sayısı: " + value);
            }

            Console.Read();
        
        }
    }

}