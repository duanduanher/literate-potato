using UnityEngine;

public class ExitOnEsc : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // 可选：保持跨场景存在
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("退出游戏");
        }
    }
}
