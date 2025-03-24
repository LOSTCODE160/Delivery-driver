using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("shittt");
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("start"); 
    }
     
    Debug.Log("")
}
