using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu10 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG10 timeJG10; // ����ʱ������������
    private JiMu10 AOption; // 00ѡ��Ľű�����
    private JiMu10 BOption; // 01ѡ��Ľű�����
    private JiMu10 COption; // 10ѡ��Ľű�����
    private JiMu10 DOption; // 00ѡ��Ľű�����
    private JiMu10 EOption; // 01ѡ��Ľű�����
    private JiMu10 FOption; // 10ѡ��Ľű�����
    private JiMu10 GOption; // 00ѡ��Ľű�����
    private JiMu10 HOption; // 01ѡ��Ľű�����
    private JiMu10 IOption; // 10ѡ��Ľű�����
    private JiMu10 JOption; // 00ѡ��Ľű�����
    private JiMu10 KOption; // 01ѡ��Ľű�����
    private JiMu10 LOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;
    private JiMu10 CorrectAnswer;
    private JiMu10 WrongAnswer1;
    private JiMu10 WrongAnswer2;
    private JiMu10 WrongAnswer3;
    private JiMu10 WrongAnswer4;
    private JiMu10 WrongAnswer5;
    private JiMu10 WrongAnswer6;
    private JiMu10 WrongAnswer7;
    private JiMu10 WrongAnswer8;
    private JiMu10 WrongAnswer9;
    private JiMu10 WrongAnswer10;
    private JiMu10 WrongAnswer11;
    private JiMu10 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu10>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu10>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu10>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu10>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu10>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu10>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu10>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu10>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu10>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu10>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu10>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu10>();
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
            TG2Instance.instance.HCorrect4 = HOption.correct;
            SceneManager.LoadScene("JGFinal");
        }
        else
        {
            Debug.Log("�����!");

            timeJG10.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
