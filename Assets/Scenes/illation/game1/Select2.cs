using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select2 : MonoBehaviour
{
    private bool isChoose = false;
    private Select2 AOption; // 00ѡ��Ľű�����
    private Select2 BOption; // 01ѡ��Ľű�����
    private Select2 COption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeIG2 timeIG2; // ����ʱ������������

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select2 CorrectAnswer;
    private Select2 WrongAnswer1;
    private Select2 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select2>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select2>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select2>();



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
    
 
    private void CheckAnswer()
    {


        if (AOption.isChoose == true &&
            BOption.isChoose == false &&
            COption.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            TG1Instance.instance.JCorrect2 = AOption.correct;
            SceneManager.LoadScene("Select3");
        }
        else
        {
            Debug.Log("�����!");

            timeIG2.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}