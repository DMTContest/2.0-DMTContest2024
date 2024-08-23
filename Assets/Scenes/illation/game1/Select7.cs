using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select7: MonoBehaviour
{
    private bool isChoose = false;
    private Select7 AOption; // 00ѡ��Ľű�����
    private Select7 BOption; // 01ѡ��Ľű�����
    private Select7 COption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeIG7 timeIG7; // ����ʱ������������

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select7 CorrectAnswer;
    private Select7 WrongAnswer1;
    private Select7 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select7>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select7>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<Select7>();



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
    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == true)
        {
            Debug.Log("�����!");
            COption.correct = 1;
            TG1Instance.instance.HCorrect1= COption.correct;
            SceneManager.LoadScene("Select8");
        }
        else
        {
            Debug.Log("�����!");

            timeIG7.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}