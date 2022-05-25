using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOffLevelCheck : MonoBehaviour
{

    public ResultConditions resultScript;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -200.0f)
        {
            resultScript.LoseCondition();
        }
    }
}
