using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour {
    // 따라다닐 녀석 지정
    public GameObject target;
    public float speed = 4;
	
	// Update is called once per frame
	void Update () {
        // target 을 따라다니는 기능을 구현
        // 1. Tail -> Target 으로 향하는 Vector 구하기
        //  - vDir = Target - Tail
        Vector3 vDir = target.transform.position - transform.position;
        vDir.Normalize();
        transform.Translate(vDir * speed * Time.deltaTime);
	}
}
