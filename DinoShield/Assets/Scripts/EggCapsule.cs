using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCapsule : MonoBehaviour {

    public int buttonNum;
    private enum Eggstates { targeted, free };
    private Color defaultColor;
    private bool isCooledDown;

    private Renderer renderer;


    void Start()
    {
        isCooledDown = true;
        renderer = GetComponent<Renderer>();
        defaultColor = renderer.material.color;
    }

   
    public void OnEggPress()
    {
        if (isCooledDown)
        {
            isCooledDown = false;
            renderer.material.color = Color.red;
            Invoke("CoolDown", 2f);
    
        }
    }

    private void CoolDown()
    {
        isCooledDown = true;
        renderer.material.color = defaultColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isCooledDown)
            Manager.Instance.updateScore();
        else
            Manager.Instance.updateDamagedEggs();
    }
}
