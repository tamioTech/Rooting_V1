using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootTip : MonoBehaviour
{
    [SerializeField] private Transform rootTr;

    RootMove rootMove;


    private void Start()
    {
        rootMove = new RootMove();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
            print(FindObjectOfType<RootMove>().GetLastPos());
            rootTr.position = FindObjectOfType<RootMove>().GetLastPos();
            return;
        }


        Destroy(other.gameObject);
    }
}
