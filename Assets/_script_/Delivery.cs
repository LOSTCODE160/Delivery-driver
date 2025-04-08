using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("shittt");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == " Package")
        { Debug.Log(" package is picked"); }

        if (other.tag == "Loc")
        { Debug.Log("delivered"); }
    }
    
}
