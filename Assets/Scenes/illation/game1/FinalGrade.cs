using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine.UI;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGrade : MonoBehaviour
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
        IfFirstTime = TG1Instance.FirstTime;
        HideAllUIElements(ChufenQian);
        HideAllUIElements(Chufen);
        HidePanel(DefenPanel);
        HidePanel(MedalPanel);
        JS.text = (TG1Instance.Jcorrect * 10 - (TG1Instance.JWR1 + TG1Instance.JWR2 + TG1Instance.JWR3) * 10).ToString();
        MS.text = (TG1Instance.Mcorrect * 10 - (TG1Instance.MWR1 + TG1Instance.MWR2 + TG1Instance.MWR3) * 10).ToString();
        HS.text = (TG1Instance.Hcorrect * 10 - (TG1Instance.HWR1 + TG1Instance.HWR2 + TG1Instance.HWR3 + TG1Instance.HWR4) * 10).ToString();
        JR.text = TG1Instance.Jcorrect.ToString();
        MR.text = TG1Instance.Mcorrect.ToString();
        HR.text = TG1Instance.Hcorrect.ToString();
        JW.text = (TG1Instance.JWR1 + TG1Instance.JWR2 + TG1Instance.JWR3).ToString();
        MW.text = (TG1Instance.MWR1 + TG1Instance.MWR2 + TG1Instance.MWR3).ToString();
        HW.text = (TG1Instance.HWR1 + TG1Instance.HWR2 + TG1Instance.HWR3 + TG1Instance.HWR4).ToString();
        GameDateNow.text = DateTime.Now.ToString();
        FS =
           TG1Instance.Jcorrect * 10 - (TG1Instance.JWR1 + TG1Instance.JWR2 + TG1Instance.JWR3) * 10
        + TG1Instance.Mcorrect * 10 - (TG1Instance.MWR1 + TG1Instance.MWR2 + TG1Instance.MWR3) * 10
        + TG1Instance.Hcorrect * 10 - (TG1Instance.HWR1 + TG1Instance.HWR2 + TG1Instance.HWR3 + TG1Instance.HWR4) * 10;

        FinalScore.text = FS.ToString();
        Defen.text = " ���ѵ���÷�" + "\n" + "�ﵽ" + FS.ToString() + "���ˣ�";
        if (FS >= 60 && FS < 90)
        {
            Medal.text = "ͭ����";
        }
        else if (FS >= 90 && FS < 100)
        {
            Medal.text = "������";
        }
        else if (FS == 100)
        {
            Medal.text = "����";
        }
        else
        {
            Medal.text = "���Ž���";
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (IfFirstTime == true)
        {
            if (Input.GetMouseButtonDown(0)) // ���������
            {
                clickCount++; // ���ӵ��������
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
            if (Input.GetMouseButtonDown(0)) // ���������
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

    // ���� Panel
    public void HidePanel(GameObject DefenPanel)
    {
        DefenPanel.SetActive(false);
    }

    // ��ʾ Panel
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
