using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    
    public string BombTag;
    public string BoosterTag;

        private  void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == BombTag || collisionInfo.gameObject.tag == BoosterTag) {  

            GameObject.Destroy(collisionInfo.gameObject);
        }
    }
}
