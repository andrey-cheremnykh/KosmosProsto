using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyReward : MonoBehaviour
{
   public int points = 0;
    [SerializeField] TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + points;
    }
    public void ScorePoints(int newPoints)
    {
        points += newPoints;
    }
}
