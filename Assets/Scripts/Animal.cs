using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected string animalName;
    [SerializeField]
    public string AnimalName
    {
        get { return animalName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Debug.Log("A Name is required!");
            }
            else
            {
                animalName = value;
            }
        }
    }

    // ABSTRACTION
    [SerializeField]
    protected TextMeshProUGUI displayText;

    // ABSTRACTION
    protected string GetUserName()
    {
        return GameData.Instance.userName;
    }

    // POLYMORPHISM
    public virtual void SayHello()
    {
        displayText.text = $"Hello {GameData.Instance.userName}, my name is {animalName}";
    }

    // ABSTRACTION
    void OnMouseDown()
    {
        this.SayHello();
    }
}
