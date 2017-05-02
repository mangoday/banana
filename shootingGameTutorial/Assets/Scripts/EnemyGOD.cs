using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정 시간이 되면 enemy 를 생성
// 필요한것?
//  - 일정 시간은??
//  - 생성위치 : enemygod 의 위치
//  - 생성할 적

public class EnemyGOD : MonoBehaviour {
    //  - 일정 시간은??
    public float createTime = 2;
    //  - enemy 의 공장 주소
    public GameObject enemyPrefab;

    float currentTime = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 만약에 isGameStart true 일때 아래 내용 실행 
        if(GM.isGameStart == false)
        {
            return;
        }


        currentTime = currentTime + Time.deltaTime;
        // 만약 currentTime 이 createTime 보다 커지면?
        if (currentTime > createTime)
        {
            currentTime = 0;
            // enemy 생성
            // 2. 공장에 주문을 넣어 총알을 만든다.
            GameObject enemy = Instantiate(enemyPrefab);
            // 3. 만들어진 총알을 위치 시킨다.
            enemy.transform.position = transform.position;
                //+ Vector3.right * Random.Range(-4.0f, 4.0f);

            // 4. enemy 의 부모를 지정한다.
            enemy.transform.parent = transform;

        }
	}
}
