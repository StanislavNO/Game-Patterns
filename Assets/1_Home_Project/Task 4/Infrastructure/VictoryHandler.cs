using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Task4
{
    public abstract class VictoryHandler
    {


        protected VictoryHandler()
        {
            
        }

        public abstract void Update(Enemy enemy);
    }
}