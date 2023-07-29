using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadeExplode : MonoBehaviour
{
    ViataEnemy enemyScript;
    public float timeToExplode;
    public float range;
    public GameObject particule;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeGrenade());
    }

    IEnumerator ExplodeGrenade()
    {
        yield return new WaitForSeconds(timeToExplode);
        Debug.Log("grenade exploded");
        particule.SetActive(true);
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(transform.position, range))
        {
                if(enemyScript = collider.GetComponent<ViataEnemy>())
                {
                    enemyScript.TakeDamage(40);
                    Destroy(this.gameObject);
                }
        }
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);

        yield return null;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 position = transform.position;
        Gizmos.DrawWireSphere(position, range);
    }
}
