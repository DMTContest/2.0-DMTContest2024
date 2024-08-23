using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing8 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing8 AOption; // 00ѡ��Ľű�����
    private TuXing8 BOption; // 01ѡ��Ľű�����
    private TuXing8 COption; // 10ѡ��Ľű�����
    private TuXing8 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX8 timeTX8; // ����ʱ������������
    public float timeStart;


    private TuXing8 CorrectAnswer;
    private TuXing8 WrongAnswer1;
    private TuXing8 WrongAnswer2;
    private TuXing8 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing8>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing8>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing8>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing8>();


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
    public void OnButtonClickD()
    {
        isChoose = false;
        // ����
        CheckAnswer();
    }
    private void CheckAnswer()
    {

        if (AOption.isChoose == true &&
             BOption.isChoose == false &&
             COption.isChoose == false &&
             DOption.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            GG1Instance.instance.HCorrect2 = AOption.correct;
            SceneManager.LoadScene("TuXing9");
        }
        else
        {
            Debug.Log("�����!");

            timeTX8.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}