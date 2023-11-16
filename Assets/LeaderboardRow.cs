using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardRow : MonoBehaviour
{
    public Text playerText;
    public Text placeText;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initate(string player, string place)
    {
        playerText.text = player;
        placeText.text = place;
        panel.SetActive(true);
    }
}
