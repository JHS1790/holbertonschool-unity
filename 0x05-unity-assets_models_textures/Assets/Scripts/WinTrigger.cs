using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider player) 
    {
        if (player.name.Equals("Player"))
            player.GetComponent<Timer>().haveWon = true;
    }
}
