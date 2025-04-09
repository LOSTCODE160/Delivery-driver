using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasColorPackage=new Color32(1,1,1,1);
    [SerializeField] Color32 noColorPackage = new Color32(1, 1, 1, 1);

    [SerializeField] float Destroy_Time = 1.0f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("shittt");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package2" && !hasPackage)
        { Debug.Log(" package is picked"); hasPackage = true; Destroy(other.gameObject, Destroy_Time); }

        if (other.tag == "Loc" && hasPackage)   
        { Debug.Log("delivered");
            hasPackage = false;
        }
    }
    
}
