using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float speedwalk=1f,score;
	Animator animator;
	Rigidbody2D rb;
	const float GroundcheckRadius=0.2f;
	[SerializeField] LayerMask groundLayer;
	[SerializeField] Transform groundcheckcoll;
	[SerializeField] bool isGrounded=false;
	[SerializeField] float jumpForce=200;
	float horizontalMove;
	bool flipright=true;
	bool jump;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    	animator.SetFloat("yvelocity",rb.velocity.y);
        horizontalMove=Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        if(Input.GetButtonDown("Jump")){
        	animator.SetBool("jump",true);
        	jump=true;

        }
        else if(Input.GetButtonUp("Jump")){
        	jump=false;
        }
        

    }
    void FixedUpdate()
    {
    	Groundcheckk();
        Move(horizontalMove,jump);
    }
    void Groundcheckk()
    {
    	isGrounded=false;
       Collider2D[] colliders =Physics2D.OverlapCircleAll(groundcheckcoll.position,GroundcheckRadius,groundLayer);
       if(colliders.Length > 0)
       		isGrounded=true;
       animator.SetBool("jump",isGrounded);
    }
    void Move(float dir,bool jumpflag){
    	 if(isGrounded && jumpflag){
    	 	isGrounded=false;
    	 	jumpflag=false;
        	rb.AddForce(new Vector2(0f,jumpForce));
        }
        float xvalue = dir*100*speedwalk*Time.fixedDeltaTime;
        /*rb.velocity= new Vector2(xvalue,rb.velocity.y);*/
        Vector2 target=new Vector2(xvalue,rb.velocity.y);
        rb.velocity=target;
        if(flipright && dir <0){
        	transform.localScale = new Vector3(-3,3,3);
        	flipright=false;
        }
        else if(!flipright && dir >0){
        	transform.localScale = new Vector3(3,3,3);
        	flipright=true;
        }
    }
     void OnGUI(){
        GUI.color=Color.white;
        GUILayout.Label("Score: "+score.ToString());
    }
    public void IncreaseScore() {
         score++;
         }
}
