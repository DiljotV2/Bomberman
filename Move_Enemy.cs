using System;
using System.Collections.Generic;
using System.Text;

namespace Bomberman
{
    public class Move_Enemy : Move
    {
        public byte Enemynumber;
        private Terrain _level;

        public Move_Enemy(Terrain _level)
        {
            this._level = _level;
        }

        public override void Left()
        {
            int Enemy_position = 0;

            for (int i = 0; i < _level.Mapcontent.Length; i++)
            {
                if (_level.Mapcontent[i] == Enemynumber)
                {
                    Enemy_position = i;
                }
            }

            if (Enemy_position != 0 && Enemy_position != 18 && Enemy_position != 36 && Enemy_position != 54 && Enemy_position != 72 && Enemy_position != 90 && Enemy_position != 108 && Enemy_position != 126 && Enemy_position != 144 && Enemy_position != 162 && Enemy_position != 180)
            {
                byte DestinationTiletype = _level.Mapcontent[Enemy_position - 1];

                if (_level.Mapcontent[Enemy_position - 1] != 66 && _level.Mapcontent[Enemy_position - 1] != 35)
                {
                    //  Console.WriteLine("This is the player position index" + Player_position);

                    _level.Mapcontent[Enemy_position - 1] = _level.Mapcontent[Enemy_position];

                    _level.Mapcontent[Enemy_position] = DestinationTiletype;

                }
            }
        }

        public override void Right()
        {
            int Enemy_Position = 0;

            for (int i = 0; i < _level.Mapcontent.Length; i++)
            {
                if (_level.Mapcontent[i] == Enemynumber)
                {
                    Enemy_Position = i;
                }

            }

            if (Enemy_Position != 15 && Enemy_Position != 33 && Enemy_Position != 51 && Enemy_Position != 69 && Enemy_Position != 87 && Enemy_Position != 105 && Enemy_Position != 123 && Enemy_Position != 141 && Enemy_Position != 159 && Enemy_Position != 177 && Enemy_Position != 195)
            {
                byte DestinationTiletype = _level.Mapcontent[Enemy_Position + 1];

                if (_level.Mapcontent[Enemy_Position + 1] != 66 && _level.Mapcontent[Enemy_Position + 1] != 35)
                {
                    // Console.WriteLine("This is the player position index" + Player_position);

                    _level.Mapcontent[Enemy_Position + 1] = _level.Mapcontent[Enemy_Position];

                    _level.Mapcontent[Enemy_Position] = DestinationTiletype;

                }
            }
        }

        public override void Up()
        {
            int Enemy_Position = 0;

            byte[] somethingelse = Encoding.ASCII.GetBytes("P");
            for (int i = 0; i < _level.Mapcontent.Length; i++)
            {
                if (_level.Mapcontent[i] == Enemynumber)
                {
                    Enemy_Position = i;
                }
            }

            if (Enemy_Position >= 18)
            {
                byte DestinationTiletype = _level.Mapcontent[Enemy_Position - 18];
                if (_level.Mapcontent[Enemy_Position - 18] != 66 && _level.Mapcontent[Enemy_Position - 18] != 35)
                {
                    //   Console.WriteLine("This is the player position index" + Player_position);
                    _level.Mapcontent[Enemy_Position - 18] = _level.Mapcontent[Enemy_Position];
                    _level.Mapcontent[Enemy_Position] = DestinationTiletype;
                }
            }
        }

        public override void Down()
        {
            int Enemy_Position = 0;

            for (int i = 0; i < _level.Mapcontent.Length; i++)
            {
                if (_level.Mapcontent[i] == Enemynumber)
                {
                    Enemy_Position = i;
                }
            }

            if(Enemy_Position <= 176)
            {
                byte DestinationTiletype = _level.Mapcontent[Enemy_Position + 18];

                if (_level.Mapcontent[Enemy_Position + 18] != 66 && _level.Mapcontent[Enemy_Position + 18] != 35)
                {
                    //Console.WriteLine("This is the player position index" + Player_position);
                    _level.Mapcontent[Enemy_Position + 18] = _level.Mapcontent[Enemy_Position];
                    _level.Mapcontent[Enemy_Position] = DestinationTiletype;
                }
            }
        }
    }
}
