using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flood_it_{

    class Board{

        private Tile[][] board;
        private Tile[] fringe;

        public void CreateBoard(){

            Random rand = new Random();

            int colorNumb;
            TileColor color;

            Tile newTile;

            for (int i = 0; i < board.Length; i++){
                for (int j = 0; j < board.Length; j++){

                    colorNumb = rand.Next(6);


                    switch (colorNumb){

                        case 0:
                        default:

                            color = TileColor.Red;
                            break;

                        case 1:
                            color = TileColor.Blue;
                            break;

                        case 2:
                            color = TileColor.Green;
                            break;

                        case 3:
                            color = TileColor.Pink;
                            break;

                        case 4:
                            color = TileColor.Yellow;
                            break;

                        case 5:
                            color = TileColor.Purple;
                            break;
                    }

                    newTile = new Tile(color);

                    board[i][j] = newTile;

                }
            }

        }

    }
}
