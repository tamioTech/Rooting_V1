using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInFront : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("tileInFront: " + other);
        if (other.tag == "rock")
        {
            FindObjectOfType<RootMove>().validMove = false;
        }

    }
}
