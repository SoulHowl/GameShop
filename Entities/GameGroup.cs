using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953504_Barsukevich.Entities
{
    public class GameGroup
    {
        public int GameGroupId { get; set; }
        public string GroupName { get; set; }
        public List<Game> Games { get; set; }

    }
}
