using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    void Awake()
    {
        this.AnimalName = "Kujo";
    }

    public override void SayHello()
    {
        this.displayText.text = $"Well hello {this.GetUserName()}, what have you brought {animalName} for dinner?";
    }
}
