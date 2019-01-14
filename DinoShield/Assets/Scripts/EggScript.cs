using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour {
    private enum Eggstates {targeted, free};

    private bool isCooledDown;
    public int buttonNum;


    private SpriteRenderer spriteRenderer;
    
    
	void Start () {
        isCooledDown = true;
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnEggPress()
    {
        if (isCooledDown)
        {
            isCooledDown = false;
            spriteRenderer.color = Color.red;
            Invoke("CoolDown", 2f);
           
        }
    }

    private void CoolDown()
    {
        isCooledDown = true;
        spriteRenderer.color = Color.white;
    }
}
