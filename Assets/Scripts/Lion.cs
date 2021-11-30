using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Lion : Animal
{
    void Awake()
    {
        this.AnimalName = "Bruno";
    }

    public override void SayHello()
    {
        this.displayText.text = $"Hello {this.GetUserName()}, I am a proud Lion and my name is {animalName}!";
    }
}
