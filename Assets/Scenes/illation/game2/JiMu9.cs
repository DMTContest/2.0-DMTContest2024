using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu9 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG9 timeJG9; // ����ʱ������������
    private JiMu9 AOption; // 00ѡ��Ľű�����
    private JiMu9 BOption; // 01ѡ��Ľű�����
    private JiMu9 COption; // 10ѡ��Ľű�����
    private JiMu9 DOption; // 00ѡ��Ľű�����
    private JiMu9 EOption; // 01ѡ��Ľű�����
    private JiMu9 FOption; // 10ѡ��Ľű�����
    private JiMu9 GOption; // 00ѡ��Ľű�����
    private JiMu9 HOption; // 01ѡ��Ľű�����
    private JiMu9 IOption; // 10ѡ��Ľű�����
    private JiMu9 JOption; // 00ѡ��Ľű�����
    private JiMu9 KOption; // 01ѡ��Ľű�����
    private JiMu9 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu9 CorrectAnswer;
    private JiMu9 WrongAnswer1;
    private JiMu9 WrongAnswer2;
    private JiMu9 WrongAnswer3;
    private JiMu9 WrongAnswer4;
    private JiMu9 WrongAnswer5;
    private JiMu9 WrongAnswer6;
    private JiMu9 WrongAnswer7;
    private JiMu9 WrongAnswer8;
    private JiMu9 WrongAnswer9;
    private JiMu9 WrongAnswer10;
    private JiMu9 WrongAnswer11;
    private JiMu9 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu9>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu9>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu9>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu9>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu9>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu9>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu9>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu9>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu9>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu9>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu9>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu9>();
        //Debug.Log("�Ѿ�����12��ѡ��ű�");


    }

    public void OnButtonClickA()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
    }

    public void OnButtonClickC()
    {
        isChoose = false;


        // ����
        CheckAnswer();
    }
    public void OnButtonClickD()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickE()
    {
        isChoose = false;


        // ����
        CheckAnswer();
    }
    public void OnButtonClickF()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickG()
    {
        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickH()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickI()
    {
        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickJ()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickK()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;
       
        // ����
        CheckAnswer();
    }
    public void OnButtonClickL()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }
    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
            BOption.isChoose == false &&
            COption.isChoose == false &&
            DOption.isChoose == false &&
            EOption.isChoose == false &&
            FOption.isChoose == false &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == true &&
            LOption.isChoose == false)

        {
            Debug.Log("�����!");
            KOption.correct = 1;
            TG2Instance.instance.HCorrect3 = KOption.correct;
            SceneManager.LoadScene("JiMu10");
        }
        else
        {
            Debug.Log("�����!");

            timeJG9.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
