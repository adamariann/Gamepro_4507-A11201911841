using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
	public float speed,lineofsite;
	private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position,transform.position);
        if(distanceFromPlayer<lineofsite)
        {
        	transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);
        	if (transform.position.x > player.position.x)
            {
                transform.localScale = new Vector2(-3, 3);
            }
            else if (transform.position.x < player.position.x)
            {
                transform.localScale = new Vector2(3, 3);
            }
   		}
    }
    private void OnDrawGizmosSelected(){
        	Gizmos.color=Color.green;
        	Gizmos.DrawWireSphere(transform.position,lineofsite);
   		}
   	private void OnCollisionEnter2D(Collision2D col)
 {
       if (col.gameObject.name == "Player")
         Destroy (col.gameObject);
         SceneManager.LoadScene("Menu");
     		Debug.Log ("Destroyed");
 }
 }	

