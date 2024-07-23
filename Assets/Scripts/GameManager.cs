using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text Score;
    public static GameManager inst;
    private void Awake()
    {
        inst = this;
    }
    public void changeScore()
    {
        score = score + 10;
        Score.text = "SCORE: " + score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
