using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "≈Ë";
        tom.sound = "≥ƒøÀ!!!!!!!!!!!!!";

        Animal jerry = new Animal();
        jerry.name = "¡¶∏Æ";
        jerry.sound = "¬Ô©ê!";

        jerry = tom;
        jerry.name = "πÃ≈∞";

        tom.PlayeSound();
        jerry.PlayeSound();
    }

}
