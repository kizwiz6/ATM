using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ListOfCardHolders
    {
        public void createUserList()
        {
            List<cardHolder> list = new List<cardHolder>();

            list.Add(new cardHolder("123456789", 1234, "Kieran", "Wiz", 9999.99));
            list.Add(new cardHolder("234567891", 2345, "Bobs", "YaUncle", 321.40));
            list.Add(new cardHolder("345678912", 3456, "Mike", "Hawk", 105.50));
            list.Add(new cardHolder("456789123", 4567, "Bill", "Gates", 999999993234.12));
            list.Add(new cardHolder("567891234", 5678, "Broke", "Debts", 3.42));
        }
    }
}
