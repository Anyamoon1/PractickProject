using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MIAPO
{
    public class MethodChangeStatus
    {
        public static List<MyTable> ChangeStatus(MyTable obj, List<MyTable> list)
        {
            if (obj == null)
            {
                return new List<MyTable>();
            }
            if (obj.Status == "Активный")
            {
                obj.Status = "Не активный";
                int idx = list.IndexOf(obj);
                list.Remove(obj);
                list.Insert(idx, new MyTable(obj.Id, obj.Surname, obj.NameEmployee, obj.Patronymic, obj.NumberPhone, obj.Status));
                return list;
            }
            else
            {
                return new List<MyTable>();
            }
        }
    }
}
