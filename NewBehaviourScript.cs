using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {
         public float speed;
	  public Rigidbody rb;
		
		 public float jumpforce=11f;
		
		 public bool ground=true;
		
			
	// Use this for initialization
	public void Start () {
		 rb = GetComponent<Rigidbody>();
		
             speed=1f;
			 
		
	} public void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="Terrain" || col.gameObject.name=="Plane" ||transform.position.y<=1){
			ground=true;
		}
	}
             
	
	
	// Update is called once per frame
	void Update () {
		
	
		if(Input.GetButtonDown("Jump") && ground){
            rb.AddForce(Vector3.up*1200);
		ground=false	;}
		transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis("Vertical")*Time.deltaTime);}}
	

