using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class glontInamic : MonoBehaviour
{
    public float bulletSpeed;
    public float lifeTime;
    public float circleRange;
    public Transform varf;
    ViataPlayer ViataPlayer;
 
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    void Update()
    {
        Detectare();
    }

    void Detectare()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(varf.position, circleRange))
        {
                if(ViataPlayer = collider.GetComponent<ViataPlayer>())
                {
                    ViataPlayer.NuMaiDaCaMaDoare(10);
                    Destroy(gameObject);
                }
        }
    }
 
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }
 
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 position = varf.position;
        Gizmos.DrawWireSphere(position, circleRange);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
                Destroy(gameObject);
        }
    }
}