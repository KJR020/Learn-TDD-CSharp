using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class DB : IDB
    {
        public int GetDBValue()
        {
            {
                // 実際はDBから値を取得する
                return 100;
            }
        }
    }
}
