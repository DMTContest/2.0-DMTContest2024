using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoillationWind2 : MonoBehaviour
{
    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage2; // ���ڸ���Sprite��Image���
    [SerializeField] private Image buttonImage3; // ���ڸ���Sprite��Image���
    [SerializeField] private Sprite chosenSprite; // ѡ��״̬�µ�Sprite
    void Start()
    {
        RecordScore.text = "�÷֣�" + GG2Instance.RecordScore;

        if (GG2Instance.FinalScoreForYG2 >= 60 && GG2Instance.FinalScoreForYG2 < 80)
        {
            buttonImage.sprite = chosenSprite;
        }
        else if (GG2Instance.FinalScoreForYG2 >=80 && GG2Instance.FinalScoreForYG2 <100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
        }
        else if (GG2Instance.FinalScoreForYG2 == 100)
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
