using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour{

    public float zureY; 

    void Update() {
        transform.Translate(0, -0.1f, 0);
        if (transform.position.y < -zureY) {
            transform.position = new Vector3(0, zureY, 0);
        }
    }
}