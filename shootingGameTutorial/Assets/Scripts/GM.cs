using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {
    public float startTime = 5;
    float currentTime;

    public static bool isGameStart = false;
	
	
	// Update is called once per frame
	void Update () {
        if (isGameStart == false)
        {
            currentTime += Time.deltaTime;

            if (currentTime > startTime)
            {
                isGameStart = true;
            }
        }
    }
}
