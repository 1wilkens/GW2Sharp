using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Models.Items
{
    public enum ItemFlag
    {
      AccountBound       = 0,
      HideSuffix         = 1,
      NoMysticForge      = 2,
      NoSalvage          = 3,
      NoSell             = 4,
      NotUpgradeable     = 5,
      NoUnderwater       = 6,
      SoulBindOnAcquire  = 7,
      SoulBindOnUse      = 8,
      Unique             = 9
    }
}