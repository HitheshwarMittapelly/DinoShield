using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour

{

    Animator animator;
    public char key;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(""+key))
            animator.SetTrigger("On");
        if (Input.GetKeyUp(""+key))
            animator.SetTrigger("Off");
    }

    
}
