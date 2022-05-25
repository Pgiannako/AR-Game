using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showdeaths : MonoBehaviour
{

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Start()
    {
        if(scoring.totalDeaths == 0)
        {
            text.text = $"You died {scoring.totalDeaths} times, what a god! ";
        }
        else if(scoring.totalDeaths < 6)
        {
            text.text = $"You died {scoring.totalDeaths} times , that's pretty good :)";
        }
        else if(scoring.totalDeaths > 5)
        {
            text.text = $"You died {scoring.totalDeaths} times , that's not bad!";
        }
        
    }

}
