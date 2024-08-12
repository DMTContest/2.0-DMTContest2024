using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoDigitWind : MonoBehaviour
{
    [SerializeField]private Text RecordScore;    
    [SerializeField]private Image buttonImage; // 用于更改Sprite的Image组件
        [SerializeField]private Image buttonImage2; // 用于更改Sprite的Image组件
            [SerializeField]private Image buttonImage3; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    void Start()
    {
        RecordScore.text = "得分：" + MG1Instance.RecordScore;
        
        if(MG1Instance.FinalScoreForMG1>=60&&MG1Instance.FinalScoreForMG1<90){
        buttonImage.sprite = chosenSprite;
        }else if(MG1Instance.FinalScoreForMG1==90){
        buttonImage.sprite = chosenSprite;
        buttonImage2.sprite = chosenSprite;
        }else if(MG1Instance.FinalScoreForMG1==100){
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
