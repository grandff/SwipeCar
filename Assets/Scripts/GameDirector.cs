using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // UI를 사용하는데 필요함

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        /*
            Find : 오브젝트 명을 인수로 전달하고 인수명이 게임 씬 안에 있으면 해당 오브젝트 반환
        */
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;          // 게임 오브젝트의 좌푤르 구해서 거리를 계산

        // 깃발을 지나친 경우 게임 오버 표시
        if (length >= 0){
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }else{
            this.distance.GetComponent<Text>().text = "게임 오바";
        }

        /*
            자신 이외의 오브젝트 컴포넌트에 접근하는 방법
            1) Find 메서드로 오브젝트를 찾음
            2) GetComponent 메서드로 오브젝트의 컴포넌트를 구함
            3) 컴포넌트를 가진 데이터에 접근
        */
        
    }
}
