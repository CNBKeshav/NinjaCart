using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int place;
    private int currentCheckpoint = 0;
    private int currentLap = 0;
    public TextMeshProUGUI lapText;
    public Leaderboard lb;
    public string SceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        lapText.text = "LAPS: " + currentLap + "/3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkPointActivated(Checkpoint checkpoint)
    {
        Debug.Log($"{transform.name} activated checkpoint {checkpoint.transform.name}, index {checkpoint.index} vs current: {currentCheckpoint}");
        if (checkpoint.index == currentCheckpoint)
        {
            if (checkpoint.index == 0)
            {
                Debug.Log("FINISHED");
                if (currentLap == 3)
                {
                    SceneManager.LoadScene(SceneToLoad);
                    // logic for end game & scoring.
                }
                lapText.text = "LAPS: " + currentLap + "/3";
                currentLap++;
            }
            else if (checkpoint.isLastCheckpoint)
            {
                currentCheckpoint = 0;
            }
            else
            {
                currentCheckpoint++;
            }
        }
    }



    public int getPlace() 
    { 
        return place; 
    }
}
