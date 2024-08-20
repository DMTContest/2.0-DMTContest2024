using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Square2 : MonoBehaviour
{

    public bool ischoose = false;
    private Square2 CorrectAnswer;
    //错误答案
    private Square2 WrongAnswer1;
    private Square2 WrongAnswer2;
    private Square2 WrongAnswer3;
    private Square2 WrongAnswer4;

    public float correct = 0;
    public float wrong = 0;

    public TimeDG32 time;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Square = GameObject.Find("Square");
        CorrectAnswer = Square.GetComponent<Square2>();

        GameObject Square1 = GameObject.Find("Square (1)");
        WrongAnswer1 = Square1.GetComponent<Square2>();

        GameObject Square2 = GameObject.Find("Square (2)");
        WrongAnswer2 = Square2.GetComponent<Square2>();

        GameObject Square3 = GameObject.Find("Square (3)");
        WrongAnswer3 = Square3.GetComponent<Square2>();

        GameObject Square4 = GameObject.Find("Square (4)");
        WrongAnswer4 = Square4.GetComponent<Square2>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        ischoose = !ischoose;

        /*Debug.Log("C:"+CorrectAnswer.ischoose);
        Debug.Log("W1:"+WrongAnswer1.ischoose);
        Debug.Log("W2:"+WrongAnswer2.ischoose);
        Debug.Log("W3:"+WrongAnswer3.ischoose);*/

        if (CorrectAnswer.ischoose &&
            !WrongAnswer1.ischoose &&
            !WrongAnswer2.ischoose &&
            !WrongAnswer3.ischoose &&
            !WrongAnswer4.ischoose)
        {
            Destroy(gameObject);
            CorrectAnswer.correct = 1;
            Debug.Log("答对啦");

            SceneManager.LoadScene("DG33");
        }
        else
        {
            Destroy(gameObject);
            WrongAnswer1.wrong = 1;
            time.ReduceTime(10f);

            Debug.Log("没答对");
            SceneManager.LoadScene("DG33");
        }
    }
}


