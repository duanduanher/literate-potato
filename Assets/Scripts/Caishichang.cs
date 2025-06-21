using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caishichang : MonoBehaviour
{
    public Button b1, b2, b3;       //蔬菜三选一
    public Button b4, b5, b6;       //肉类三选一
    
    public bool IsClicked = false;
    public DialogueData_SO DS1,DS2,DS3,DS4;
    public Image zhenban,market,meal;

    private int num = 1;
    // Start is called before the first frame update
    private void Awake()
    {
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        b3.gameObject.SetActive(false);
        b4?.gameObject.SetActive(false);
        b5?.gameObject.SetActive(false);
        b6?.gameObject.SetActive(false);
        
        zhenban.gameObject.SetActive(false);
        meal.gameObject.SetActive(false);
    }

   
    void Start()
    {
        if (AudioController.Instance != null)
        {
            AudioController.Instance.PlayMusic("c2");
        }
        else
        {
            Debug.LogError("AudioController.Instance is null! Please make sure AudioController is in the scene and Awake() has been called.");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueUI.Instance.endFlag)
        {
            if(IsClicked)
            {
                num++;
                IsClicked = false;
            }

            switch(num)
            {
                case 1:
                    
                    b1.gameObject.SetActive(true);
                    b2.gameObject.SetActive(true);
                    b3.gameObject.SetActive(true);
                    break;
                case 2:
                    AudioController.Instance.AudioSwitch("n118", true);
                    DialogueUI.Instance.UpdateDialogue(DS1);
                    DialogueUI.Instance.UpdateMainDialogue(DS1.dialoguePieces[0]);
                    num++;
                    break;
                case 3:
                    b4.gameObject.SetActive(true);
                    b5.gameObject.SetActive(true);
                    b6.gameObject.SetActive(true);
                    break;
           

                case 4:
                    ProcessController.Instance.GoNextScene();
                    break;
                //    zhenban.gameObject.SetActive(true);
                //    market.gameObject.SetActive(false);
                //    DialogueUI.Instance.UpdateDialogue(DS3);
                //    DialogueUI.Instance.UpdateMainDialogue(DS3.dialoguePieces[0]);
                //    num++;
                //    break;
                //case 6:
                //    b7.gameObject.SetActive(true);
                //    break;
                //case 7:
                //    zhenban.gameObject.SetActive(false);
                //    meal.gameObject.SetActive(true);
                //    DialogueUI.Instance.UpdateDialogue(DS4);
                //    DialogueUI.Instance.UpdateMainDialogue(DS4.dialoguePieces[0]);
                //    num++;
                //    break;
                //case 8:
                //    ProcessController.Instance.GoNextScene();
                //    break;
            }
        }

        
    }

    public void ButtonOnclick()
    {
        IsClicked = true;
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        b3.gameObject.SetActive(false);
        b4.gameObject.SetActive(false);
        b5.gameObject.SetActive(false);
        b6.gameObject.SetActive(false);
       
        
    }

}