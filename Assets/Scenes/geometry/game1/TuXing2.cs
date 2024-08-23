using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing2 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing2 AOption; // 00ѡ��Ľű�����
    private TuXing2 BOption; // 01ѡ��Ľű�����
    private TuXing2 COption; // 10ѡ��Ľű�����
    private TuXing2 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX2 timeTX2; // ����ʱ������������
    public float timeStart;


    private TuXing2 CorrectAnswer;
    private TuXing2 WrongAnswer1;
    private TuXing2 WrongAnswer2;
    private TuXing2 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing2>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing2>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing2>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing2>();


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
    private void CheckAnswer()
    {

        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == false &&
             DOption.isChoose == true)
        {
            Debug.Log("�����!");
            DOption.correct = 1;
            GG1Instance.instance.JCorrect2 = DOption.correct;
            SceneManager.LoadScene("TuXing3");
        }
        else
        {
            Debug.Log("�����!");

            timeTX2.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}