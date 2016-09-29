using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {


    private int velocity;

    void Start ()
    {
        velocity = 5;

	}
	void Update ()
    {
       float x =  Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
       float z=  Input.GetAxis("Vertical") * velocity * Time.deltaTime;

        transform.Translate(x,0,z);

    }
}
