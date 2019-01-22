using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropIt : MonoBehaviour {

    public Rigidbody rb;
    Vector3 initPos,currentPos;
    Quaternion initRot;
    bool IsDropping = false;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        initPos = this.transform.position;
        initRot = this.transform.rotation;
    }

    private void Update()
    {
        //if (!IsDropping)
        //{
        //    this.transform.SetPositionAndRotation(currentPos,initRot);   
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Manager.Instance.isGameStarted)
        {
            // if it collides with egg
            if (collision.gameObject.tag == "Egg")
            {
                IsDropping = false;
                Debug.Log("Collision with Egg");
                // decrease the score/lives
                Manager.Instance.updateDamagedEggs();

                SoundManagerScript.instance.PlaySingle(Manager.Instance.AsteroidHitEgg);
                // go back to init position
                rb.velocity = new Vector3(0, 0, 0);
                currentPos = initPos;
                this.transform.SetPositionAndRotation(currentPos, initRot);

            }

            // if it collides with plate
            if (collision.gameObject.tag == "shield")
            {
                Debug.Log("Collision with plate");
                // increase the score
                Manager.Instance.updateScore();
                SoundManagerScript.instance.PlaySingle(Manager.Instance.AsteroidHitShield);
                // go back to init position
                rb.velocity = new Vector3(0, 0, 0);
                currentPos = initPos;
                this.transform.SetPositionAndRotation(currentPos, initRot);
            }
        }
    }

    public void DropItBaby() {
        IsDropping = true;
        SoundManagerScript.instance.PlaySingle(Manager.Instance.AsteroidRelease);
        rb.velocity = new Vector3(0,-2,0);
    }

}
