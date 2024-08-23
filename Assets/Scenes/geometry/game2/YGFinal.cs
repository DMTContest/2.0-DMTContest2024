using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YGFinal : MonoBehaviour
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
        IfFirstTime = GG2Instance.FirstTime;
        HideAllUIElements(ChufenQian);
        HideAllUIElements(Chufen);
        HidePanel(DefenPanel);
        HidePanel(MedalPanel);
        JS.text = (GG2Instance.Jcorrect * 10 - (GG2Instance.JWR1 + GG2Instance.JWR2 + GG2Instance.JWR3) * 10).ToString();
        MS.text = (GG2Instance.Mcorrect * 10 - (GG2Instance.MWR1 + GG2Instance.MWR2 + GG2Instance.MWR3) * 10).ToString();
        HS.text = (GG2Instance.Hcorrect * 10 - (GG2Instance.HWR1 + GG2Instance.HWR2 + GG2Instance.HWR3 + GG2Instance.HWR4) * 10).ToString();
        JR.text = GG2Instance.Jcorrect.ToString();
        MR.text = GG2Instance.Mcorrect.ToString();
        HR.text = GG2Instance.Hcorrect.ToString();
        JW.text = (GG2Instance.JWR1 + GG2Instance.JWR2 + GG2Instance.JWR3).ToString();
        MW.text = (GG2Instance.MWR1 + GG2Instance.MWR2 + GG2Instance.MWR3).ToString();
        HW.text = (GG2Instance.HWR1 + GG2Instance.HWR2 + GG2Instance.HWR3 + GG2Instance.HWR4).ToString();
        GameDateNow.text = DateTime.Now.ToString();
        FS =
           GG2Instance.Jcorrect * 10 - (GG2Instance.JWR1 + GG2Instance.JWR2 + GG2Instance.JWR3) * 10
        + GG2Instance.Mcorrect * 10 - (GG2Instance.MWR1 + GG2Instance.MWR2 + GG2Instance.MWR3) * 10
        + GG2Instance.Hcorrect * 10 - (GG2Instance.HWR1 + GG2Instance.HWR2 + GG2Instance.HWR3 + GG2Instance.HWR4) * 10;

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
