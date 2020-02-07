using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour {
    public GameObject player;
    public float moveSpeed = 0.1f;

    public GameObject view;
    Quaternion target;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) == true) { 
            target = Quaternion.Euler(view.transform.rotation.x, 0, view.transform.position.z);
            player.transform.rotation = Quaternion.Slerp(transform.rotation, target, 100);
            //player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
