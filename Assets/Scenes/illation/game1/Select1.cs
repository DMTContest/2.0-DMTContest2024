using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select1 : MonoBehaviour
{
    private bool isChoose = false;
    private Select1 AOption; // 00ѡ��Ľű�����
    private Select1 BOption; // 01ѡ��Ľű�����
    private Select1 COption; // 10ѡ��Ľű�����

    public float correct = 0;
    public float wrong = 0;

    public TimeIG1 timeIG11; // ����ʱ������������

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;

    
    private Select1 CorrectAnswer;
    private Select1 WrongAnswer1;
    private Select1 WrongAnswer2;
  
    private void Start()
    {
      
        //Debug.Log("���ڵ��ô𰸼����");

        // ��ȡ��ǰButton��Image���


        // ���ѡ��Ľű����á���
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select1>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select1>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<Select1>();



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
             COption.isChoose ==true)
        {
            Debug.Log("�����!");
            COption.correct = 1;
            TG1Instance.instance.JCorrect1 = COption.correct;
            SceneManager.LoadScene("Select2");
        }
        else
        {
            Debug.Log("�����!");

            timeIG11.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}