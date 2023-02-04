using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootTip : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // print(collision.gameObject.name);
        print("collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger: " + other.tag);
        if (other.tag == "Rock")
        {
            FindObjectOfType<RootMove>().IsValidMove(false);
            return;
        }

        Destroy(other.gameObject);
    }
}
