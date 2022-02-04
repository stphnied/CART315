using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BombGenerator : MonoBehaviour
{

    public GameObject bomb;
    public GameObject booster;
    float delay;
    float delayBooster;

    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(0.75f, 2f);
        delayBooster = Random.Range(2f, 5f);
        InvokeRepeating("generateBomb", 3f, delay);
        InvokeRepeating("generateBooster", 3f, delayBooster);
    }

    void generateBomb() {
        var randomPos = new Vector3(Random.Range(-29.5f, 26f), 22f, -22.23f);
        GameObject.Instantiate(bomb,randomPos, Quaternion.identity);

    }

    void generateBooster() {
        var randomPos = new Vector3(Random.Range(-29.5f, 26f), 22f, -22.23f);
        GameObject.Instantiate(booster,randomPos, Quaternion.identity);
    }
}
