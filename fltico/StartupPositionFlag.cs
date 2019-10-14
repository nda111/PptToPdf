using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms.Extensions
{
    public enum StartupPositionFlag : byte
    {
        NONE = 0,

        TOP = 0x01, 
        BOTTOM = 0x02,
        MIDDLE = TOP | BOTTOM,

        LEFT = 0x04,
        RIGHT = 0x08,
        CENTER = LEFT | RIGHT,

        LEFTWARD = 0x10,
        RIGHTWARD = 0x20,
        UPWARD = 0x40,
        DOWNWARD = 0x80,

        DEFAULT = BOTTOM | RIGHT | UPWARD,

        VERTICAL_MASK = 0x03,
        HORIZONTAL_MASK = 0x0C,
        DIRECTION_MASK = 0xF0,
    }
}
