using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReustrantApp
{
    public class OrderItem
    {
        public int menuID;
        public string name;
        public decimal price;
        public int quantity;
        public OrderItem(int MenuID, string Name, decimal Price, int Quantity) 
        {
            menuID = MenuID;
            name = Name;
            price = Price;
            quantity = Quantity;
        }
    }
}
