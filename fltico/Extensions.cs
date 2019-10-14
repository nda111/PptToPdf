using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms.Extensions
{
    public static class Extensions
    {
        public static StartupPositionFlag GetHorizontalFlag(this StartupPositionFlag flag)
        {
            return flag & StartupPositionFlag.HORIZONTAL_MASK;
        }

        public static StartupPositionFlag GetVerticalFlag(this StartupPositionFlag flag)
        {
            return flag & StartupPositionFlag.VERTICAL_MASK;
        }

        public static StartupPositionFlag GetDirectionFlag(this StartupPositionFlag flag)
        {
            return flag & StartupPositionFlag.DIRECTION_MASK;
        }

        public static bool ContainsAllFlags(this StartupPositionFlag flag)
        {
            return 
                flag.GetHorizontalFlag() != StartupPositionFlag.NONE && 
                flag.GetVerticalFlag() != StartupPositionFlag.NONE && 
                flag.GetDirectionFlag() != StartupPositionFlag.NONE;
        }
    }
}
