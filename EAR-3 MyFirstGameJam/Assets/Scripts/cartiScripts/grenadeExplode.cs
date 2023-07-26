using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadeExplode : MonoBehaviour
{
    EnemyScript enemyScript;
    public float timeToExplode;
    public float range;
    private bool exploded;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeGrenade());
    }

    IEnumerator ExplodeGrenade()
    {
        yield return new WaitForSeconds(timeToExplode);
        Debug.Log("grenade exploded");
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(transform.position, range))
        {
                if(enemyScript = collider.GetComponent<EnemyScript>())
                {
                    enemyScript.TakeDamage(40);
                    exploded = true;
                    Destroy(this.gameObject);
                }
        }
        if(exploded)
        {
            Destroy(this.gameObject);
        }

        yield return null;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 position = transform.position;
        Gizmos.DrawWireSphere(position, range);
    }
}
