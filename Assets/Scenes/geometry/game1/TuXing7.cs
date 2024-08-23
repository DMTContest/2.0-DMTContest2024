using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing7 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing7 AOption; // 00ѡ��Ľű�����
    private TuXing7 BOption; // 01ѡ��Ľű�����
    private TuXing7 COption; // 10ѡ��Ľű�����
    private TuXing7 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX7 timeTX7; // ����ʱ������������
    public float timeStart;


    private TuXing7 CorrectAnswer;
    private TuXing7 WrongAnswer1;
    private TuXing7 WrongAnswer2;
    private TuXing7 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing7>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing7>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing7>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing7>();


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
            GG1Instance.instance.HCorrect1 = AOption.correct;
            SceneManager.LoadScene("TuXing8");
        }
        else
        {
            Debug.Log("�����!");

            timeTX7.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}