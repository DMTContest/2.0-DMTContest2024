using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STtoAnalysisWind1 : MonoBehaviour
{
    [SerializeField]private Text RecordScore;    
    [SerializeField]private Image buttonImage; // 用于更改Sprite的Image组件
        [SerializeField]private Image buttonImage2; // 用于更改Sprite的Image组件
            [SerializeField]private Image buttonImage3; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    void Start()
    {
        RecordScore.text = "得分：" + InstanceAG11.RecordScore;
        
        if(InstanceAG11.FinalScoreForMG1>=60&& InstanceAG11.FinalScoreForMG1<90){
        buttonImage.sprite = chosenSprite;
        }else if(InstanceAG11.FinalScoreForMG1==90){
        buttonImage.sprite = chosenSprite;
        buttonImage2.sprite = chosenSprite;
        }else if(InstanceAG11.FinalScoreForMG1==100){
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
