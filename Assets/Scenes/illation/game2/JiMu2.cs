using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu2 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG2 timeJG2; // ����ʱ������������
    private JiMu2 AOption; // 00ѡ��Ľű�����
    private JiMu2 BOption; // 01ѡ��Ľű�����
    private JiMu2 COption; // 10ѡ��Ľű�����
    private JiMu2 DOption; // 00ѡ��Ľű�����
    private JiMu2 EOption; // 01ѡ��Ľű�����
    private JiMu2 FOption; // 10ѡ��Ľű�����
    private JiMu2 GOption; // 00ѡ��Ľű�����
    private JiMu2 HOption; // 01ѡ��Ľű�����
    private JiMu2 IOption; // 10ѡ��Ľű�����
    private JiMu2 JOption; // 00ѡ��Ľű�����
    private JiMu2 KOption; // 01ѡ��Ľű�����
    private JiMu2 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu2 CorrectAnswer;
    private JiMu2 WrongAnswer1;
    private JiMu2 WrongAnswer2;
    private JiMu2 WrongAnswer3;
    private JiMu2 WrongAnswer4;
    private JiMu2 WrongAnswer5;
    private JiMu2 WrongAnswer6;
    private JiMu2 WrongAnswer7;
    private JiMu2 WrongAnswer8;
    private JiMu2 WrongAnswer9;
    private JiMu2 WrongAnswer10;
    private JiMu2 WrongAnswer11;
    private JiMu2 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu2>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu2>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu2>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu2>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu2>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu2>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu2>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu2>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu2>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu2>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu2>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu2>();
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

        // �л�ѡ��״̬
        isChoose = !isChoose;

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
            COption.isChoose == true &&
            DOption.isChoose == false &&
            EOption.isChoose == false &&
            FOption.isChoose == false &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("�����!");
            COption.correct = 1;
            TG2Instance.instance.JCorrect2 = COption.correct;
            SceneManager.LoadScene("JiMu3");
        }
        else
        {
            Debug.Log("�����!");

            timeJG2.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
