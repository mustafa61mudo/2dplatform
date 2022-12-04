using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class playermowement : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 1f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

    }
    void Start()
    {
        
    }

   
    private void Update()
    {
        Vector3 vektor = Input.GetAxisRaw("Horizontal") * Vector3.right + Input.GetAxisRaw("Vertical") * Vector3.forward;

        Vector3 moveVelocity = vektor * Time.deltaTime * speed;
    }
}
