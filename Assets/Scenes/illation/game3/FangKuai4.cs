using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FangKuai4 : MonoBehaviour
{
    public Button[] buttons; // ��ť����
    private bool[] buttonStates; // ��ť״̬����
    public TimeFG4 timeFG4; // ���õ� Countdown �ű�

    private bool isChoose = false;

    private FangKuai4 AOption; // 00ѡ��Ľű�����
    private FangKuai4 BOption; // 01ѡ��Ľű�����
    private FangKuai4 COption; // 10ѡ��Ľű�����
    private FangKuai4 DOption; // 10ѡ��Ľű�����


    public float correct = 0;
    public float wrong = 0;
    private FangKuai4 CorrectAnswer;
    private FangKuai4 WrongAnswer1;
    private FangKuai4 WrongAnswer2;
    private FangKuai4 WrongAnswer3;


    void OnButtonClicked(int buttonIndex)
    {
        // ���°�ť״̬������Ƿ����а�ť���ѵ��
        buttonStates[buttonIndex] = true;
        buttons[buttonIndex].gameObject.SetActive(false); // ���ذ�ť

    }


    private void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // ���浱ǰ�����Ա��ڱհ���ʹ��
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<FangKuai4>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<FangKuai4>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<FangKuai4>();

        GameObject OD = GameObject.Find("Button-4");

        DOption = OD.GetComponent<FangKuai4>();


        //Debug.Log("�Ѿ�����3��ѡ��ű�");
    }

    public void OnButtonClickA()
    {
        isChoose = false;
        // ����
        CheckAnswer();
    }
    public void OnButtonClickB()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;

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

    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
             BOption.isChoose == true &&
             COption.isChoose == false &&
             DOption.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("FangKuai5");
        }
        else
        {
            Debug.Log("�����!");

            timeFG4.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }

}