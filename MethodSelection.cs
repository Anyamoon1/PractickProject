using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MIAPO
{
    public class MethodSelection
    {
        public static List<MyTable> Selection(string str, List<MyTable> list)
        {
            List<MyTable> array = new List<MyTable>();
            switch (str)
            {
                case "Все":
                    array = list.ToList();
                    break;

                case "Активный":
                    array = list.Where(x => x.Status == "Активный").ToList();
                    break;

                case "Не активный":
                    array = list.Where(x => x.Status == "Не активный").ToList();
                    break;
            }
            return array;
        }
    }
}
