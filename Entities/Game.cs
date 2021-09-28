using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953504_Barsukevich.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; } 
        public string Description { get; set; }
        [DisplayName("Price, $")]
        public int Price { get; set; }
        public string Image { get; set; }  
        
        public int GameGroupId { get; set; }
        public GameGroup Group { get; set; }

        public string PriceToString()
        {
            return Price.ToString() + " $";
        }
    }
}
