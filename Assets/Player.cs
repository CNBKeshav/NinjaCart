using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int place;
    private int currentCheckpoint = 0;
    private int currentLap = 0;
    public Text lapText;
    public Leaderboard lb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkPointActivated(Checkpoint checkpoint)
    {
        if (checkpoint.count == currentCheckpoint)
        {
            if (checkpoint.isLastCheckpoint)
            {
                Debug.Log("FINISHED");
                if (currentLap == 3)
                {
                    // logic for end game & scoring.
                }
                currentLap++;
                lb.gameOver();
                currentCheckpoint = 0;
                lapText.text = "LAPS: " + currentLap + "/3";
                return;
            }
            currentCheckpoint++;
        }
    }



    public int getPlace() 
    { 
        return place; 
    }
}
