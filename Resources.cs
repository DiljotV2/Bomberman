using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    class Resources
    {

        public void Load_images()
        {
            SplashKit.LoadBitmap("Safe_passage", "images/SafePassageTile.bmp");
            SplashKit.LoadBitmap("Bomb_Player", "images/Bomb_Player.bmp");
            SplashKit.LoadBitmap("Rock", "images/RockTile.bmp");
            SplashKit.LoadBitmap("Brick", "images/BricksTile.bmp");
            SplashKit.LoadBitmap("Player", "images/Player.bmp");
            SplashKit.LoadBitmap("Enemy", "images/Enemy.bmp");
            SplashKit.LoadBitmap("Bomb", "images/Bomb.bmp");
        } 

    }
}
