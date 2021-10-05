using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SplashKitSDK;

namespace Bomberman
{
    public abstract class Enemy
    {
        private Point2D _enemyPosition;

        public Enemy()
        {
            
        }

        public virtual Point2D EnemyPosition
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

        public abstract void DrawEnemy();

        public abstract void Random_Movement(Terrain level);
    }
}
