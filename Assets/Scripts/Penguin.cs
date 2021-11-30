using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Penguin : Animal
{
    void Awake()
    {
        this.AnimalName = "Ted";
    }

    public override void SayHello()
    {
        this.displayText.text = $"Let's dance {this.GetUserName()}!";
    }
}
