using System.Globalization;
using UnityEngine;

public class Study_Class
{
    public int number;
    //생성자 : 생성될 때 실행되는 함수
    public Study_Class(int number)
    //int 라는 매개변수를 넣었기 때문에 Class 를 찾을 때 이녀석을 찾음
    {
        this.number = number;
    }
}

public struct Study_Struct

{
    public int number;

    //
    public Study_Struct(int number)
    {
        this.number = number;
    }
}


public class Study_ClassStruct : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Class ------------------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        // 같다가 아니라 할당했다임
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
        //                10이 나와야 함  얘도 10이 나와야 함
        
        c1.number = 100;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
        
        Debug.Log("struct------------------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
        
        s1.number = 100;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
    }
   
}
