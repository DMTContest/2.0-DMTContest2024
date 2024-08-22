using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine.UI;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AG3Final : MonoBehaviour
{
    [SerializeField] private Text JS;
    [SerializeField] private Text MS;
    [SerializeField] private Text HS;
    [SerializeField] private Text JR;
    [SerializeField] private Text JW;
    [SerializeField] private Text MR;
    [SerializeField] private Text MW;
    [SerializeField] private Text HR;
    [SerializeField] private Text HW;
    [SerializeField] private Text GameDateNow;
    [SerializeField] private Text FinalScore;

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
        JS.text = (AG3Instance.Jcorrect * 10 - (AG3Instance.JWR1 + AG3Instance.JWR2 + AG3Instance.JWR3) * 10).ToString();
        MS.text = (AG3Instance.Mcorrect * 10 - (AG3Instance.MWR1 + AG3Instance.MWR2 + AG3Instance.MWR3) * 10).ToString();
        HS.text = (AG3Instance.Hcorrect * 10 - (AG3Instance.HWR1 + AG3Instance.HWR2 + AG3Instance.HWR3 + AG3Instance.HWR4) * 10).ToString();
        JR.text = AG3Instance.Jcorrect.ToString();
        MR.text = AG3Instance.Mcorrect.ToString();
        HR.text = AG3Instance.Hcorrect.ToString();
        JW.text = (AG3Instance.JWR1 + AG3Instance.JWR2 + AG3Instance.JWR3).ToString();
        MW.text = (AG3Instance.MWR1 + AG3Instance.MWR2 + AG3Instance.MWR3).ToString();
        HW.text = (AG3Instance.HWR1 + AG3Instance.HWR2 + AG3Instance.HWR3 + AG3Instance.HWR4).ToString();
        GameDateNow.text = DateTime.Now.ToString();
        FS =
           AG3Instance.Jcorrect * 10 - (AG3Instance.JWR1 + AG3Instance.JWR2 + AG3Instance.JWR3) * 10
        + AG3Instance.Mcorrect * 10 - (AG3Instance.MWR1 + AG3Instance.MWR2 + AG3Instance.MWR3) * 10
        + AG3Instance.Hcorrect * 10 - (AG3Instance.HWR1 + AG3Instance.HWR2 + AG3Instance.HWR3 + AG3Instance.HWR4) * 10;

        FinalScore.text = FS.ToString();
        Defen.text = " 你的训练得分" + "\n" + "达到" + FS.ToString() + "分了！";
        if (FS >= 60 && FS < 80)
        {
            Medal.text = "鱼鱼奖牌";
            GlobalStorage.instance.FishMedal += 1;
        }
        else if (FS >= 80 && FS < 100)
        {
            Medal.text = "熊熊勋章";
            GlobalStorage.instance.BearMedal += 1;

        }
        else if (FS == 100)
        {
            Medal.text = "熊熊勋章";
            GlobalStorage.instance.BearMedal += 1;

        }
        else
        {
            Medal.text = "鱼鱼奖牌";
            GlobalStorage.instance.FishMedal += 1;

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

    public void Yindao()
    {
        HidePanel(MedalPanel);
        SceneManager.LoadScene("YindaoFinalMain");
    }

}
