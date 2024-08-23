using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu3 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu3 AOption; // 00ѡ��Ľű�����
    private pintu3 BOption; // 01ѡ��Ľű�����
    private pintu3 COption; // 10ѡ��Ľű�����
    private pintu3 DOption; // 11ѡ��Ľű�����

    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG3 timePG3;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu3>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu3>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu3>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu3>();
        // ���ѡ��Ľű�����
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
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
    public void OnButtonClickC()
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

    public void OnButtonClickA()
    {


        // ����
        CheckAnswer();

        timePG3.ReduceTime(10f);

        isChoose = false;
        // ����
    }
    public void OnButtonClickB()
    {
        timePG3.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu3 CorrectOption1 = COption;
        pintu3 CorrectOption2 = DOption;

        pintu3 WrongOption1 = AOption;
        pintu3 WrongOption2 = BOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            COption.correct = 1;
            SceneManager.LoadScene("pintu4");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}