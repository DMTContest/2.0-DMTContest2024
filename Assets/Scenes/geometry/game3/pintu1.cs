using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu1 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu1 AOption; // 00ѡ��Ľű�����
    private pintu1 BOption; // 01ѡ��Ľű�����
    private pintu1 COption; // 10ѡ��Ľű�����
    private pintu1 DOption; // 11ѡ��Ľű�����

    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG1 timePG1;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu1>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu1>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu1>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu1>();
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
        if (targetImage1 != null)
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


        // ����
        CheckAnswer();

        timePG1.ReduceTime(10f);
        DOption.wrong += 1;
        isChoose = false;
        // ����
    }
    public void OnButtonClickD()
    {
        timePG1.ReduceTime(10f);
        DOption.wrong += 1;
        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu1 CorrectOption1 = AOption;
        pintu1 CorrectOption2 = COption;

        pintu1 WrongOption1 = BOption;
        pintu1 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu2");
        }
        else
        {
            Debug.Log("�����!");

        }
    }
}