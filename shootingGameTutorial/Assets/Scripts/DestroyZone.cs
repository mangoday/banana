using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 내 영역에 들어오는 녀석은 다 없앤다.
public class DestroyZone : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        // 만약 총알이면 비활성화
        if (other.gameObject.name.Contains("Bullet"))
        {
            other.gameObject.SetActive(false);
            // 비활성화 목록에 추가
            // 필요한 정보
            //  - 비활성화 목록
            //  1. Player 를 찾아야 한다.    
            //GameObject player = GameObject.Find("Player");
            //  2. PlayerFire 찾아오기
            //PlayerFire pf = player.GetComponent<PlayerFire>();
            PlayerFire.listDeactive.Add(other.gameObject);
        }
        else
        {
            // 그렇지 않으면 Destroy
            Destroy(other.gameObject);
        }
         
    }
}
