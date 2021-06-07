using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Adress
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Adress)
            {
                Adress adress = (Adress)obj;
                if (adress.ID == ID && adress.Country == Country && adress.City == City)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}