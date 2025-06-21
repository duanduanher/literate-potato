using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveTrigger : MonoBehaviour
{
	InteractiveTips system;

	public DialogueData_SO currentData;


	[Header("�Ƿ�������")]
	public bool EnableInteraction = true;

	private bool canTalk = false;

	[SerializeField]
	private bool isInteract;//�Ƿ�Ϊ���������Ի����������������ײ�������Զ������Ի���



	private void Awake()
	{
		system = GameObject.Find("InteractiveSystem").GetComponent<InteractiveTips>();
	}

	private void Update()
	{
		if (canTalk && !isInteract && EnableInteraction)
		{
			OpenDialogue();
			canTalk = false;
		}

		if (canTalk && isInteract && EnableInteraction && Input.GetKeyDown(KeyCode.E))
		{
			OpenDialogue();
		}
	}

	private void OpenDialogue()
	{
		//InputDeviceDetection.GameplayUIController.Instance.UpdateMainDialogue(currentData.dialoguePieces[0]);
		DialogueUI.Instance.UpdateDialogue(currentData);
		DialogueUI.Instance.UpdateMainDialogue(currentData.dialoguePieces[0]);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(gameObject.name + "�Ӵ�����" + other.name);
		if (other.CompareTag("Player") && currentData != null)
		{
			canTalk = true;
			if (system != null)
			{
				system.StartInteracting(gameObject);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("Exit");
		if (other.CompareTag("Player"))
		{
			canTalk = false;
			if (system != null)
			{
				system.StopInteracting();
			}
		}
	}

}
