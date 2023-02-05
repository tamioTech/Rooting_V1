using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootTip : MonoBehaviour
{
    [SerializeField] private Transform rootTr;

    RootMove rootMove;
    Animator animator;
    bool isRock;

    private void Start()
    {
        rootMove = new RootMove();
        animator = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Rock")
        {
            rootTr.position = FindObjectOfType<RootMove>().GetLastPos();
            return;
        }

        Destroy(other.gameObject);
        //animator.SetTrigger("tileDestroy");

    }
}
