using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveTips : MonoBehaviour
{
    [SerializeField, Header("����ָʾ")]
    TextMeshProUGUI Tips;

    private void Awake()
    {
        if(Tips != null)
		    Tips.enabled = false;
    }

	#region APIs
	public void StartInteracting(GameObject obj)
    {
        if(obj != null)
        {
            Debug.Log("���ڽӴ�" + obj.name);
            if(Tips != null)
            {
				Tips.enabled = true;
			}
            else
            {
                Debug.Log("Tipsû����");
            }
		}
    }

	public void StopInteracting()
    {
		if (Tips != null)
			Tips.enabled = false;
	}
	#endregion

}
