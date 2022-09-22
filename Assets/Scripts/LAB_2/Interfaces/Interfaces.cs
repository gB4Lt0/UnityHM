using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces 
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
    {
        public void Kill()
        {
            Debug.Log("Oh no, you are dead!)");
        }

        public void Damage(float damageTaken)
        {
            Debug.Log("Ugh");
        }
    }
}