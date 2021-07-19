using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    private Vector2 speedX = new Vector2(5, 0);
    private Vector2 speedY = new Vector2(0, 5);
    public LayerMask whatStopMovement;

    public bool checkBoxHitCollider(Vector2 dir)
    {
        
        //3.9-4.8,4.8
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 5f, whatStopMovement);

        if (!hit)
        {
            
            if (dir == Vector2.left)
            {
                transform.Translate(-speedX);
            }
            else if (dir == Vector2.right)
            {
                transform.Translate(speedX);
            }
            else if (dir == Vector2.up)
            {
                transform.Translate(speedY);
            }
            else if (dir == Vector2.down)
            {
                transform.Translate(-speedY);
            }
            return true;
        }
        else
        {
            //OnTriggerEnter(hit.collider);
            return false;
        }

    }
    /*
    bool OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        return false;
    }*/

}
