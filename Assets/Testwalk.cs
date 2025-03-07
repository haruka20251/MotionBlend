using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testwalk : MonoBehaviour
{
    public Animator animator;
    public float acceleration = 0.5f;//‰Á‘¬“x
    public float deceleration = 0.4f;//Œ¸‘¬“x
    public float maxSpeed = 1f;
    private float speed = 0;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += acceleration * Time.deltaTime;
        }
        else
        {
            speed -= deceleration * Time.deltaTime*0.2f ;
        }
        speed = Mathf.Clamp(speed, 0f, maxSpeed);
        animator.SetFloat("Blend", speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
                animator.SetTrigger("Jump Trigger");
            }
        }
    }
}
