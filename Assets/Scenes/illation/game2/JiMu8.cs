using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu8 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG8 timeJG8; // ����ʱ������������
    private JiMu8 AOption; // 00ѡ��Ľű�����
    private JiMu8 BOption; // 01ѡ��Ľű�����
    private JiMu8 COption; // 10ѡ��Ľű�����
    private JiMu8 DOption; // 00ѡ��Ľű�����
    private JiMu8 EOption; // 01ѡ��Ľű�����
    private JiMu8 FOption; // 10ѡ��Ľű�����
    private JiMu8 GOption; // 00ѡ��Ľű�����
    private JiMu8 HOption; // 01ѡ��Ľű�����
    private JiMu8 IOption; // 10ѡ��Ľű�����
    private JiMu8 JOption; // 00ѡ��Ľű�����
    private JiMu8 KOption; // 01ѡ��Ľű�����
    private JiMu8 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu8 CorrectAnswer;
    private JiMu8 WrongAnswer1;
    private JiMu8 WrongAnswer2;
    private JiMu8 WrongAnswer3;
    private JiMu8 WrongAnswer4;
    private JiMu8 WrongAnswer5;
    private JiMu8 WrongAnswer6;
    private JiMu8 WrongAnswer7;
    private JiMu8 WrongAnswer8;
    private JiMu8 WrongAnswer9;
    private JiMu8 WrongAnswer10;
    private JiMu8 WrongAnswer11;
    private JiMu8 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu8>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu8>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu8>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu8>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu8>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu8>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu8>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu8>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu8>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu8>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu8>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu8>();
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
        // �л�ѡ��״̬
        isChoose = !isChoose;
       
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
            FOption.isChoose == false &&
            GOption.isChoose == false &&
            HOption.isChoose == true &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("�����!");
            HOption.correct = 1;
            TG2Instance.instance.HCorrect2 = HOption.correct;
            SceneManager.LoadScene("JiMu9");
        }
        else
        {
            Debug.Log("�����!");

            timeJG8.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
