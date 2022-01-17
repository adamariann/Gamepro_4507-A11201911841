using UnityEngine;
using System.Collections;
 
public class RotateEnemyNmove : MonoBehaviour {
 
    public Transform target;
    public float turnSpeed = 5.0f;
    public float speed = 3.0f;
   
    public Vector3 _dir;
   
   
    void Start () {
        target = GameObject.FindWithTag("Player").transform;
    }
   
    void Update () {
        if(target){
            _dir = target.position - GetComponent<Rigidbody>().position;
            _dir.Normalize();
            Debug.Log (_dir);
        }
    }
   
    void FixedUpdate() {
        GetComponent<Rigidbody>().AddForce(_dir * speed);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_dir), turnSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}