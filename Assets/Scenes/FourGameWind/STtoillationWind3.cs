using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoillationWind3 : MonoBehaviour
{
    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage2; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage3; // ���ڸ���Sprite��Image���
    [SerializeField] private Sprite chosenSprite; // ѡ��״̬�µ�Sprite
    void Start()
    {
        RecordScore.text = "�÷֣�" + GG3Instance.RecordScore;

        if (GG3Instance.FinalScoreForPG1 >= 60 && GG3Instance.FinalScoreForPG1 < 80)
        {
            buttonImage.sprite = chosenSprite;
        }
        else if (GG3Instance.FinalScoreForPG1 >=80&& GG3Instance.FinalScoreForPG1 <100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
        }
        else if (GG3Instance.FinalScoreForPG1 == 100)
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
