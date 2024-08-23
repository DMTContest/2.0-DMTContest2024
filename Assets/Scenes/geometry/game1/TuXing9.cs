using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing9 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing9 AOption; // 00ѡ��Ľű�����
    private TuXing9 BOption; // 01ѡ��Ľű�����
    private TuXing9 COption; // 10ѡ��Ľű�����
    private TuXing9 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX9 timeTX9; // ����ʱ������������
    public float timeStart;


    private TuXing9 CorrectAnswer;
    private TuXing9 WrongAnswer1;
    private TuXing9 WrongAnswer2;
    private TuXing9 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing9>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing9>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing9>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing9>();


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
            GG1Instance.instance.HCorrect3 = AOption.correct;
            SceneManager.LoadScene("TuXing10");
        }
        else
        {
            Debug.Log("�����!");

            timeTX9.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}