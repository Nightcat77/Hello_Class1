using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�!!!!!!!!!!!!!";

        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "�祖!";

        jerry = tom;
        jerry.name = "��Ű";

        tom.PlayeSound();
        jerry.PlayeSound();
    }

}
