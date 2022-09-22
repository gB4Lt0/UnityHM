using UnityEngine;
using System.Collections;

namespace Polymorphism 
{

    public class FruitSalad : MonoBehaviour
    {
        void Start()
        {
            Fruit myFruit = new Apple();

            myFruit.SayHello();
            myFruit.Chop();

            Apple myApple = (Apple)myFruit;

            myApple.SayHello();
            myApple.Chop();
        }
    }
}

