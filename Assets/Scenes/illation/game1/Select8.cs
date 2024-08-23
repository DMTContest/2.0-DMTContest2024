using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select8 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeIG8 timeIG8; // ����ʱ������������
    private Select8 AOption; // 00ѡ��Ľű�����
    private Select8 BOption; // 01ѡ��Ľű�����
    private Select8 COption; // 10ѡ��Ľű�����

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float correct = 0;
    public float wrong = 0;
    private Select8 CorrectAnswer;
    private Select8 WrongAnswer1;
    private Select8 WrongAnswer2;

    private void Start()
    {
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select8>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select8>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select8>();
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
            TG1Instance.instance.HCorrect2 = BOption.correct;
            SceneManager.LoadScene("Select9");
        }
        else
        {
            Debug.Log("�����!");

            timeIG8.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}