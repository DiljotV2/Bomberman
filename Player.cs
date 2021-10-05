using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    public class Player
    {
        private int _delay = 5;
        private Point2D _playerPosition;

        private int _bombcapacity;
        private int _bombCooldown;

        private Point2D _bombandPlayerPosition;

        private Point2D _bombPosition;
        private int _bombPostion_on_map;

        private bool _bombholding;
        private Move_Player Controller;

        private bool _beforeMoving;
        private bool _afterMoving;

        public bool BeforeMoving
        {
            get
            {
                return _beforeMoving;
            }
        }

        public bool AfterMoving
        {
            get
            {
                return _afterMoving;
            }
        }

        public Point2D BombPosition
        {
            get
            {
                return _bombPosition;
            }
            set
            {
                _bombPosition = value;
            }
        }

        public int BombPostion_on_map
        {
            get
            {
                return _bombPostion_on_map;
            }
            set
            {
                _bombPostion_on_map = value;
            }
        }


        public Point2D PlayerPosition
        {
            get
            {
                return _playerPosition;
            }
            set
            {
                _playerPosition = value;
            }
        }

        public Player()
        {
            _bombcapacity = 1;
            _bombCooldown = 0;
        }

        public void Update(Terrain level)// for moving and drawing bombs its like image stuff transitioning
        {
            /*if(_bombPostion_on_map != 0)
            Console.WriteLine("Need to check is it changing or not" +_bombPostion_on_map);*/

            if (SplashKit.KeyDown(KeyCode.RightKey) || SplashKit.KeyDown(KeyCode.LeftKey) || SplashKit.KeyDown(KeyCode.UpKey) || SplashKit.KeyDown(KeyCode.DownKey))
            {
                _beforeMoving = true;

                if (_bombcapacity == 0)
                    _bombholding = false;

                PlayerMove(level);

                if(_bombCooldown > 0 && _bombholding == false)
                    _afterMoving = true;
            }
            
            if (SplashKit.KeyDown(KeyCode.SpaceKey))
            {
                if(_bombcapacity > 0)// ineed to think thru that the player dont plant two bombs at one place if i use abilities
                {
                    _delay--;
                    if (_delay == 0)
                    {
                        _delay = 5;
                        _bombholding = true;
                        _bombCooldown = 120;
                        _bombandPlayerPosition = PlayerPosition;
                        _bombPosition = PlayerPosition;
                        _bombcapacity--;
                    }
                }
            }
        }

        public void PlayerMove(Terrain level)
        {

            Controller = new Move_Player(level);//need to change this if and if again to polymosphic design i read today in lecture

            _delay--;
            if (_delay == 0)
            {
                _delay = 5;
                if (SplashKit.KeyDown(KeyCode.RightKey))
                    Controller.Right();
                
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                    Controller.Left();

                if (SplashKit.KeyDown(KeyCode.UpKey))
                    Controller.Up();
                
                if (SplashKit.KeyDown(KeyCode.DownKey))
                    Controller.Down();
                
            }
        }

        public void DrawPlayer()
        {
            SplashKit.DrawBitmap("Player", PlayerPosition.X, PlayerPosition.Y);
        }

        public void PlantBombs()
        {
            Bomb _bomb = new Bomb();
            _bomb.Draw(_bombPosition);

        }

        public void Cooldown()//for making user to unable to plant bomb if previous bomb havent exploded
        {
            if (_bombCooldown > 0)
            {
                _bombCooldown--;
                if(_bombholding == true)
                {
                    SplashKit.DrawBitmap("Bomb_Player", _bombandPlayerPosition.X, _bombandPlayerPosition.Y);
                }
                else
                {
                        PlantBombs();
                }
            }
            else if(_bombCooldown == 0)
            {
                _bombcapacity = 1;
                _bombPostion_on_map = 0;
            }
        }
    }
}
