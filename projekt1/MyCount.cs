using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    public class MN
    {
        public int MNO(int jeden, int dwa)
        {
            var wyn = jeden * dwa;
            return wyn;

        }

    }

    public class DOD
    {
        public int dod(int jeden, int dwa)
        {
            var wyn = jeden + dwa;
            return wyn;

        }
    }

    public class ODE
    {
        public int ode(int jeden, int dwa)
        {
            var wyn = jeden - dwa;
            return wyn;

        }
    }

    public class DZI
    {
        public int dzi(int jeden, int dwa)
        {
            var wyn = jeden / dwa;
            return wyn;

        }
    }
}
