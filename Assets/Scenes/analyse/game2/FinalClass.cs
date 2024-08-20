using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine.UI;
using System.Data;
using UnityEngine;

public class FinalClass : MonoBehaviour
{   
    [SerializeField]private Text JS;
    [SerializeField]private Text MS;
    [SerializeField]private Text HS;
    [SerializeField]private Text JR;
    [SerializeField]private Text JW;
    [SerializeField]private Text MR;
    [SerializeField]private Text MW;
    [SerializeField]private Text HR;
    [SerializeField]private Text HW;
    [SerializeField]private Text GameDateNow;
    [SerializeField]private Text FinalScore;

    private int clickCount = 0;
    public float FS;

    public bool IfFirstTime = true;


    // Start is called before the first frame update
    void Start()
    {

        IfFirstTime = AG3Instance.FirstTime;
        HideAllUIElements(ChufenQian);
        HideAllUIElements(Chufen);
        HidePanel(DefenPanel);
        HidePanel(MedalPanel);

        JS.text = "+"+(AG2Instance.Jcorrect*10 - (AG2Instance.JWR1 +AG2Instance.JWR2 +AG2Instance.JWR3)*4).ToString();
        MS.text = "+"+(AG2Instance.Mcorrect*10 - (AG2Instance.MWR1 +AG2Instance.MWR2 +AG2Instance.MWR3)*6).ToString();
        HS.text = "+"+(AG2Instance.Hcorrect*10 - (AG2Instance.HWR1 +AG2Instance.HWR2 +AG2Instance.HWR3 + AG2Instance.HWR3)*8).ToString();
        JR.text = AG2Instance.Jcorrect.ToString();
        MR.text = AG2Instance.Mcorrect.ToString();
        HR.text = AG2Instance.Hcorrect.ToString();  
        JW.text = (AG2Instance.JWR1+AG2Instance.JWR2+AG2Instance.JWR3).ToString();
        MW.text = (AG2Instance.MWR1+AG2Instance.MWR2+AG2Instance.MWR3).ToString();
        HW.text = (AG2Instance.HWR1+AG2Instance.HWR2+AG2Instance.HWR3+AG2Instance.HWR4).ToString();  
        GameDateNow.text = DateTime.Now.ToString();
        FS = 
        AG2Instance.Jcorrect*10 - (AG2Instance.JWR1+AG2Instance.JWR2+AG2Instance.JWR3)*4+ AG2Instance.Mcorrect*10 - (AG2Instance.MWR1+AG2Instance.MWR2+AG2Instance.MWR3)*6+ AG2Instance.Hcorrect*10 - (AG2Instance.HWR1+AG2Instance.HWR2+AG2Instance.HWR3+AG2Instance.HWR4)*8;
        FinalScore.text = FS.ToString();

        Defen.text = " 你的训练得分" + "\n" + "达到" + FS.ToString() + "分了！";
        if (FS >= 60 && FS < 90)
        {
            Medal.text = "铜奖牌";
        }
        else if (FS >= 90 && FS < 100)
        {
            Medal.text = "银奖牌";
        }
        else if (FS == 100)
        {
            Medal.text = "金奖牌";
        }
        else
        {
            Medal.text = "入门奖牌";
        }
    }   

    // Update is called once per frame
    void Update()
    {
        if (IfFirstTime == true)
        {
            if (Input.GetMouseButtonDown(0)) // 检查左键点击
            {
                clickCount++; // 增加点击计数器
                if (clickCount == 1)
                {
                    ShowAllUIElements(ChufenQian);
                }
                else if (clickCount == 2)
                {
                    HideAllUIElements(ChufenQian);
                    ShowAllUIElements(Chufen);
                }
                else if (clickCount == 3)
                {
                    ShowPanel(DefenPanel);
                }
                else if (clickCount == 4)
                {
                    HidePanel(DefenPanel);
                    ShowPanel(MedalPanel);
                }
            }
        }
        else
        {

            //ShowAllUIElements(ChufenQian);
            if (Input.GetMouseButtonDown(0)) // 检查左键点击
            {
                //HideAllUIElements(ChufenQian);
                ShowAllUIElements(Chufen);
            }
        }
    }

    [SerializeField] List<GameObject> ChufenQian = new List<GameObject>();
    [SerializeField] List<GameObject> Chufen = new List<GameObject>();

    public void HideAllUIElements(List<GameObject> ChufenQian)
    {
        foreach (GameObject element in ChufenQian)
        {
            element.SetActive(false);
        }
    }

    public void ShowAllUIElements(List<GameObject> ChufenQian)
    {
        foreach (GameObject element in ChufenQian)
        {
            element.SetActive(true);
        }
    }

    [SerializeField] GameObject DefenPanel;
    [SerializeField] public Text Defen;
    [SerializeField] GameObject MedalPanel;
    [SerializeField] public Text Medal;

    // 隐藏 Panel
    public void HidePanel(GameObject DefenPanel)
    {
        DefenPanel.SetActive(false);
    }

    // 显示 Panel
    public void ShowPanel(GameObject DefenPanel)
    {
        DefenPanel.SetActive(true);
    }
}
