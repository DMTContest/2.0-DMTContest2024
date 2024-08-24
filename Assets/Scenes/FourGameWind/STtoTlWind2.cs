using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoTlWind2 : MonoBehaviour
{
    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage2; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage3; // ���ڸ���Sprite��Image���
    [SerializeField] private Sprite chosenSprite; // ѡ��״̬�µ�Sprite
    void Start()
    {
        RecordScore.text = "�÷֣�" + TG2Instance.RecordScore;

        if (TG2Instance.FinalScoreForJG1 >= 60 && TG2Instance.FinalScoreForJG1 < 80)
        {
            buttonImage.sprite = chosenSprite;
        }
        else if (TG2Instance.FinalScoreForJG1 >=80&& TG2Instance.FinalScoreForJG1<100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
        }
        else if (TG2Instance.FinalScoreForJG1 == 100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
            buttonImage3.sprite = chosenSprite;
        }

        //MG1Instance.DestroyInstance();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
