using UnityEngine;

//�ýű��洢�Ի����ݵ�����
[System.Serializable]
public class DialoguePiece
{
    public string ID;

    public Sprite image;

    public string speakerName;

    [TextArea]
    public string text;

    public bool isNpc;//�Ƿ�ΪNpc˵����Ӱ������λ�ã�

    public Sprite backgroundSprite;  // �öԻ��ı���ͼ

}
