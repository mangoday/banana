using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 하고 싶은 것
// - 배경이 스크롤 되도록 하자
public class BG : MonoBehaviour {

    // 화면에 재질을 이용하여 물체를 그리는 역할
    MeshRenderer mr;
    public float scrollSpeed = 0.2f;

	// Use this for initialization
	void Start () {
        // 해당 오브젝트에 붙어있는 컴포넌트를 가져오는 방법
        mr = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called on ce per frame
	void Update () {
        mr.material.mainTextureOffset += 
            Vector2.up * scrollSpeed * Time.deltaTime;        
	}
}
