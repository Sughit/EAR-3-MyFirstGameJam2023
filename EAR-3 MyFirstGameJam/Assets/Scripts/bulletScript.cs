using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
     AudioSource poc;
     public float circleRange;
     EnemyScript enemyScript;
     public Transform varf;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Object.Destroy(gameObject, 3.0f);
        PentruDetectare();
    }


    public void PentruDetectare()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(varf.position, circleRange))
        {
                if(enemyScript = collider.GetComponent<EnemyScript>())
                {
                    enemyScript.TakeDamage(20);
                    Destroy(gameObject);
                    
                }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 position = varf.position;
        Gizmos.DrawWireSphere(position, circleRange);
    }

    
}
