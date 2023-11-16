using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private RaceManager rm;
    public int count;
    public bool isLastCheckpoint = false;

    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RaceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();
        if (p != null)
        {
              p.checkPointActivated(this);
        }
    }
}
