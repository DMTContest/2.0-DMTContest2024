using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu4 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu4 AOption; // 00ѡ��Ľű�����
    private pintu4 BOption; // 01ѡ��Ľű�����
    private pintu4 COption; // 10ѡ��Ľű�����
    private pintu4 DOption; // 11ѡ��Ľű�����

    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG4 timePG4;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu4>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu4>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu4>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu4>();
        // ���ѡ��Ľű�����
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
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
    public void OnButtonClickA()
    {

        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage1 != null)
        {
            targetImage1.color = Color.green; // ����ɫ����Ϊ��ɫ
        }
    }

    public void OnButtonClickC()
    {


        COption.wrong += 1;
        // ����
        CheckAnswer();

        timePG4.ReduceTime(10f);

        isChoose = false;
        // ����
    }
    public void OnButtonClickD()
    {
        timePG4.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ

        COption.wrong += 1;


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu4 CorrectOption1 = AOption;
        pintu4 CorrectOption2 = BOption;

        pintu4 WrongOption1 = COption;
        pintu4 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu5");
        }
        else
        {
            Debug.Log("�����!");




        }
    }
}