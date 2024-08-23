using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing10 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing10 AOption; // 00ѡ��Ľű�����
    private TuXing10 BOption; // 01ѡ��Ľű�����
    private TuXing10 COption; // 10ѡ��Ľű�����
    private TuXing10 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX10 timeTX10; // ����ʱ������������
    public float timeStart;


    private TuXing10 CorrectAnswer;
    private TuXing10 WrongAnswer1;
    private TuXing10 WrongAnswer2;
    private TuXing10 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing10>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing10>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing10>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing10>();


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
    private void CheckAnswer()
    {

        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == true &&
             DOption.isChoose == false)
        {
            Debug.Log("�����!");
            COption.correct = 1;
            GG1Instance.instance.HCorrect4 = COption.correct;
            SceneManager.LoadScene("XGFinal");
        }
        else
        {
            Debug.Log("�����!");

            timeTX10.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}