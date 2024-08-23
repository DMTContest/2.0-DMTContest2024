using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing3 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing3 AOption; // 00ѡ��Ľű�����
    private JianYing3 BOption; // 01ѡ��Ľű�����
    private JianYing3 COption; // 10ѡ��Ľű�����
    private JianYing3 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public TimeYG3 timeYG3;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing3>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing3>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing3>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing3>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }


    public void OnButtonClickB()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG3.ReduceTime(10f);
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

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG3.ReduceTime(10f);
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
       JianYing3 CorrectOption1 = AOption;
       JianYing3 CorrectOption2 = DOption;

       JianYing3 WrongOption1 = BOption;
       JianYing3 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("JianYing4");
        }
    }
}