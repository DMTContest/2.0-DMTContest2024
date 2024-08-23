using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu3 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG3 timeJG3; // ����ʱ������������
    private JiMu3 AOption; // 00ѡ��Ľű�����
    private JiMu3 BOption; // 01ѡ��Ľű�����
    private JiMu3 COption; // 10ѡ��Ľű�����
    private JiMu3 DOption; // 00ѡ��Ľű�����
    private JiMu3 EOption; // 01ѡ��Ľű�����
    private JiMu3 FOption; // 10ѡ��Ľű�����
    private JiMu3 GOption; // 00ѡ��Ľű�����
    private JiMu3 HOption; // 01ѡ��Ľű�����
    private JiMu3 IOption; // 10ѡ��Ľű�����
    private JiMu3 JOption; // 00ѡ��Ľű�����
    private JiMu3 KOption; // 01ѡ��Ľű�����
    private JiMu3 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu3 CorrectAnswer;
    private JiMu3 WrongAnswer1;
    private JiMu3 WrongAnswer2;
    private JiMu3 WrongAnswer3;
    private JiMu3 WrongAnswer4;
    private JiMu3 WrongAnswer5;
    private JiMu3 WrongAnswer6;
    private JiMu3 WrongAnswer7;
    private JiMu3 WrongAnswer8;
    private JiMu3 WrongAnswer9;
    private JiMu3 WrongAnswer10;
    private JiMu3 WrongAnswer11;
    private JiMu3 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu3>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu3>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu3>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu3>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu3>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu3>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu3>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu3>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu3>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu3>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu3>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu3>();
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
        // �л�ѡ��״̬
        isChoose = !isChoose;
       
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
            COption.isChoose == false &&
            DOption.isChoose == true &&
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
            DOption.correct = 1;
            TG2Instance.instance.JCorrect3 = DOption.correct;
            SceneManager.LoadScene("JiMu4");
        }
        else
        {
            Debug.Log("�����!");

            timeJG3.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
