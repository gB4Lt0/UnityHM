using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemberHiding
{
    public class Orc : Enemy
    {
        new public void Yell()
        {
            Debug.Log("Orc version of the Yell() method");
        }
    }
}