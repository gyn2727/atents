using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    float dist = 2.5f;
    public Vector3 dir = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //����2.5���� �ö� �ڿ� �ٽ� �����ڸ��� ���ƿ��°� �ݺ��ϰ� ���弼��

        //transform.position = transform.position + dir * Time.deltaTime;
        float delta = Time.deltaTime;
        if (dist - delta <= 0.0f)
        {
            delta = dist;
            dist = 2.5f;
            dir = -dir;
        }
        dist -= delta;
        transform.Translate(dir * delta, Space.World);

        transform.Rotate(dir * 360.0f * Time.deltaTime, Space.World);
    }
}
