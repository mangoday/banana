using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력을 받아 총알을 발사한다.
// 1. 사용자의 입력으로 Fire1 (mouse left, left ctrl)
//   를 사용한다.
// 2. 공장에 주문을 넣어 총알을 만든다.
// 3. 만들어진 총알을 위치 시킨다.

// 필요한 컴포넌트를 강제로 삽입 시킬때 사용한다.
//[RequireComponent(typeof(Rigidbody))]
public class PlayerFire : MonoBehaviour {
    // 총알 공장 주소 저장을 위한 변수
    public GameObject bulletPrefab;
    
    // firespawn 이라는 객체
    public GameObject fireSpawn;

    // 총알을 사용하기위한 배열
    public int bulletPoolSize = 10;
    GameObject []bulletPool;

    //int[] score = { 0, 1, 2, 3 };
    // Bullet 의 비활성화 목록
    //[HideInInspector]
    public static List<GameObject> listDeactive = 
        new List<GameObject>();


	// Use this for initialization
	void Start () {
        // 미리 총알을 Pool size 만큼 만들어 놓는다.
        // 비활성화 시켜놓고 필요할때 활성화 시킨다.

        // 반복하여 배열에 값을 세팅
        // For (while)
        // for (변수초기값설정; 조건; 증감분 )
        // {
        //      기능(반복하여 처리할 일)
        //      반복을 끝내고 싶을때 break 를 사용
        //      break;
        // }
        // bulletPoolSize 만큼의 Gameobject 를 저장할 수 있는
        // 배열을 새로 만든다.
        bulletPool = new GameObject[bulletPoolSize];

        // 비활성화 객체 저장을 위한 리스트 생성
        //listDeactive = new List<GameObject>();
        
        // 총알 Pool 에 총알을 하나씩 넣는 과정
        for (int i=0; i < bulletPoolSize; i++)
        {
            // Bullet 을 하나 생성한다.
            GameObject bullet = Instantiate(bulletPrefab);
            // 비활성화 시켜놓는다.
            bullet.SetActive(false);

            //자료형 [] 변수;
            //변수[인덱스] = 값;
            // 1번 bullet 만들어 저장
            bulletPool[ i ] = bullet;
            // 2번 비활성화 객체 저장
            listDeactive.Add(bullet);
        }        
	}
	
	// Update is called once per frame
	void Update () {
        if (GM.isGameStart == false)
        {
            return;
        }

        // 1. 사용자의 입력으로 Fire1 (mouse left, left ctrl)
        //   를 사용한다.
        if (Input.GetButtonDown("Fire1"))
        {
            // 목록에 값이 있는지 조사
            if (listDeactive.Count > 0)
            {
                GameObject bullet = listDeactive[0];
                // 목록에서 0번째 제거
                listDeactive.RemoveAt(0);

                bullet.SetActive(true);
                bullet.transform.position = fireSpawn.transform.position;
            }
        }
    }
}
