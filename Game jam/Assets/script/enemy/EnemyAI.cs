using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   
    public Vector2 pos1;
    public Vector2 pos2;
    public float leftrightspeed;
    private float oldPosition;

    public float distance;

    private Transform target;
    public float followspeed;


    private Animator anim;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Enemymove();
    }

    void Enemymove()
    {
        {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * leftrightspeed, 1.0f));
            if (transform.position.x > oldPosition)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            if (transform.position.x < oldPosition)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }

            oldPosition = transform.position.x;



        }
    }


    void EnemyAi()
    {
        RaycastHit2D hitEnemy = Physics2D.Raycast(transform.position, -transform.right, distance);

        if (hitEnemy.collider != null)
        {
            Debug.DrawLine(transform.position, hitEnemy.point, Color.gray);
            


        }
        else
        {
            Debug.DrawLine(transform.position, transform.position - transform.right * distance, Color.pink);
            

        }


    }
}









    