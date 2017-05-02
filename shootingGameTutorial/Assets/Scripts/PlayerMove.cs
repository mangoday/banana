using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 하고 싶은것
// 1. 사용자의 입력을 받아서 움직이는 동작을 구현
//  - 어떤 키를 눌러야 하는가?
//  - 어느 방향으로 움직일 수 있는가?
//  - 어디까지 움직일 수 있는가?
//  - 얼마나 빨라야 하는가?

// 2. Fire 입력을 받아서 총쏘기 구현

public class PlayerMove : MonoBehaviour {

    public float speed = 5;

    float pixelPerUnit = 0;
    float meter;
    // Use this for initialization
    void Start () {
        pixelPerUnit = 
            (Camera.main.orthographicSize *2) / Screen.height;

        meter = (pixelPerUnit * Screen.width) * 0.5f;

	}
	
	// Update is called once per frame
	void Update () {
        if (GM.isGameStart == false)
        {
            return;
        }

        // -1 ~ +1 사이의 값을 반환
        float hDir = Input.GetAxis("Horizontal");
        float vDir = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * hDir + Vector3.up * vDir;
        // 벡터의 크기를 1로 만들어준다.
        // 원본이 변함
        //dir.Normalize();
        // 물체를 이동시킨다.
        transform.Translate(dir.normalized * speed * Time.deltaTime);

        // 만약 Player 가 -6.5 ~ +6.5 를 벗어나면?
        // -6.5 작아지면? -6.5, +6.5 커지면? 6.5
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -meter, meter);
        pos.y = Mathf.Clamp(pos.y, -Camera.main.orthographicSize,
            Camera.main.orthographicSize);
        //if (pos.x < -6.5f)
        //{
        //    pos.x = -6.5f;
        //}
        //if( pos.x > 5.5f)
        //{
        //    pos.x = 5.5f;
        //}

        transform.position = pos;

    }
}







