using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField]
     float _SteerSpeed = 1f;
    [SerializeField]
    float _moveSpeed = 0.01f;
    void Start()
    {

       
    }

    
    void Update()
    {

        float SteerAmount = Input.GetAxis("Horizontal")*_SteerSpeed*Time.deltaTime;
        float MoveSpeed = Input.GetAxis("Vertical") * _moveSpeed*Time.deltaTime;
      transform.Rotate(0, 0,-SteerAmount); 
      transform.Translate(0,MoveSpeed,0);

    }
}
