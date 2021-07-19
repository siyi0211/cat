using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush : MonoBehaviour
{
  /*  Vector2 moveDir;
    public LayerMask detectLayer;
        private Vector2 speedX = new Vector2(1, 0);
    private Vector2 speedY = new Vector2(0, 1);
    public Rigidbody2D rb2D;

    GameObject box;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            moveDir = Vector2.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            moveDir = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDir = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDir = Vector2.down;
        }

        if(moveDir != Vector2.zero)
        {
            if(MoveDir(moveDir))
            {
                Move(moveDir);
            }
        }

        moveDir = Vector2.zero;
    }

    bool MoveDir(Vector2 dir)
    {
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 1f, detectLayer);

        if (!hit)
        {
            Debug.Log(" player No hited");
            return true;
        }
        else
        {
            Debug.Log("box hited");
            if (hit.collider.GetComponent<box>() != null)
                return hit.collider.GetComponent<box>().MoveDir(dir);
        }

        return false;
    }

    void Move(Vector2 dir)
    {
        transform.Translate(dir);
    }

    */
}


