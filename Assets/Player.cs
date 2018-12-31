using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"), //cuidado con las mayusculas y minisculas
            Input.GetAxisRaw("Vertical"),
            0
            );//movientos de teclado
        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            speed * Time.deltaTime
            );

    }
}
