using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
  

    // Update is called once per frame
    void Update()
    {
    
// Bouger à droite TP 
    if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position+=Time.deltaTime * moveSpeed * Vector3.right;
        }  
    if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position+=Time.deltaTime * moveSpeed * Vector3.left;
        }  
    if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position+=Time.deltaTime * moveSpeed * Vector3.forward;
        }  
    if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position+=Time.deltaTime * moveSpeed * Vector3.back;
        }  
    }
}
