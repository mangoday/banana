using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.up * speed * Time.deltaTime);

        //벡터를 컨트롤하기 좋아서 이걸 주로 쓴다.
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
