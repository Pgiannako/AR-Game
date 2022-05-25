using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.y < -20.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        }
    }
}
