using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTransBack : MonoBehaviour
{


    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage2; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage3; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    void Start()
    {
        RecordScore.text = "得分：" + AG2Instance.RecordScore;


        if (AG2Instance.FinalScoreForAG2 >= 60 && AG2Instance.FinalScoreForAG2 < 90)
        {
            buttonImage.sprite = chosenSprite;
        }
        else if (AG2Instance.FinalScoreForAG2 == 90)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
        }
        else if (AG2Instance.FinalScoreForAG2 == 100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
            buttonImage3.sprite = chosenSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
