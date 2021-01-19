using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
		public void Add(Customer customer)
		{
			Console.WriteLine(customer.Name+ " " + customer.LastName + " " + "Adlı Müşteri Eklendi");
		}

		public void Guncelle(string MusteriAdi, string MusteriSoyadi)
		{
			Console.WriteLine(MusteriAdi + " " + MusteriSoyadi + " " + "Adlı Müşteri güncellendi");
		}

		public void Delete(Customer customer)
		{
			Console.WriteLine(customer.Name + " " + customer.LastName + " " + "Adlı Müşteri Silindi");
		}
	}
}
