using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Overriding 
{
    public class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("1st Apple Constructor Called");
        }
        public override void Chop()
        {
            base.Chop();
            Debug.Log("The apple has been chopped.");
        }

        public override void SayHello()
        {
            base.SayHello();
            Debug.Log("Hello, I am an apple.");
        }
    }
}