using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInFront : MonoBehaviour
{
    [SerializeField] private Transform rootTr;
    Vector3 offset;

    private void Start()
    {
        offset = new Vector3(0, 0, -1.5f);
    }

    private void Update()
    {
        transform.position = rootTr.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
            FindObjectOfType<RootMove>().IsValidMove(false);
        }

    }
}
