using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    public class Bomb
    {
        private int _timer;

        public Bomb()
        {
         
        }

        public void Draw(Point2D _bombPosition)
        {
            SplashKit.DrawBitmap("Bomb", _bombPosition.X, _bombPosition.Y);
        }

        private void Explode()
        {

        }

        public int Timer
        {
            get
            {
                return _timer;
            }
        }
    }
}
