using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Child : Parent
{
    public Parent m_Parent;
    //POLYMORPHISM
    public override void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * (m_Parent.MoveSpeed + 1f)); //ENCAPSULATION
    }

    // Update is called once per frame
    void Update()
    {
        MoveRight();
    }
}
