using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DataBase
    {
        private static DataBase _context;
        public static DataBase GetContext()
        {
            if (_context == null)
                _context = new DataBase();
            return _context;
        }
    }
}
