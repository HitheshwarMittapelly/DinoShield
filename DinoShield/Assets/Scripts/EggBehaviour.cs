using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetKeyDown(KeyCode.Z))
        {
            GetCorrespondingEgg(0).GetComponent<EggScript>().OnEggPress();
        }else if(Input.GetKeyDown(KeyCode.C)){
            GetCorrespondingEgg(1).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            GetCorrespondingEgg(2).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            GetCorrespondingEgg(3).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.Period))
        {
            GetCorrespondingEgg(4).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetCorrespondingEgg(5).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            GetCorrespondingEgg(6).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            GetCorrespondingEgg(7).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            GetCorrespondingEgg(8).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            GetCorrespondingEgg(9).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            GetCorrespondingEgg(10).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            GetCorrespondingEgg(11).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            GetCorrespondingEgg(12).GetComponent<EggScript>().OnEggPress();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            GetCorrespondingEgg(13).GetComponent<EggScript>().OnEggPress();
        }


    }
    private GameObject GetCorrespondingEgg(int buttonNum)
    {
       foreach(Transform child in transform)
        {
            if (child.GetComponent<EggScript>().buttonNum == buttonNum)
                return child.gameObject;
        }
        return null;
    }
}
