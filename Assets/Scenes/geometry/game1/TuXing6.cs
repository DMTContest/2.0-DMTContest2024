using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing6 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing6 AOption; // 00ѡ��Ľű�����
    private TuXing6 BOption; // 01ѡ��Ľű�����
    private TuXing6 COption; // 10ѡ��Ľű�����
    private TuXing6 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX6 timeTX6; // ����ʱ������������
    public float timeStart;


    private TuXing6 CorrectAnswer;
    private TuXing6 WrongAnswer1;
    private TuXing6 WrongAnswer2;
    private TuXing6 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing6>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing6>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing6>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing6>();


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
            GG1Instance.instance.MCorrect3 = DOption.correct;
            SceneManager.LoadScene("TuXing7");
        }
        else
        {
            Debug.Log("�����!");

            timeTX6.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}