using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Utility
{
    public class TableToDict
    {
        public static Dictionary<string, string> ToDict(Table table)
        {
            var dict = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dict.Add(row[0], row[1]);
            }
            return dict;
        }
    }
}
