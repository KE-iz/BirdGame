using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed = 3;
    public float size = 19.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);      // translate 화면을 움직인다 , Time.deltatime 업데이트가 불린 다음 다음 업데이트 불릴 때까지 시간 텀
        
        if (transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    
    }
}
