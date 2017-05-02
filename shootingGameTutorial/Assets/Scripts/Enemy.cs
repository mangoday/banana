using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed = 5;
    // 폭발 공장 주소 필요
    public GameObject explosionPefab;
    
    // 따라다닐 타겟 Player
    GameObject player;

    // 최순실 같은 전역변수.. 누구나 알수 있다.
    Vector3 dir;


    // Use this for initialization
    void Start () {
        // Scene 에 올라가있는 GameObject 중 이름이
        // Player 인 녀석을 찾는다.
        player = GameObject.Find("Player");

        
    }
	
	// Update is called once per frame
	void Update () {
        // 사는 동안 계속(매프레임) player 의 위치를 찾는다.
        dir = player.transform.position - transform.position;
        dir.Normalize();
        // 이동
        //transform.Translate(dir * speed * Time.deltaTime);
        // 회전
        transform.up = dir * -1;
        transform.position += dir * speed * Time.deltaTime;
  
    }



    // 충돌이 일어나면 나도 죽고 부딪힌 놈도 죽는다.
    // 죽을때 폭발 효과 발생
    // => 나의 위치에 폭발 위치 지정
    void OnCollisionEnter(Collision other)
    {
        // 죽을때 폭발 효과 발생
        GameObject explosion = Instantiate(explosionPefab);
        // => 나의 위치에 폭발 위치 지정
        explosion.transform.position = transform.position;

        // 나와 부딪힌 녀석을 없앤다.
        // 총알, 주인공
        // 만약 총알일 경우 앲애는게 아니라... 비활성화
        if (other.gameObject.name.Contains("Bullet"))
        {
            // 비활성화
            other.gameObject.SetActive(false);
            PlayerFire.listDeactive.Add(other.gameObject);
        }
        // 총알이 아닐경우는 없애기
        else
        {
            Destroy(other.gameObject);
        }
        // 나도 없앤다.
        Destroy(gameObject);        
    }
}
