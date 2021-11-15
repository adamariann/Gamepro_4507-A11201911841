using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballdead : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D colll){
      

	if(colll.gameObject.tag=="Fireball"){
		FindObjectOfType<PlayerMove>().IncreaseScore();
        	  Destroy(colll.gameObject);

	  	}
}
}
