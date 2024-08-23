using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FangKuai9 : MonoBehaviour
{
    public Button[] buttons; // ��ť���������������������
    private bool[] buttonStates; // ��ť״̬����
    public TimeFG9 timeFG9; // ���õ� Countdown �ű�
    private bool isChoose = false;


    private FangKuai9 AOption; // 00ѡ��Ľű�����
    private FangKuai9 BOption; // 01ѡ��Ľű�����
    private FangKuai9 COption; // 10ѡ��Ľű�����
    private FangKuai9 DOption; // 10ѡ��Ľű�����
    private FangKuai9 EOption; // 10ѡ��Ľű�����


    public float correct = 0;
    public float wrong = 0;
    private FangKuai9 CorrectAnswer;
    private FangKuai9 WrongAnswer1;
    private FangKuai9 WrongAnswer2;
    private FangKuai9 WrongAnswer3;
    private FangKuai9 WrongAnswer4;

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
        SceneManager.LoadScene("FangKuai10"); // �滻�����Ŀ�곡������
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
            if (timeFG9 != null)
            {
                timeFG9.ReduceTime(10f);
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

        AOption = OA.GetComponent<FangKuai9>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<FangKuai9>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<FangKuai9>();
        GameObject OD = GameObject.Find("Button-4");

        DOption = OD.GetComponent<FangKuai9>();

        GameObject OE = GameObject.Find("Button-5");

        EOption = OE.GetComponent<FangKuai9>();


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
    public void OnButtonClickE()
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
             DOption.isChoose == false &&
             EOption.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("FangKuai10");
        }
        else
        {
            Debug.Log("�����!");

            timeFG9.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }

}