using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadeExplode : MonoBehaviour
{
    ViataEnemy enemyScript;
    public float timeToExplode;
    public float range;
    public GameObject particule;
    public static float damage = 40f;
    public AudioSource sunetExplozie;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeGrenade());
    }

    IEnumerator ExplodeGrenade()
    {
        yield return new WaitForSeconds(timeToExplode);
        sunetExplozie.Play(0);
        Debug.Log("grenade exploded");
        particule.SetActive(true);
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(transform.position, range))
        {
                if(enemyScript = collider.GetComponent<ViataEnemy>())
                {
                    enemyScript.TakeDamage(damage);
                }
        }
        
        yield return new WaitForSeconds(1f);
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
