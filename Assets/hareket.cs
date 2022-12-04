using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        rightmovement();
        leftmovement();
    }

    public void rightmovement()
    {
        if (transform.position.x <= 3.73f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            
        }

    }

    public void leftmovement()
    {
        if (transform.position.x >= -3.59f)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
}
