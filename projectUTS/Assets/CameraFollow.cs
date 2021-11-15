using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;
	[Range(1,10)]
	public float smooth;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Follow();
    }

    // Update is called once per frame
    void Follow()
    {
        Vector3 targetposition = target.position+offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position,targetposition,smooth*Time.fixedDeltaTime);
        transform.position=smoothposition;
    }
}
