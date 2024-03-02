using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    //ENCAPSULATION
    private float m_MoveSpeed = 0.5f;
    public float MoveSpeed 
    {
        get { return m_MoveSpeed; } 
        set { m_MoveSpeed = value; }
    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        MoveRight();
    }

    //ABSTRACTION
    public virtual void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 1);
    }
}
