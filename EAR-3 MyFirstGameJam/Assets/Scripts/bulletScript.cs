using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
     AudioSource poc;
     public float circleRange;
     ViataEnemy enemyScript;
     public Transform varf;
    public int damage;
    public static int damageBoost = 40;

    private damageBoost boost;

    void Awake()
    {
        boost = GameObject.Find("cardEffectsManager").GetComponent<damageBoost>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Object.Destroy(gameObject, 3.0f);
        if(boost.isBoost)
        {
            DamageBoost();
        }
        else
        {
            PentruDetectare();
        }
    }

    


    void PentruDetectare()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(varf.position, circleRange))
        {
                if(enemyScript = collider.GetComponent<ViataEnemy>())
                {
                    enemyScript.TakeDamage(damage);
                    Destroy(gameObject);
                    
                }
        }
    }

    public void DamageBoost()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(varf.position, circleRange))
        {
                if(enemyScript = collider.GetComponent<ViataEnemy>())
                {
                    enemyScript.TakeDamage(damageBoost);
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
