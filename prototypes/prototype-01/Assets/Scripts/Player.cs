using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string BombTag;
    public string BoosterTag;
    public Text endText;
    public Text pointText;

    float points = 0f;

    void Start() {

    }

    void Update() {
        pointText.text = "POINTS: " +  points;
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == BombTag) {  
            Invoke("EndGame",1f);
            gameObject.SetActive(false);
            endText.gameObject.SetActive(true);
        }
        
        else if (collisionInfo.gameObject.tag == BoosterTag) {
            points++;
            GameObject.Destroy(collisionInfo.gameObject);
        }
    }

   public void EndGame() {
        SceneManager.LoadScene(0);
    }
}
