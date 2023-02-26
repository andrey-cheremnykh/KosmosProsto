using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LandedMenu : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] TMP_Text pointsText;
    public GameObject landMenu;
    EnemyReward reward;
    // Start is called before the first frame update
    void Start()
    {
        landMenu.SetActive(false);
        reward = FindObjectOfType<EnemyReward>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Score: " + reward.points;
    }
    public void WatchVideo()
    {
        GameObject.Find("Canvas").SetActive(false);
        var player = camera.GetComponent<UnityEngine.Video.VideoPlayer>();
        player.url = "https://www.youtube.com/watch?v=vWJa5gnhEg4&t=12s";
        player.Play();
    } 
    public void Continue()
    {
        print("kek");
        landMenu.SetActive(false);
    }
}
