using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu7 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG7 timeJG7; // ����ʱ������������
    private JiMu7 AOption; // 00ѡ��Ľű�����
    private JiMu7 BOption; // 01ѡ��Ľű�����
    private JiMu7 COption; // 10ѡ��Ľű�����
    private JiMu7 DOption; // 00ѡ��Ľű�����
    private JiMu7 EOption; // 01ѡ��Ľű�����
    private JiMu7 FOption; // 10ѡ��Ľű�����
    private JiMu7 GOption; // 00ѡ��Ľű�����
    private JiMu7 HOption; // 01ѡ��Ľű�����
    private JiMu7 IOption; // 10ѡ��Ľű�����
    private JiMu7 JOption; // 00ѡ��Ľű�����
    private JiMu7 KOption; // 01ѡ��Ľű�����
    private JiMu7 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu7 CorrectAnswer;
    private JiMu7 WrongAnswer1;
    private JiMu7 WrongAnswer2;
    private JiMu7 WrongAnswer3;
    private JiMu7 WrongAnswer4;
    private JiMu7 WrongAnswer5;
    private JiMu7 WrongAnswer6;
    private JiMu7 WrongAnswer7;
    private JiMu7 WrongAnswer8;
    private JiMu7 WrongAnswer9;
    private JiMu7 WrongAnswer10;
    private JiMu7 WrongAnswer11;
    private JiMu7 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu7>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu7>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu7>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu7>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu7>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu7>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu7>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu7>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu7>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu7>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu7>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu7>();
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
        // �л�ѡ��״̬
        isChoose = !isChoose;
       
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
        isChoose = false;
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
            FOption.isChoose == true &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("�����!");
            FOption.correct = 1;
            TG2Instance.instance.HCorrect1 = FOption.correct;
            SceneManager.LoadScene("JiMu8");
        }
        else
        {
            Debug.Log("�����!");

            timeJG7.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
