using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    public class Enemy3 : Enemy
    {
        private Point2D _enemyPosition;

       // private int _enemynumber;//need to use that soon

        public Enemy3()
        {

        }

        public override Point2D EnemyPosition
        {
            get
            {
                return _enemyPosition;
            }
            set
            {
                _enemyPosition = value;
            }
        }

        public override void DrawEnemy()//for drawing bombs and extra bomb and player association imgaes
        {
            SplashKit.DrawBitmap("Enemy", _enemyPosition.X, _enemyPosition.Y);
        }

        public override void Random_Movement(Terrain _level)
        {
            Move_Enemy enemy = new Move_Enemy(_level);

            enemy.Enemynumber = 51;

            int RandomMovement = SplashKit.Rnd(4);

            if (RandomMovement == 1)
            {
                enemy.Left();
            }
            if (RandomMovement == 2)
            {
                enemy.Right();
            }
            if (RandomMovement == 3)
            {
                enemy.Up();
            }
            if (RandomMovement == 4)
            {
                enemy.Down();
            }
        }
    }
}
