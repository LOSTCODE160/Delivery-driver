using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{


    [SerializeField] GameObject thingToFollow;
    
    void Update()
    {   
        transform.position= thingToFollow.transform.position;
        
    }
}
