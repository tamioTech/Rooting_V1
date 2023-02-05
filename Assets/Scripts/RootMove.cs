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
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!validMove) { return; }
            lastPos = rootCreatorTr.position;

            GameObject rootPiece = Instantiate(rootMid, lastPos, Quaternion.identity);

            moveDir = new Vector3(0, 1f, 0);
            RotatePiece("up");
            transform.position += moveDir;
            //animator.SetTrigger("rootMove");
        }


        if (Input.GetKeyDown(KeyCode.A))
        {   
            if (!validMove) { return; }
            lastPos = rootCreatorTr.position;

            Instantiate(rootMid, lastPos, Quaternion.EulerAngles(0,0,90));

            moveDir = new Vector3(-1, 0, 0);

            RotatePiece("left");

            transform.position += moveDir;
           // animator.SetTrigger("rootMove");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!validMove) { return; }
            lastPos = rootCreatorTr.position;
=======
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
>>>>>>> Josh

            Instantiate(rootMid, lastPos, Quaternion.identity);

            moveDir = new Vector3(0, -1, 0);
            RotatePiece("down");
<<<<<<< HEAD
            transform.position += moveDir;
            //animator.SetTrigger("rootMove");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!validMove) { return; }
            lastPos = rootCreatorTr.position;

            Instantiate(rootMid, lastPos, Quaternion.identity);

            moveDir = new Vector3(1, 0, 0);
            RotatePiece("right");
            transform.position += moveDir;

            //animator.SetTrigger("rootMove");
=======
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
>>>>>>> Josh
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
<<<<<<< HEAD

    public void MoveBack()
    {
        if (hasMoved) { return; }

        rootCreatorTr.position += (moveDir * -1);
        hasMoved = true;

    }

    public void IsValidMove(bool isValid)
    {
        validMove = isValid;
    }

    public bool GetIsValid()
    {
        return validMove;
    }

    public Vector3 GetMoveDir()
    {
        return moveDir;
    }

    public Vector3 GetLastPos()
    {
        return lastPos;
    }


=======
>>>>>>> Josh
}
