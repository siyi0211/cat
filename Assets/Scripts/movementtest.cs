using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movementtest : MonoBehaviour
{
    private Vector2 speedX = new Vector2(10, 0);
    private Vector2 speedY = new Vector2(0, 10);
    public Rigidbody2D rb2D;
    public LayerMask whatStopMovement;
    public LayerMask spikeMask;
    public Transform movePoint;
    public Vector2 toMove;
    public bool dead;
   

    public Animator animator;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!dead)
        {
            if (Input.GetKeyDown("left"))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                toMove = Vector2.left;
                toMoveFunction(toMove);
            }
            else if (Input.GetKeyDown("right"))
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                toMove = Vector2.right;
                toMoveFunction(toMove);
            }
            else if (Input.GetKeyDown("up"))
            {
                toMove = Vector2.up;
                toMoveFunction(toMove);
            }
            else if (Input.GetKeyDown("down"))
            {
                toMove = Vector2.down;
                toMoveFunction(toMove);
            }

            if (toMove != Vector2.zero)
            {
                if (toMoveFunction(toMove))
                {
                    Move(toMove);
                }

                RaycastHit2D hitspike = Physics2D.Raycast(rb2D.position, toMove, 10f, spikeMask);
                if (hitspike)
                {
                    animator.SetBool("isDead", true);
                    dead = true;
                    Invoke("GameOver", 2);
                }
            }

            toMove = Vector2.zero;
        }
       
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }


    void Move(Vector2 dir)
    {
        if (toMove == Vector2.left)
        {
            rb2D.MovePosition(rb2D.position - speedX);
        }
        else if (toMove == Vector2.right)
        {

            rb2D.MovePosition(rb2D.position + speedX);
        }
        else if (toMove == Vector2.up)
        {
            rb2D.MovePosition(rb2D.position + speedY);
        }
        else if (toMove == Vector2.down)
        {
            rb2D.MovePosition(rb2D.position - speedY);
        }

    }

    bool toMoveFunction(Vector2 dir)
    {
        RaycastHit2D hitWall = Physics2D.Raycast(rb2D.position, dir, 10f, whatStopMovement);

        if (!hitWall.collider)
        {
            return true;
        }
        else
        {
            if (hitWall.collider.GetComponent<box>() != null)
                return hitWall.collider.GetComponent<box>().checkBoxHitCollider(dir);
        }
        return false;
    }

    

}
