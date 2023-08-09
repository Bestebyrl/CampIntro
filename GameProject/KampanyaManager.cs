using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager : IKampanyaService
    {
        IOrderService _orderService;

        public KampanyaManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void Add(Kampanya kampanya)
        {
            if(_orderService.Validate(kampanya)==true)
            {
                Console.WriteLine("Kampanya eklendi");
            }
            else
            {
                Console.WriteLine("Kampanya ekleme başarısız");
            }
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampnaya silindi");
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampnaya güncellendi");
        }
    }
}
