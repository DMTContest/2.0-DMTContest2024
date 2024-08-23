using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select6 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeIG6 timeIG6; // ����ʱ������������
    private Select6 AOption; // 00ѡ��Ľű�����
    private Select6 BOption; // 01ѡ��Ľű�����
    private Select6 COption; // 10ѡ��Ľű�����

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float correct = 0;
    public float wrong = 0;
    private Select6 CorrectAnswer;
    private Select6 WrongAnswer1;
    private Select6 WrongAnswer2;

    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select6>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select6>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select6>();
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
            TG1Instance.instance.MCorrect3 = BOption.correct;
            SceneManager.LoadScene("Select7");
        }
        else
        {
            Debug.Log("�����!");

            timeIG6.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}