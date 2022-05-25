using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoal : MonoBehaviour
{
    public ResultConditions resultScript;

    void Start()
    {
        resultScript.Initialise();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
            resultScript.LoseCondition();
        }
        Destroy(player.gameObject);
    }
}