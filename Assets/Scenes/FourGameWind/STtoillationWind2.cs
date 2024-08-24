using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoillationWind2 : MonoBehaviour
{
    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage2; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage3; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    void Start()
    {
        RecordScore.text = "得分：" + GG2Instance.RecordScore;

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
