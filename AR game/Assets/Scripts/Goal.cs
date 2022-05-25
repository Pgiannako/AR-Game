using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public ResultConditions resultScript;
    
    void Start()
    {
        resultScript.Initialise();
    }

    void OnTriggerEnter (Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
            resultScript.WinCondition();
        }
        else if (player.gameObject.tag == "Respawn")
        {
            Destroy(player.gameObject);
            resultScript.LoseCondition();
        }
        Destroy(player.gameObject);


    }

}
