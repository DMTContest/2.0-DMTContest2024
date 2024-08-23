using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select9 : MonoBehaviour
{
    private bool isChoose = false;
    private Select9 AOption; // 00ѡ��Ľű�����
    private Select9 BOption; // 01ѡ��Ľű�����
    private Select9 COption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeIG9 timeIG9; // ����ʱ������������

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select9 CorrectAnswer;
    private Select9 WrongAnswer1;
    private Select9 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select9>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select9>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<Select9>();



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
            TG1Instance.instance.HCorrect3 = COption.correct;
            SceneManager.LoadScene("Select10");
        }
        else
        {
            Debug.Log("�����!");

            timeIG9.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}