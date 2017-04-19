using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//사용자의 입력을 받아 총알을 발사한다.
//1. 사용자의 입력으로 Fire1 (mouse left, left ctrl)를 사용한다.
//2. 공장에 주문을 넣어 총알을 만든다.
//3. 만들어진 총알을 위치시킨다. 


public class PlyerFire : MonoBehaviour {

    //총알 공장 주소 저장을 위한 변수
    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //사용자의 입력을 받아 총알을 발사한다.
        //1. 사용자의 입력으로 Fire1 (mouse left, left ctrl)를 사용한다.

        if (Input.GetButtonDown("Fire1"))
        {

            //2. 공장에 주문을 넣어 총알을 만든다.
            GameObject bullet = Instantiate(bulletPrefab);

            //3. 만들어진 총알을 위치시킨다. 
            bullet.transform.position = transform.position;


        }



    }
}
