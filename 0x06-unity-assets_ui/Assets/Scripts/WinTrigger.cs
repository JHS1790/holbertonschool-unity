using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider player) 
    {
        if (player.name.Equals("Player"))
        {
            player.GetComponent<Timer>().haveWon = true;
        }
    }
}
