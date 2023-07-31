using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashExplode : MonoBehaviour
{
    EnemyScript enemyScript;
    wanderingAI enemyWander;
    public float timeToExplode;
    public static float flashedTime = 3f;
    public float range;
    public GameObject particule;
    public AudioSource sunetExplozie;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeFlash());
    }

    IEnumerator ExplodeFlash()
    {
        yield return new WaitForSeconds(timeToExplode);
        sunetExplozie.Play(0);
        Debug.Log("flash exploded");
        particule.SetActive(true);
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(transform.position, range))
        {
            enemyWander = collider.GetComponent<wanderingAI>();
                if(enemyScript = collider.GetComponent<EnemyScript>())
                {
                    enemyWander.enabled = false;
                    enemyScript.enabled = false;
                    StartCoroutine(Flashed());
                }
                
        }
        yield return new WaitForSeconds(0.5f);
        particule.SetActive(false);
        yield return null;
    }

    IEnumerator Flashed()
    {
        yield return new WaitForSeconds(flashedTime);
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(transform.position, range))
        {
            enemyWander = collider.GetComponent<wanderingAI>();
                if(enemyScript = collider.GetComponent<EnemyScript>())
                {
                    enemyWander.enabled = true;
                    enemyScript.enabled = true;
                }
        }
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 position = transform.position;
        Gizmos.DrawWireSphere(position, range);
    }
}
