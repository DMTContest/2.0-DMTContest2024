using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing1 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing1 AOption; // 00ѡ��Ľű�����
    private JianYing1 BOption; // 01ѡ��Ľű�����
    private JianYing1 COption; // 10ѡ��Ľű�����
    private JianYing1 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimeYG1 timeYG1;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing1>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing1>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing1>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing1>();

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
            targetImage1.color = Color.green; // ����ɫ����Ϊ��ɫ
        }
    }
    public void OnButtonClickA()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG1.ReduceTime(10f);



    }

    public void OnButtonClickC()
    {


        // ����
        CheckAnswer();

        timeYG1.ReduceTime(10f);

        isChoose = false;
        // ����
    }
    public void OnButtonClickD()
    {
        timeYG1.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        JianYing1 CorrectOption1 = BOption;


        JianYing1 WrongOption1 = AOption;
        JianYing1 WrongOption2 = DOption;
        JianYing1 WrongOption3 = COption;

        if (CorrectOption1.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing2");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}