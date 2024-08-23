using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select5 : MonoBehaviour
{
    private bool isChoose = false;
    private Select5 AOption; // 00ѡ��Ľű�����
    private Select5 BOption; // 01ѡ��Ľű�����
    private Select5 COption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeIG5 timeIG5; // ����ʱ������������

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select5 CorrectAnswer;
    private Select5 WrongAnswer1;
    private Select5 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select5>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select5>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select5>();



        //Debug.Log("�Ѿ�����3��ѡ��ű�");
    }

    public void OnButtonClickA()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;

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


    private void CheckAnswer()
    {


        if (AOption.isChoose == true &&
            BOption.isChoose == false &&
            COption.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            TG1Instance.instance.MCorrect2 = AOption.correct;
            SceneManager.LoadScene("Select6");
        }
        else
        {
            Debug.Log("�����!");

            timeIG5.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}