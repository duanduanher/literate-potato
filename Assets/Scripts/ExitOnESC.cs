using UnityEngine;

public class ExitOnEsc : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // ��ѡ�����ֿ糡������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("�˳���Ϸ");
        }
    }
}
