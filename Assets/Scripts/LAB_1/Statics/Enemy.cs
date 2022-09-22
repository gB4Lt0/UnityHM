using UnityEngine;
using System.Collections;

namespace Statics
{
    public class Enemy
    {
        public static int enemyCount = 0;

        public Enemy()
        {
            enemyCount++;
        }
    }
}

