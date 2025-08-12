using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimationStateController : MonoBehaviour

{
    Animator animator;
    int WalkingHash;
    int RunningHash;
   
    void Start()
    {

        animator = GetComponent<Animator>();
      
    }

    private void Update()
    {

        float yDirection = Input.GetAxis("Vertical");

        if (yDirection == 0)
        {
            animator.SetBool("Walking", false);
            return;
        }

        if (Input.GetKey("left shift"))
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
            animator.SetBool("Walking", true);
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("Running", false);
        }
        if (Input.GetKey ("d"))
        {
            animator.SetBool ("Right Turn", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("Right Turn", false);
            animator.SetBool("Walking", true);
        }
        if (Input.GetKey("a"))
        {
            animator.SetBool("Left Turn", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("Left Turn", false);
            animator.SetBool("Walking", true);
        }
        if (Input.GetKey("s"))
        {
            animator.SetBool("Back", true);
        }
        if (!Input.GetKey("s"))
        {
            animator.SetBool("Back", false);
            animator.SetBool("Walking", true);
        }
        if (Input.GetKey("space"))
        {
            animator.SetBool("Jump", true);
        }
        if (!Input.GetKey("space"))
        {
            animator.SetBool("Jump", false);
        }


    }
    
}


//void dsfdsvUpdate()
//{
//    bool RunPressed = Input.GetKey("left shift");
//    bool forwardPressed = Input.GetKey("w");
//    bool Walking = animator.GetBool(WalkingHash);
//    bool Running = animator.GetBool(RunningHash);   
//    if (!Walking && forwardPressed)
//    { 
//    animator.SetBool(WalkingHash, true);
//    }
//    if (Walking && !forwardPressed)
//    {
//        animator.SetBool(WalkingHash, false);
//    }
//if (!Running && (forwardPressed && RunPressed))
//    {
//    animator.SetBool(RunningHash, true);
//}
//if ((!forwardPressed || !RunPressed) && Running)
//{
//    animator.SetBool(RunningHash, false);
//}
//}


//}
