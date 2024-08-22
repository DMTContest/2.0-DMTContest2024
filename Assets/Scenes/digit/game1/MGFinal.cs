using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine.UI;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MGFinal : MonoBehaviour
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

    private int clickCount=0;
    public float FS;

    public bool IfFirstTime  = true;




    // Start is called before the first frame update
    void Start()
    {
        IfFirstTime = MG1Instance.FirstTime;
        HideAllUIElements(ChufenQian);
        HideAllUIElements(Chufen);
        HidePanel(DefenPanel);
        HidePanel(MedalPanel);
        JS.text = (MG1Instance.Jcorrect*10 - (MG1Instance.JWR1 +MG1Instance.JWR2 +MG1Instance.JWR3)*10).ToString();
        MS.text = (MG1Instance.Mcorrect*10 - (MG1Instance.MWR1 +MG1Instance.MWR2 +MG1Instance.MWR3)*10).ToString();
        HS.text = (MG1Instance.Hcorrect*10 - (MG1Instance.HWR1 +MG1Instance.HWR2 +MG1Instance.HWR3 + MG1Instance.HWR4)*10).ToString();
        JR.text = MG1Instance.Jcorrect.ToString();
        MR.text = MG1Instance.Mcorrect.ToString();
        HR.text = MG1Instance.Hcorrect.ToString();  
        JW.text = (MG1Instance.JWR1+MG1Instance.JWR2+MG1Instance.JWR3).ToString();
        MW.text = (MG1Instance.MWR1+MG1Instance.MWR2+MG1Instance.MWR3).ToString();
        HW.text = (MG1Instance.HWR1+MG1Instance.HWR2+MG1Instance.HWR3+MG1Instance.HWR4).ToString();  
        GameDateNow.text = DateTime.Now.ToString();
        FS = 
           MG1Instance.Jcorrect*10 - (MG1Instance.JWR1 +MG1Instance.JWR2 +MG1Instance.JWR3)*10
        +  MG1Instance.Mcorrect*10 - (MG1Instance.MWR1 +MG1Instance.MWR2 +MG1Instance.MWR3)*10
        +  MG1Instance.Hcorrect*10 - (MG1Instance.HWR1 +MG1Instance.HWR2 +MG1Instance.HWR3 + MG1Instance.HWR4)*10;
        
        FinalScore.text= FS.ToString();
        Defen.text = " 你的训练得分" + "\n" + "达到" + FS.ToString() + "分了！";
        if (FS >= 60 && FS < 80)
        {
            Medal.text = "胡萝卜奖牌";
            GlobalStorage.instance.CarrotMedal += 1;
        }
        else if (FS >= 80 && FS < 100)
        {
            Medal.text = "兔兔勋章";
            GlobalStorage.instance.TutuMedal += 1;

        }
        else if (FS == 100)
        {
            Medal.text = "兔兔勋章";
            GlobalStorage.instance.TutuMedal += 1;

        }
        else
        {
            Medal.text = "胡萝卜奖牌";
            GlobalStorage.instance.CarrotMedal += 1;

        }

    }   

    // Update is called once per frame
    void Update()
    {
        if(IfFirstTime==true){
        if (Input.GetMouseButtonDown(0)) // 检查左键点击
        {
            clickCount++; // 增加点击计数器
            if(clickCount==1){
                ShowAllUIElements(ChufenQian);
            }else if(clickCount==2){
                HideAllUIElements(ChufenQian);
                ShowAllUIElements(Chufen);
            }else if(clickCount==3){
                ShowPanel(DefenPanel);
            }else if(clickCount==4){
                HidePanel(DefenPanel);
                ShowPanel(MedalPanel);
            }
        }}else {ShowAllUIElements(Chufen);}
    }

    [SerializeField]List<GameObject> ChufenQian = new List<GameObject>();
    [SerializeField]List<GameObject> Chufen = new List<GameObject>();

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
    [SerializeField]public Text Defen;
    [SerializeField] GameObject MedalPanel;
    [SerializeField]public Text Medal;

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

    public void Yindao(){
        HidePanel(MedalPanel);
        SceneManager.LoadScene("YindaoFinalMain");
    }

}
