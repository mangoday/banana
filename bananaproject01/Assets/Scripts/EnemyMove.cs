using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//c#의 관행스인듯
//class의 이름이다. 대문자로 시작.
public class EnemyMove : MonoBehaviour {

    public float speed = 5;
    //변수는 기본적으로 소문자.

    //기능은 대문자.
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
