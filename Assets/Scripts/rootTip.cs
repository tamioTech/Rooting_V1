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
        print(other.tag);
        if (other.tag == "Rock")
        {
            rootTr.position = FindObjectOfType<RootMove>().GetLastPos();
            return;
        }

        Destroy(other.gameObject);
        switch (other.tag)
        {
            case "Dirt":
                animator.SetTrigger("tileDestroy");
                break;
            case "Water":
               
                animator.SetTrigger("getWater");
                print("getWater");
                break;

        }

    }
}
