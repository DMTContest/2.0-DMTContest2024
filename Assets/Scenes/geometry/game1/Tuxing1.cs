using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tuxing1 : MonoBehaviour
{
    private bool isChoose = false;
    private Tuxing1 AOption; // 00ѡ��Ľű�����
    private Tuxing1 BOption; // 01ѡ��Ľű�����
    private Tuxing1 COption; // 10ѡ��Ľű�����
    private Tuxing1 DOption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeTX1 timeTX1; // ����ʱ������������
    public float timeStart;


    private Tuxing1 CorrectAnswer;
    private Tuxing1 WrongAnswer1;
    private Tuxing1 WrongAnswer2;
    private Tuxing1 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<Tuxing1>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<Tuxing1>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<Tuxing1>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<Tuxing1>();


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
            SceneManager.LoadScene("TuXing2");
        }
        else
        {
            Debug.Log("�����!");

            timeTX1.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}