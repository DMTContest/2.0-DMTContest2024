using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu2 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu2 AOption; // 00ѡ��Ľű�����
    private pintu2 BOption; // 01ѡ��Ľű�����
    private pintu2 COption; // 10ѡ��Ľű�����
    private pintu2 DOption; // 11ѡ��Ľű�����

    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG2 timePG2;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu2>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu2>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu2>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu2>();
        // ���ѡ��Ľű�����
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
    {

        // �л�ѡ��״̬
        isChoose = !isChoose;
        // �޸�Image��ɫ
        if (targetImage1 != null)
        {
            targetImage1.color = Color.green; // ����ɫ����Ϊ��ɫ
        }
        // ����
        CheckAnswer();
    }
    public void OnButtonClickA()
    {
        // ����
        CheckAnswer();

        timePG2.ReduceTime(10f);

        isChoose = false;
        // ����

    }

    public void OnButtonClickC()
    {

        // ����
        CheckAnswer();

        timePG2.ReduceTime(10f);

        isChoose = false;
        // ����

    }
    public void OnButtonClickD()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage2 != null)
        {
            targetImage2.color = Color.green; // ����ɫ����Ϊ��ɫ
        }

    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu2 CorrectOption1 = BOption;
        pintu2 CorrectOption2 = DOption;

        pintu2 WrongOption1 = AOption;
        pintu2 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("pintu3");
        }
        else
        {
            Debug.Log("�����!");


            COption.wrong += 1;


        }
    }
}