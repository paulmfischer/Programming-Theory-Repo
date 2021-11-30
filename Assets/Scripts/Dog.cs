using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    void Awake()
    {
        this.AnimalName = "Fred";
    }
    
    public override void SayHello()
    {
        this.displayText.text = $"{this.GetUserName()}, I am Dog!";
    }
}
