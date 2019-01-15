using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHandler : MonoBehaviour {

    private GameObject[] Asteroids = new GameObject[14];
    private DropIt[] TriggerDrop = new DropIt[14];

    private IEnumerator coroutine;
    bool canDrop = true;

    // Use this for initialization
    void Start()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            Asteroids[i] = transform.GetChild(i).gameObject;
            TriggerDrop[i] = Asteroids[i].GetComponent<DropIt>();
        }

        //foreach (Transform child in transform)
        //{       print("Foreach loop: " + child);
        //    Asteroids[i] = GetComponentInChildren<DropIt>().gameObject;
        //    //TriggerDrop[i] = GetComponentInChildren<DropIt>();
        //}
    }
	
    // Update is called once per frame
	void Update () {
       if(canDrop)
        StartCoroutine(RandDrop(4.0f));
	}

    private IEnumerator RandDrop(float waitTime) {
        canDrop = false;
        int toDrop = Random.Range(0, 13);
       // Debug.Log(toDrop);
        TriggerDrop[toDrop].DropItBaby();
        yield return new WaitForSeconds(waitTime);
        canDrop = true;
    }
  
}
