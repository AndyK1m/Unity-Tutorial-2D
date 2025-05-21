using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj; // 큐브 게임오브젝트를 가져오고 싶음

    public string changeName;
    void Start()
    {
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }

}
