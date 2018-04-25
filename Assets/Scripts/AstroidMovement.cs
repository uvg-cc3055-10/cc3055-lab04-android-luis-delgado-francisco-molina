using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {
    CircleCollider2D cc;
    public GameObject go;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <=-5.5)
        {
            Destroy(go);
        }
    }
}
