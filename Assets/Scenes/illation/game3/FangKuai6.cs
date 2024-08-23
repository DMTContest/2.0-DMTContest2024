using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FangKuai6 : MonoBehaviour
{
    public Button[] buttons; // ��ť���������������������
    private bool[] buttonStates; // ��ť״̬����
    public TimeFG6 timeFG6; // ���õ� Countdown �ű�
    private bool isChoose = false;


    private FangKuai6 AOption; // 00ѡ��Ľű�����
    private FangKuai6 BOption; // 01ѡ��Ľű�����
    private FangKuai6 COption; // 10ѡ��Ľű�����



    public float correct = 0;
    public float wrong = 0;
    private FangKuai6 CorrectAnswer;
    private FangKuai6 WrongAnswer1;
    private FangKuai6 WrongAnswer2;

    void OnButtonClicked(int buttonIndex)
    {
        // ���°�ť״̬������Ƿ����а�ť���ѵ��
        buttonStates[buttonIndex] = true;
        buttons[buttonIndex].gameObject.SetActive(false); // ���ذ�ť

        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // ���а�ť��������ˣ�����ҳ����ת
        SceneManager.LoadScene("FangKuai7"); // �滻�����Ŀ�곡������
    }

    // IPointerClickHandler method
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the clicked object is not in the buttons array
        GameObject clickedObject = eventData.pointerPress;
        bool isButton = System.Array.Exists(buttons, button => button.gameObject == clickedObject);

        if (!isButton)
        {
            // Reduce time by 10 seconds
            if (timeFG6 != null)
            {
                timeFG6.ReduceTime(10f);
            }
        }
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

        AOption = OA.GetComponent<FangKuai6>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<FangKuai6>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<FangKuai6>();




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
        Debug.Log("ѡ����6b");
        // ����
        CheckAnswer();
        if(BOption.isChoose == true){
            SceneManager.LoadScene("FangKuai7");
        }
    }

    public void OnButtonClickC()
    {

        isChoose = false;
        // ����
        CheckAnswer();
    }

    private void CheckAnswer()
    {


        if ( AOption.isChoose == false &&
             BOption.isChoose == true &&
             COption.isChoose == false )
        {
            Debug.Log("�����!");
            AOption.correct = 1;
           // SceneManager.LoadScene("FangKuai7");
        }
        else
        {
            Debug.Log("�����!");

            timeFG6.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }

}