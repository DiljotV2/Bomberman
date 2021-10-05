using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bomberman;
using SplashKitSDK;
using System.Drawing;

namespace Bomberman
{
    public class Terrain
    {
        private Player _player;
        public Enemy E1;
        public Enemy E2;
        public Enemy E3;
        public Enemy E4;
        private string _map;
        private Point2D _drawCoords;


        private static byte[] _mapcontent;

        public Terrain(Player P)
        {
            _player = P;
        }

        public byte[] Mapcontent
        {
            get
            {
                return _mapcontent;
            }
            set
            {
                _mapcontent = value;
            }
        }        

        public void Loadmap(string filename)
        {
          
            StreamReader reader = new StreamReader(filename);
            _map = reader.Readmapcoords();
            _mapcontent = Encoding.ASCII.GetBytes(_map);
        }

        public void Draw_Map()
        {
            
            foreach (byte b in Mapcontent)
            {
                if (b == 10)
                {
                    _drawCoords.Y += 50;
                    _drawCoords.X = 0;
                }

                if (b == 35)
                {
                    Draw_Rock();
                }

                if (b == 42)
                {
                    Draw_SafePass();
                }

                if (b == 66)
                {
                    Draw_Bricks();
                }

                if (b == 49)
                {
                    E1 = new Enemy1();
                    E1.EnemyPosition = _drawCoords;
                    E1.DrawEnemy();
                    _drawCoords.X += 50;
                }

                if (b == 50)
                {
                     E2 = new Enemy2();
                    E2.EnemyPosition = _drawCoords;
                    E2.DrawEnemy();
                    _drawCoords.X += 50;

                }

                if (b == 51)
                {
                    E3 = new Enemy3();
                    E3.EnemyPosition = _drawCoords;
                    E3.DrawEnemy();
                    _drawCoords.X += 50;
                }

                if (b == 52)
                {
                    E4 = new Enemy4();
                    E4.EnemyPosition = _drawCoords;
                    E4.DrawEnemy();
                    _drawCoords.X += 50;
                }

                if (b == 80)
                {
                    _player.PlayerPosition = _drawCoords;
                    _player.DrawPlayer();
                  
                    _drawCoords.X += 50;
                }
                
              /*  if (b == 68)
                {
                    _player.BombPosition = _drawCoords;
                    int _delay = 6;
                    _delay--;
                    if(_delay == 0)
                    {
                        _player.PlantBombs();
                        _drawCoords.X += 50;
                    } 
                }*/
            }
        }

        public void ResetCoords()
        {
            _drawCoords.X = 0;
            _drawCoords.Y = 0;
        }

        public void Draw_Rock()
        {
            SplashKit.DrawBitmap("Rock", _drawCoords.X, _drawCoords.Y);
            _drawCoords.X += 50;
        }

        public void Draw_SafePass()
        {
            SplashKit.DrawBitmap("Safe_passage", _drawCoords.X, _drawCoords.Y);
            _drawCoords.X += 50; 
        }

        public void Draw_Bricks()
        {
            SplashKit.DrawBitmap("Brick", _drawCoords.X, _drawCoords.Y);
            _drawCoords.X += 50;
        }
    }
}
