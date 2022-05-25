using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowdownHazard : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.drag = 5;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.drag = 0;
        }
    }

}
