using System;
using System.Collections.Generic;
using System.Text;

namespace Bomberman
{
    class Move_Player : Move
    {
        private Terrain level;

        private int _playerPostion;

        public Move_Player(Terrain _level)
        {
            level = _level;
        }

        public override void Left()
        {
            //int Player_position = 0;

            //byte[] somethingelse = Encoding.ASCII.GetBytes("P");
            for (int i = 0; i < level.Mapcontent.Length; i++)
            {
                if (level.Mapcontent[i] == 80)
                {
                    _playerPostion = i;
                }
            }
            if (_playerPostion != 0 && _playerPostion != 18 && _playerPostion != 36 && _playerPostion != 54 && _playerPostion != 72 && _playerPostion != 90 && _playerPostion != 108 && _playerPostion != 126 && _playerPostion != 144 && _playerPostion != 162 && _playerPostion != 180)
            {
                byte DestinationTiletype = level.Mapcontent[_playerPostion - 1];

                if (level.Mapcontent[_playerPostion - 1] != 66 && level.Mapcontent[_playerPostion - 1] != 35)
                {
                    //  Console.WriteLine("This is the player position index" + Player_position);

                    level.Mapcontent[_playerPostion - 1] = level.Mapcontent[_playerPostion];

                    level.Mapcontent[_playerPostion] = DestinationTiletype;

                }
            }
     
        }

        public override void Right()
        {
            //int Player_position = 0;

            //byte[] somethingelse = Encoding.ASCII.GetBytes("P");
            for (int i = 0; i < level.Mapcontent.Length; i++)
            {
                if (level.Mapcontent[i] == 80)
                {
                    _playerPostion = i;
                }

            }

            if(_playerPostion != 15 && _playerPostion != 33 && _playerPostion != 51 && _playerPostion != 69 && _playerPostion != 87 && _playerPostion != 105 && _playerPostion != 123 && _playerPostion != 141 && _playerPostion != 159 && _playerPostion != 177 && _playerPostion != 195)
            {
                byte DestinationTiletype = level.Mapcontent[_playerPostion + 1];

                if (level.Mapcontent[_playerPostion + 1] != 66 && level.Mapcontent[_playerPostion + 1] != 35)
                {
                    // Console.WriteLine("This is the player position index" + Player_position);

                    level.Mapcontent[_playerPostion + 1] = level.Mapcontent[_playerPostion];

                    level.Mapcontent[_playerPostion] = DestinationTiletype;

                }
            }
       
        }

        public override void Up()
        {
            //int Player_position = 0;

            //byte[] somethingelse = Encoding.ASCII.GetBytes("P");
            for (int i = 0; i < level.Mapcontent.Length; i++)
            {
                if (level.Mapcontent[i] == 80)
                {
                    _playerPostion = i;
                }
            }

            if (_playerPostion >= 18)
            {
                byte DestinationTiletype = level.Mapcontent[_playerPostion - 18];
                if (level.Mapcontent[_playerPostion - 18] != 66 && level.Mapcontent[_playerPostion - 18] != 35)
                {
                    //   Console.WriteLine("This is the player position index" + Player_position);
                    level.Mapcontent[_playerPostion - 18] = level.Mapcontent[_playerPostion];
                    level.Mapcontent[_playerPostion] = DestinationTiletype;
                }
            }
        }

        public override void Down()
        {
           // int Player_position = 0;

           // byte[] somethingelse = Encoding.ASCII.GetBytes("P");
            for (int i = 0; i < level.Mapcontent.Length; i++)
            {
                if (level.Mapcontent[i] == 80)
                {
                    _playerPostion = i;
                }
            }

            if(_playerPostion <= 176)
            {
                byte DestinationTiletype = level.Mapcontent[_playerPostion + 18];

                if (level.Mapcontent[_playerPostion + 18] != 66 && level.Mapcontent[_playerPostion + 18] != 35)
                {
                    //Console.WriteLine("This is the player position index" + Player_position);
                    level.Mapcontent[_playerPostion + 18] = level.Mapcontent[_playerPostion];
                    level.Mapcontent[_playerPostion] = DestinationTiletype;

                }
            }
        }
    }
}
