using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMove : MonoBehaviour
{
    public GameObject rootTip;
    public GameObject rootMid;
    public Transform rootCreatorTr;

    public Collider tileUp;
    public Collider tileDown;
    public Collider tileLeft;
    public Collider tileRight;

    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {  // Up
            
            if (tileUp != null && tileUp.tag == "Rock")
                return;

            RotatePiece("up");
            transform.position += new Vector3(0, 1, 0);
            animator.SetTrigger("rootMove");
        }
        else if (Input.GetKeyDown(KeyCode.S)) {  // Down            
            
            if (tileDown != null && tileDown.tag == "Rock")
                return;

            RotatePiece("down");
            transform.position += new Vector3(0, -1, 0);
            animator.SetTrigger("rootMove");
        }
        else if (Input.GetKeyDown(KeyCode.A)) {  // Left 
            
            if (tileLeft != null && tileLeft.tag == "Rock")
                return;

            RotatePiece("left");
            transform.position += new Vector3(-1, 0, 0);
            animator.SetTrigger("rootMove");
        }
        if (Input.GetKeyDown(KeyCode.D)) {  // Right
            
            if (tileRight != null && tileRight.tag == "Rock")
                return;

            RotatePiece("right");
            transform.position += new Vector3(1, 0, 0);
            animator.SetTrigger("rootMove");
        }

    }

    private void RotatePiece(string tipDir)
    {
        switch (tipDir)
        {
            case "left":
                rootTip.transform.rotation = Quaternion.Euler(0, 0, -90);
                break;
            case "right":
                rootTip.transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case "up":
                rootTip.transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case "down":
                rootTip.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
        }
    }
}
