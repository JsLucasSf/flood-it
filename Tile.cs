using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flood_it_{
    
    enum TileColor{

        Red,
        Blue,
        Green,
        Pink,
        Yellow,
        Purple

    }

    class Tile{

        private TileColor color { get; set; }

        public Tile(TileColor color){
            
            this.color = color;

        }

    }
}
