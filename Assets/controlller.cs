using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlller : MonoBehaviour
{
    [SerializeField] float forwardspeed;

   
   

    void Start()
    {
        
    }

    
    void Update()
    {
        this.transform.Translate(0, 0, forwardspeed * Time.deltaTime);

     
      
        
    }


   



}
