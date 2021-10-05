using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    public class Enemy4 : Enemy
    {
        private Point2D _enemyPosition;

        public Enemy4()
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

        public override void DrawEnemy()
        {
            SplashKit.DrawBitmap("Enemy", _enemyPosition.X, _enemyPosition.Y);
        }

        public override void Random_Movement(Terrain level)
        {
            Move_Enemy enemyMove = new Move_Enemy(level);

            enemyMove.Enemynumber = 52;

            int RandomMovement = SplashKit.Rnd(4);

            if (RandomMovement == 0)
            {
                enemyMove.Left();
            }
            if (RandomMovement == 1)
            {
                enemyMove.Right();
            }
            if (RandomMovement == 2)
            {
                enemyMove.Up();
            }
            if (RandomMovement == 3)
            {
                enemyMove.Down();
            }
        }
    }
}
