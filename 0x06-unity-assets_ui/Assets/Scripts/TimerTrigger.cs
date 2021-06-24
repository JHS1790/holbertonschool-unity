using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private void OnTriggerExit(Collider player) 
    {
        if (player.name.Equals("Player"))
            player.GetComponent<Timer>().enabled = true;
    }
}
