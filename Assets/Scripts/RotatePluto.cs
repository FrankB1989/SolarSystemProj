using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePluto : MonoBehaviour {

    public Transform target;
    public int speed;

    private Vector3 angle;

    // Use this for initialization
    void Start () {
		if(target==null)
        {
            target = this.gameObject.transform;
        }
        angle.x = target.transform.up.x;
        angle.y = 45;
        angle.z = 45;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(target.transform.position, angle, speed * Time.deltaTime);
	}
}
