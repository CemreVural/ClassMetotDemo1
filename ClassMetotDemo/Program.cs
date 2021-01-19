using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 357437130;
            customer1.Name = "Cemre";
            customer1.LastName = "Vural";
            customer1.MailAdress = "vuralgsli@gmail.com";
            customer1.Age = 23;
            

            Customer customer2 = new Customer();
            customer2.Id = 367419870;
            customer2.Name = "Mehmet";
            customer2.LastName = "Alihan";
            customer2.MailAdress = "alihan.mehmet@hotmail.com";
            customer2.Age = 30;

            Customer customer3 = new Customer();
            customer3.Id = 187766223;
            customer3.Name = "Engin";
            customer3.LastName = "Demirog";
            customer3.MailAdress = "engin.demirog@hotmail.com";
            customer3.Age = 29;


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Add(customer3);
        }
    }
}
