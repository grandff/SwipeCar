using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 스와이프 길이를 구해줌
        if(Input.GetMouseButtonDown(0)){
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }else if(Input.GetMouseButtonUp(0)){
            // 마우스 버튼에서 손가락을 떼었을 때
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            // 스와이프 길이를 처음 속도로 변경함
            this.speed = swipeLength / 1000.0f;

            // 효과음 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        /*      초기 소스
        
        if(Input.GetMouseButtonDown(0)){        // 마우스를 클릭하면
            this.speed = 0.2f;                  // 처음 속도 설정

            
            //    Translate는 현재 지점에서 해당 방향으로 수치만큼 이동하는 거임. 해당 좌표로 이동하는게 아님.
            
            transform.Translate(this.speed, 0, 0);  

            this.speed *= 0.98f;        // 속도 감소
        }
        */
    }
}
