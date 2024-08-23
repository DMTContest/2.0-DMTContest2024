using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing5 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing5 AOption; // 00ѡ��Ľű�����
    private TuXing5 BOption; // 01ѡ��Ľű�����
    private TuXing5 COption; // 10ѡ��Ľű�����
    private TuXing5 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX5 timeTX5; // ����ʱ������������
    public float timeStart;


    private TuXing5 CorrectAnswer;
    private TuXing5 WrongAnswer1;
    private TuXing5 WrongAnswer2;
    private TuXing5 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing5>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing5>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing5>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing5>();


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
            GG1Instance.instance.MCorrect2 = BOption.correct;
            SceneManager.LoadScene("TuXing6");
        }
        else
        {
            Debug.Log("�����!");

            timeTX5.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}