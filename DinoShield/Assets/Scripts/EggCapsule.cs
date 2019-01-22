using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCapsule : MonoBehaviour {

    public int buttonNum;
    private enum Eggstates { targeted, free };
    private Color defaultColor;
    private bool isCooledDown;
    public GameObject shield;

    private Renderer renderer;


    void Start()
    {
        isCooledDown = true;
        renderer = GetComponent<Renderer>();
        defaultColor = renderer.material.color;
      //  shield = transform.Find("shield").gameObject;
    }

   
    public void OnEggPress()
    {
        if (isCooledDown)
        {
            shield.transform.localScale = new Vector3(24,24,24);
            //SoundManagerScript.instance.PlaySingle(Manager.Instance.ShieldUp);
            isCooledDown = false;
            renderer.material.color = Color.red;
            Invoke("CoolDown", 2f);
    
        }
    }

    private void CoolDown()
    {
        shield.transform.localScale = new Vector3(10, 10, 10);
        isCooledDown = true;
        renderer.material.color = defaultColor;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (!isCooledDown)
    //    {
           
           
    //    }
    //    else
    //    {
           
           
    //    }
    //}
}
