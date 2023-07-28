using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    private float angle;
    private Rigidbody2D rb;
    private Vector2 movement;
    public GameObject sunet;
    public float ammo=30;
    public GameObject armaInamic;
    

    


    public float moveSpeed;
    float moveSpeed2;
     GameObject player;
    public Transform shotPoint;
    public Transform gun;
 
    public GameObject enemyProjectile;
 
    public float followPlayerRange;
    public bool inRange;
    public float attackRange;
 
    public float startTimeBtwnShots;
    private float timeBtwnShots;
    Transform target;
    Vector2 moveDirection;
 
    [SerializeField]
    private LayerMask obstaclesLayerMask;
    
    void Awake()
    {
        player = GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player");
        moveSpeed2=moveSpeed;
    }
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        target= player.transform;
    }
    

    // Update is called once per frame
    void Update()
    {
        Vector3 differance = (player.transform.position - gun.transform.position).normalized;
        float rotZ = Mathf.Atan2(differance.y, differance.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, differance.normalized, followPlayerRange, obstaclesLayerMask);
        Debug.DrawRay(transform.position, differance * followPlayerRange, Color.magenta);
        Debug.Log(hit.collider);
 
        if (Vector2.Distance(transform.position, player.transform.position) <= followPlayerRange)
        {
            if(hit.collider == null)
            {
                inRange = true;
            }
        }
        else
        {
            inRange = false;
        }
 
        if (Vector2.Distance(transform.position, player.transform.position) <= attackRange)
        {
            if(hit.collider == null)
            {
                if (timeBtwnShots <= 0)
                {
                    if(ammo>0)
                    {
                        Instantiate(enemyProjectile, shotPoint.position, shotPoint.transform.rotation);
                        timeBtwnShots = startTimeBtwnShots;
                        Instantiate(sunet);
                        ammo--;
                    } else 
                    {
                        StartCoroutine(Reload());
                    
                    }
                }
                else
                {
                    timeBtwnShots -= Time.deltaTime;
                }
            }
        }

                if(inRange)
                {Vector3 direction = (target.position - transform.position).normalized;
                float angle =Mathf.Atan2(direction.y, direction.x) *Mathf.Rad2Deg;
                rb.rotation = angle;
                moveDirection = direction;}

                if(Vector2.Distance(transform.position, player.transform.position) < attackRange)
                {
                    moveSpeed=0;
                }else moveSpeed=moveSpeed2;



    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(2);
        ammo=30;
        
    }    

    IEnumerator CuloareDamage()
    {
        yield return new WaitForSeconds(1F);
    }

    void FixedUpdate()
    {
        if (inRange)
        {
                       
            
            if(target)
            {
                
                rb.velocity = new Vector2 (moveDirection.x, moveDirection.y) * moveSpeed;
            }
            
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }
        else rb.velocity = Vector3.zero;
    }
 
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, followPlayerRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
