using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Overriding
{
    public class FruitSalad : MonoBehaviour
    {
        void Start()
        {
            Apple myApple = new Apple();

            myApple.SayHello();
            myApple.Chop();

            Fruit myFruit = new Apple();
            myFruit.SayHello();
            myFruit.Chop();
        }
    }

}