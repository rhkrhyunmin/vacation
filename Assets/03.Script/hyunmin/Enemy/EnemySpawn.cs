using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    float currTime;
    public GameObject Monster;

    // 반복되는 작업이므로 업데이트 함수 안에서 코드를 입력한다.
    void Update()
    {
        // 시간이 흐르게 만들어준다.
        currTime += Time.deltaTime;

        // 오브젝트를 몇초마다 생성할 것인지 조건문으로 만든다. 여기서는 10초로 했다.
        if (currTime > 10)
        {
            // x,y,z 좌표값을 각각 다른 범위에서 랜덤하게 정해지도록 만들었다.
            float newX = Random.Range(-10f, 10f), newY = Random.Range(-3.3f, -3.3f);

            // 생성할 오브젝트를 불러온다.
            GameObject monster = Instantiate(Monster);

            // 불러온 오브젝트를 랜덤하게 생성한 좌표값으로 위치를 옮긴다.
            monster.transform.position = new Vector3(newX, newY);

            // 시간을 0으로 되돌려주면, 10초마다 반복된다.
            currTime = 0;
        }
    }
}
