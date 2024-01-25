using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private RaceManager rm;
    public int index;
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
        //Debug.Log($"{transform.name} triggered by {other.name}");
        Player p = other.GetComponent<Player>();
        if (p != null)
        {
            Debug.Log($"PLAYER DETECTED by {transform.name}");
            p.checkPointActivated(this);
        }
    }
}
