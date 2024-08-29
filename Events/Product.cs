using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockKontrol();
    public class Product
    {
        int _stock; 
        public Product(int stock)
        {
            _stock=stock;
        }
        public event StockKontrol StockKontrolEvent;

        public string ProductName { get; set; }
        public int Stock { 
            get 
            {
                return _stock;
            } 
            set 
            {
                _stock = value;

                if(value <=20 && StockKontrolEvent != null)
                {
                    StockKontrolEvent();
                }
            
            } }



        public void Cell(int amount_miktar)
        {
            if (Stock > 10)
            {
                Stock -= amount_miktar; //burası  (Stock = stock-amount_miktar) demektir
                Console.WriteLine("stockamount : {0}  {1}",ProductName,Stock);
            }else
            {
                Console.WriteLine("dikkat stokta {0} {1}", ProductName, Stock+" adetten az kaldı");
                
            }
            
        }
    }

    
}
