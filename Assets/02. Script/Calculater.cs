using UnityEngine;

public class Calculater : MonoBehaviour
{
    public int number1, number2; // 멤버변수 (필드)
    void Start()
    {
        int addResult = Addmethod(); // 함수 호출
        int minusResult = Minusmethod();
        Debug.Log($"addResult : {addResult}, MinusResult {minusResult}");
        // Minusmethod(); // 함수 호출
        
        Debug.Log(Addmethod());
        Debug.Log(Minusmethod());
    }

    // 얘네들은 호출 안하면 실행 안됨
    int Addmethod()
    {
        int result = number1 + number2;
        // 지역변수 - 함수라는 지역에 있는 변수임
        // 지역변수 result 는 생명주기가 여기까지임
        return result; 
    }

    int Minusmethod()
    {
        int result = number1 - number2;
        return result;
    }
}
