using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{

    public Rigidbody rigid;
    void Start()
    {
        rigid.AddForce(0, 500, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            rigid.AddForce(0, 500, 0);
    }
}
