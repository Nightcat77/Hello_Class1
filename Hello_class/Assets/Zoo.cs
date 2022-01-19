using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "Åè";
        tom.sound = "³Ä¿Ë!!!!!!!!!!!!!";

        tom.PlayeSound();
    }

}
