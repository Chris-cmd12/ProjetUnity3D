using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;

    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            speed = 10f;
            transform.position += transform.forward * Time.deltaTime * speed;
            animator.SetFloat("IsRunningForward", speed);
        }
        else
        {
            speed = 0;
            animator.SetFloat("IsRunningForward", speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed = 10f;
            transform.position -= transform.forward * Time.deltaTime * speed;
            animator.SetFloat("IsRunningBackward", speed);
        }
        else
        {
            speed = 0;
            animator.SetFloat("IsRunningBackward", speed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -Time.deltaTime *100f, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Time.deltaTime*100f, 0);
        }
    }

}

