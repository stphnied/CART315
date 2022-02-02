using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.gameObject == player) {
            // Debug.Log("collision deteced");
            this.GetComponent<Rigidbody>().AddForce(0f,1000f,0f);
        }
    }
}
