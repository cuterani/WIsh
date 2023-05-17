/******
코드 작성 시 이런 식으로 누가 썼는 지 쓰세요
작성자 : 000
작성 일자 : 23.05.05
 ******/

using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    /// <summary>
    /// singleton 참고 자료
    /// https://tecoble.techcourse.co.kr/post/2020-11-07-singleton/
    /// </summary>
    static GameManager _instance = null;

    /// <summary>
    /// get, set 참고 자료
    /// https://novlog.tistory.com/entry/C-%EA%B3%A0%EA%B8%89%EB%AC%B8%EB%B2%95-1-%ED%94%84%EB%A1%9C%ED%8D%BC%ED%8B%B0Property-getset-%ED%95%A8%EC%88%98
    /// </summary>
    static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Init();
            return _instance;
        }
    }

    /// <summary>
    /// GameManager 최초 접근 시 초기화해주는 함수
    /// </summary>
    static void Init()
    {
        GameObject container = GameObject.Find("@GameManager");
        if (container == null)
            container = new GameObject { name = "@GameManager" };
        _instance = container.AddComponent<GameManager>();

        DontDestroyOnLoad(container);
    }
    #endregion Singleton

    #region Managers
    IngameManager _ingame = new IngameManager();
    public static IngameManager Ingame { get { return Instance._ingame; } }
    #endregion Managers
}
