using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    public string CollectibleTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private  void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == CollectibleTag) {  
            GameObject.Destroy(collisionInfo.gameObject);
        }
    }
}
