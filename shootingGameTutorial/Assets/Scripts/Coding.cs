using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour {

    // 자료형 변수 = 값;
    public int number1 = 234;
    public int number2 = 312;

    // Use this for initialization
    void Start () {
        int result = Sum(10, 20);
        print(result);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 두개값을 입력 받아 정수형 
    // 덧셈 결과를 반환
    int Sum(int num1, int num2)
    {
        int result = num1 + num2;

        return result;
    }
}
