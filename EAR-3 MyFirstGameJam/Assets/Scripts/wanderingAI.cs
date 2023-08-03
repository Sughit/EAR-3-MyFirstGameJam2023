using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;


public class wanderingAI : MonoBehaviour

{

    public float moveSpeed = 3f;

    public float rotSpeed = 100f;



    private bool isWandering = false;

    private bool isRotatingLeft = false;

    private bool isRotatingRight = false;

    private bool isWalking = false;

    EnemyScript enemyScript;

    Rigidbody2D rb;

    // [SerializeField]
    // private LayerMask obstaclesLayerMask;

    void Start()
    {
        enemyScript = this.GetComponent<EnemyScript>();
         rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()

    {
        if(enemyScript.inRange==false)
 {
        // RaycastHit2D hitWalls = Physics2D.Raycast(transform.position, Vector3.forward, 1, obstaclesLayerMask);
        // Debug.DrawRay(transform.position, Vector3.forward, Color.magenta);
        // if(hitWalls.collider != null)
        // {
        //     isRotatingRight = true;
        // }
        
        if (isWandering == false)

        {

            StartCoroutine(Wander());

        }

        if (isRotatingRight == true)

        {
            transform.Rotate(transform.forward * Time.deltaTime * rotSpeed, Space.World);

        }

        if (isRotatingLeft == true)

        {

            transform.Rotate(transform.forward * Time.deltaTime * -rotSpeed, Space.World);

        }

        if (isWalking == true)

        {

            transform.position += transform.right * moveSpeed * Time.deltaTime;

        }
 }
    }



    IEnumerator Wander()

    {

        int rotTime = Random.Range(1, 3);

        int rotateWait = Random.Range(1, 3);

        int rotateLorR = Random.Range(1, 2);

        int walkWait = Random.Range(1, 5);

        int walkTime = Random.Range(1, 5);

        if(enemyScript.inRange==false)
{
        isWandering = true;



        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        if (rotateLorR == 1)

        {

            isRotatingRight = true;

            yield return new WaitForSeconds(rotTime);

            isRotatingRight = false;

        }

        if (rotateLorR == 2)

        {

            isRotatingLeft = true;

            yield return new WaitForSeconds(rotTime);

            isRotatingLeft = false;

        }

        isWandering = false;
}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isWandering = false;
        rb.velocity = Vector3.zero;
    }

}