using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing9 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing9 AOption; // 00ѡ��Ľű�����
    private JianYing9 BOption; // 01ѡ��Ľű�����
    private JianYing9 COption; // 10ѡ��Ľű�����
    private JianYing9 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimeYG9 timeYG9;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing9>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing9>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing9>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing9>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG9.ReduceTime(10f);
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
            targetImage1.color = Color.green; // ����ɫ����Ϊ��ɫ
        }


    }

    public void OnButtonClickC()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG9.ReduceTime(10f);
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
        JianYing9 CorrectOption1 = BOption;
        JianYing9 CorrectOption2 = DOption;

        JianYing9 WrongOption1 = AOption;
        JianYing9 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing10");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}