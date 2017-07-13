using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    public int score = 0;
    public GameObject instance = null;

    void Start() {
        if(instance) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
            instance = gameObject;
        }
    }

    public void IncrementScore(int pointValue)
    {
        score += pointValue;
    }
}
