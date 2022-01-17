using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	public GameObject fireball1;
	public Transform sp;
	public bool canShoot=true;
	/*[SeriaizeField] private float cooldown;
	private Animator animator;
	private PlayerMove playermove;
	private float cooldowntmr=Mathf.Infinity;*/
    // Start is called before the first frame update
/*    void Start()
    {
        animator=GetComponent<Animator>();
        playermove=GetComponent<PlayerMove>();
    }
*/
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown("q")){
        	shoot();

        }
    }
    void shoot(){
    	if(!canShoot)
    		return;
    	GameObject si = Instantiate(fireball1,sp);
    	si.transform.parent=null;

    }
}
