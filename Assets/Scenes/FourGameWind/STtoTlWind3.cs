using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoTlWind3 : MonoBehaviour
{
    [SerializeField] private Text RecordScore;
    [SerializeField] private Image buttonImage; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage2; // 用于更改Sprite的Image组件
    [SerializeField] private Image buttonImage3; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    void Start()
    {
        Debug.Log("来");
        RecordScore.text = "得分：" + TG3Instance.RecordScore;

        if (TG3Instance.FinalScoreForFG1 >= 60 && TG3Instance.FinalScoreForFG1 < 80)
        {
            buttonImage.sprite = chosenSprite;
        }
        else if (TG3Instance.FinalScoreForFG1>=80&& TG3Instance.FinalScoreForFG1<100)
        {
            buttonImage.sprite = chosenSprite;
            buttonImage2.sprite = chosenSprite;
        }
        else if (TG3Instance.FinalScoreForFG1 == 100)
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
