using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing3 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing3 AOption; // 00ѡ��Ľű�����
    private TuXing3 BOption; // 01ѡ��Ľű�����
    private TuXing3 COption; // 10ѡ��Ľű�����
    private TuXing3 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX3 timeTX3; // ����ʱ������������
    public float timeStart;


    private TuXing3 CorrectAnswer;
    private TuXing3 WrongAnswer1;
    private TuXing3 WrongAnswer2;
    private TuXing3 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing3>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing3>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing3>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing3>();


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
            BOption.correct = 1;
            GG1Instance.instance.JCorrect1 = BOption.correct;
            SceneManager.LoadScene("TuXing4");
        }
        else
        {
            Debug.Log("�����!");

            timeTX3.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}