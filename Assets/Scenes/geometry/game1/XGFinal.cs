using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class XGFinal : MonoBehaviour
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
        IfFirstTime = GG1Instance.FirstTime;
        HideAllUIElements(ChufenQian);
        HideAllUIElements(Chufen);
        HidePanel(DefenPanel);
        HidePanel(MedalPanel);
        JS.text = (GG1Instance.Jcorrect * 10 - (GG1Instance.JWR1 + GG1Instance.JWR2 + GG1Instance.JWR3) * 10).ToString();
        MS.text = (GG1Instance.Mcorrect * 10 - (GG1Instance.MWR1 + GG1Instance.MWR2 + GG1Instance.MWR3) * 10).ToString();
        HS.text = (GG1Instance.Hcorrect * 10 - (GG1Instance.HWR1 + GG1Instance.HWR2 + GG1Instance.HWR3 + GG1Instance.HWR4) * 10).ToString();
        JR.text = GG1Instance.Jcorrect.ToString();
        MR.text = GG1Instance.Mcorrect.ToString();
        HR.text = GG1Instance.Hcorrect.ToString();
        JW.text = (GG1Instance.JWR1 + GG1Instance.JWR2 + GG1Instance.JWR3).ToString();
        MW.text = (GG1Instance.MWR1 + GG1Instance.MWR2 + GG1Instance.MWR3).ToString();
        HW.text = (GG1Instance.HWR1 + GG1Instance.HWR2 + GG1Instance.HWR3 + GG1Instance.HWR4).ToString();
        GameDateNow.text = DateTime.Now.ToString();
        FS =
           GG1Instance.Jcorrect * 10 - (GG1Instance.JWR1 + GG1Instance.JWR2 + GG1Instance.JWR3) * 10
        + GG1Instance.Mcorrect * 10 - (GG1Instance.MWR1 + GG1Instance.MWR2 + GG1Instance.MWR3) * 10
        + GG1Instance.Hcorrect * 10 - (GG1Instance.HWR1 + GG1Instance.HWR2 + GG1Instance.HWR3 + GG1Instance.HWR4) * 10;

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

    public void Yindao()
    {
        HidePanel(MedalPanel);
        SceneManager.LoadScene("YindaoFinalMain");
    }

}
