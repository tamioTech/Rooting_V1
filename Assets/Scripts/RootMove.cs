using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMove : MonoBehaviour
{
    [SerializeField] private GameObject rootTip;
    [SerializeField] private GameObject rootMid;
    [SerializeField] private Transform rootCreatorTr;

    bool movedToNewTile;
    bool validMove;
    string tipDir;

    Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        movedToNewTile = false;
        validMove = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!validMove) { return; }
            RotatePiece("up");
            transform.position += new Vector3(0, 1f, 0);
            
            animator.SetTrigger("rootMove");

            //transform.Rotate(Vector3.right * 90f);
            //Instantiate(rootMid, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //if (!validMove) { return; }
            RotatePiece("left");
            transform.position += new Vector3(-1, 0, 0);
            //tipDir = "left";
            animator.SetTrigger("rootMove");
            //Instantiate(rootMid, transform.position, Quaternion.EulerRotation(0,0,90f));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!validMove) { return; }
            RotatePiece("down");
            transform.position += new Vector3(0, -1, 0);
            animator.SetTrigger("rootMove");
            //Instantiate(rootMid, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!validMove) { return; }
            RotatePiece("right");
            transform.position += new Vector3(1, 0, 0);

            animator.SetTrigger("rootMove");
            //Instantiate(rootMid, transform.position, Quaternion.EulerRotation(0, 0, 90f));
        }

    }

    private void RotatePiece(string tipDir)
    {
        switch (tipDir)
        {
            case "left":
                transform.rotation = Quaternion.Euler(0, 0, -90);
                break;
            case "right":
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case "up":
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case "down":
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
        }
    }

    public void IsValidMove(bool isValid)
    {
        validMove = isValid;
    }



}
