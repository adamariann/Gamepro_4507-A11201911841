using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballitem : MonoBehaviour
{
	public float speedfb,score;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(transform.right*transform.localScale.x*speedfb*Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag=="Player")
        return;
        if(coll.GetComponent<shootingact>())
        	coll.GetComponent<shootingact>().Action();
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D colll){
      

	if(colll.gameObject.tag=="Enemy"){

        	 Destroy(colll.gameObject);
        	 
    

	  	}
	
	}

}
