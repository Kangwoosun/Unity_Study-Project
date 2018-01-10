using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject camera;
    private float speed = 0 ;

	void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.D)) {
            gameObject.transform.Translate(speed, 0, 0);
            speed += 0.01f;
         }
        if (Input.GetKey(KeyCode.A)) {
            gameObject.transform.Translate(-speed, 0, 0);
            speed += 0.01f;
        }
        if (Input.GetKey(KeyCode.W)) {
            gameObject.transform.Translate(0, 0, speed);
            speed += 0.01f;
        }
        if (Input.GetKey(KeyCode.S)) {
            gameObject.transform.Translate(0, 0, -speed);
            speed += 0.01f;
        }
        if (!Input.anyKey)
            speed = 0f;

        camera.transform.Rotate(-Input.GetAxis("Mouse Y"), 0f, 0f);
        gameObject.transform.Rotate(0f, Input.GetAxis("Mouse X"), 0f);
        if(Input.GetKeyDown(KeyCode.Space))
        gameObject.GetComponent<Rigidbody>().AddForce(0f, 5f, 0f,ForceMode.Impulse);
    }
}
