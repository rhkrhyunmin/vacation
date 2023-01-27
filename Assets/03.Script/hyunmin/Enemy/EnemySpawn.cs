using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    float currTime;
    public GameObject Monster;

    // �ݺ��Ǵ� �۾��̹Ƿ� ������Ʈ �Լ� �ȿ��� �ڵ带 �Է��Ѵ�.
    void Update()
    {
        // �ð��� �帣�� ������ش�.
        currTime += Time.deltaTime;

        // ������Ʈ�� ���ʸ��� ������ ������ ���ǹ����� �����. ���⼭�� 10�ʷ� �ߴ�.
        if (currTime > 10)
        {
            // x,y,z ��ǥ���� ���� �ٸ� �������� �����ϰ� ���������� �������.
            float newX = Random.Range(-10f, 10f), newY = Random.Range(-3.3f, -3.3f);

            // ������ ������Ʈ�� �ҷ��´�.
            GameObject monster = Instantiate(Monster);

            // �ҷ��� ������Ʈ�� �����ϰ� ������ ��ǥ������ ��ġ�� �ű��.
            monster.transform.position = new Vector3(newX, newY);

            // �ð��� 0���� �ǵ����ָ�, 10�ʸ��� �ݺ��ȴ�.
            currTime = 0;
        }
    }
}
