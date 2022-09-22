using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces 
{
    public interface IKillable
    {
        void Kill();
    }

    public interface IDamageable<T>
    {
        void Damage(T damageTaken);
    }
}
