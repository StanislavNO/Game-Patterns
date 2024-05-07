using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public interface IEnemy
    {
        void MoveTo(Vector3 at);
    }
}
