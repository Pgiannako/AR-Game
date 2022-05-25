using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_despawn : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -30.0f)
        {
            Destroy(gameObject);
        }
    }
}
