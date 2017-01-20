using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_1 : MonoBehaviour {

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}


    void Move()   {
        Debug.Log("Moveメソッド");
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveX, moveY);


    }


}
