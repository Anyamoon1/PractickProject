using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO
{
    public class MethodDataSourse
    {
        public static List<MyTable> DataList()
        {
            List<MyTable> result = new List<MyTable>
            {
                new MyTable(1, "Кулагина", "Анна", "Петровна", "89138545694", "Не активный"),
                new MyTable(2, "Буторов", "Артём", "Михайлович", "8913547842", "Активный"),
                new MyTable(3, "Козлова", "Арина", "Андреевна", "9875412478", "Активный"),
                new MyTable(4, "Забусов", "Никита", "Александрович", "89125478412", "Активный"),
                new MyTable(5, "Котенко", "Дмитрий", "Сергеевич", "9875412874", "Активный"),
                new MyTable(6, "Князев", "Владислав", "Маркович", "98787452478", "Активный"),
                new MyTable(7, "Попов", "Николай", "Артемович", "9875412852", "Активный"),
                new MyTable(8, "Соловьев", "Даниэль", "Маратович", "9547412478", "Активный"),
                new MyTable(9, "Иванов", "Илья", "Егорович", "98754174512", "Активный"),
                new MyTable(10, "Гусев", "Федор", "Николаевич", "89138546952", "Активный")
            };

            return result;
        }

        public static List<string> DataListStr()
        {
            List<string> ListComboBox = new List<string>
            {
                "Все",
                "Не активный",
                "Активный"
            };

            return ListComboBox;
        }
    }
}
