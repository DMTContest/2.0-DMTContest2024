using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing4 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing4 AOption; // 00ѡ��Ľű�����
    private JianYing4 BOption; // 01ѡ��Ľű�����
    private JianYing4 COption; // 10ѡ��Ľű�����
    private JianYing4 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimeYG4 timeYG4;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing4>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing4>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing4>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing4>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }


    public void OnButtonClickA()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG4.ReduceTime(10f);
        BOption.wrong += 1;
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

    public void OnButtonClickB()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG4.ReduceTime(10f);
        BOption.wrong += 1;
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
        JianYing4 CorrectOption1 = COption;
        JianYing4 CorrectOption2 = DOption;

        JianYing4 WrongOption1 = BOption;
        JianYing4 WrongOption2 = AOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            COption.correct = 1;
            SceneManager.LoadScene("JianYing5");
        }
    }
}