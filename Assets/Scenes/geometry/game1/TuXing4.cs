using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing4 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing4 AOption; // 00ѡ��Ľű�����
    private TuXing4 BOption; // 01ѡ��Ľű�����
    private TuXing4 COption; // 10ѡ��Ľű�����
    private TuXing4 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX4 timeTX4; // ����ʱ������������
    public float timeStart;


    private TuXing4 CorrectAnswer;
    private TuXing4 WrongAnswer1;
    private TuXing4 WrongAnswer2;
    private TuXing4 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing4>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing4>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing4>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing4>();


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
            GG1Instance.instance.MCorrect1 = COption.correct;
            SceneManager.LoadScene("TuXing5");
        }
        else
        {
            Debug.Log("�����!");

            timeTX4.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}