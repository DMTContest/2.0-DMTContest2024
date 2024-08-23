using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select10 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeIG10 timeIG10; // ����ʱ������������
    private Select10 AOption; // 00ѡ��Ľű�����
    private Select10 BOption; // 01ѡ��Ľű�����
    private Select10 COption; // 10ѡ��Ľű�����

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float correct = 0;
    public float wrong = 0;
    private Select10 CorrectAnswer;
    private Select10 WrongAnswer1;
    private Select10 WrongAnswer2;

    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select10>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select10>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select10>();
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


    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
            BOption.isChoose == true &&
            COption.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            TG1Instance.instance.HCorrect4 = BOption.correct;
            SceneManager.LoadScene("SGFinal");
        }
        else
        {
            Debug.Log("�����!");

            timeIG10.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}