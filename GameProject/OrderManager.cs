using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public bool Validate(Kampanya kampanya)
        {
            if(kampanya.UrunAdi=="çilek" && kampanya.UrunFiyati==50 && kampanya.İndirimMiktari==20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
