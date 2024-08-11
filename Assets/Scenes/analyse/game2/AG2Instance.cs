using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AG2Instance : MonoBehaviour
{
    private static AG2Instance instance = null;
    public float _time = 0f;
    public float JCorrect;
    public float MCorrect;
    public float HCorrect;
    public float JWrong1;
    public float JWrong2;
    public float JWrong3;
    public float MWrong1;
    public float MWrong2;
    public float MWrong3;
    public float HWrong1;
    public float HWrong2;
    public float HWrong3;
    public float HWrong4;
    public string ScoreForAnalyzeWind;

    private void Awake()
    {
        // 确保只有一个 SceneTransition 实例
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "AG21"){
            JCorrect=1;

            _time = GetTimeFromScene1();
            
            JWrong1 =GetWrongNumFromScene1();
        }
        if(SceneManager.GetActiveScene().name == "AG22")
        {
            JCorrect=2;
            _time = GetTimeFromScene2();
            
            JWrong2 =GetWrongNumFromScene2();
 
        }if(SceneManager.GetActiveScene().name == "AG23")
        {
            JCorrect=3;

            _time = GetTimeFromScene3();
            
            JWrong3 =GetWrongNumFromScene3();
 
        }        if(SceneManager.GetActiveScene().name == "AG24"){
            MCorrect=1;

            _time = GetTimeFromScene4();
            
            MWrong1 =GetWrongNumFromScene4();
        }
        if(SceneManager.GetActiveScene().name == "AG25")
        {
            MCorrect=2;
            _time = GetTimeFromScene5();
            
            MWrong2 =GetWrongNumFromScene5();
 
        }if(SceneManager.GetActiveScene().name == "AG26")
        {
            MCorrect=3;

            _time = GetTimeFromScene6();
            
            MWrong3 =GetWrongNumFromScene6();
 
        }        if(SceneManager.GetActiveScene().name == "AG27"){
            HCorrect=1;

            _time = GetTimeFromScene7();
            
            HWrong1 =GetWrongNumFromScene7();
        }
        if(SceneManager.GetActiveScene().name == "AG28")
        {
            HCorrect=2;
            _time = GetTimeFromScene8();
            
            HWrong2 =GetWrongNumFromScene8();
 
        }if(SceneManager.GetActiveScene().name == "AG29")
        {
            HCorrect=3;

            _time = GetTimeFromScene9();
            
            HWrong3 =GetWrongNumFromScene9();
 
        }        if(SceneManager.GetActiveScene().name == "AG210"){
            HCorrect=4;

            _time = GetTimeFromScene10();
            
            HWrong4 =GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "AG2Final")
        {
           ScoreForAnalyzeWind = 
        (AG2Instance.Jcorrect*10 - (AG2Instance.JWR1+AG2Instance.JWR2+AG2Instance.JWR3)*4+ AG2Instance.Mcorrect*10 - (AG2Instance.MWR1+AG2Instance.MWR2+AG2Instance.MWR3)*6+ AG2Instance.Hcorrect*10 - (AG2Instance.HWR1+AG2Instance.HWR2+AG2Instance.HWR3+AG2Instance.HWR4)*8).ToString();

        }
    }

    private float GetTimeFromScene1()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock1 c = FindObjectOfType<Clock1>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene1()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock1 c = FindObjectOfType<Clock1>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }

    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }

        public static float Jcorrect
    {
        get { return instance != null ? instance.JCorrect : 0f; }
    }
            public static float Mcorrect
    {
        get { return instance != null ? instance.MCorrect : 0f; }
    }
            public static float Hcorrect
    {
        get { return instance != null ? instance.HCorrect : 0f; }
    }
            public static float JWR1
    {
        get { return instance != null ? instance.JWrong1 : 0f; }
    }
            public static float JWR2
    {
        get { return instance != null ? instance.JWrong2 : 0f; }
    }
            public static float JWR3
    {
        get { return instance != null ? instance.JWrong3 : 0f; }
    }
            public static float MWR1
    {
        get { return instance != null ? instance.MWrong1 : 0f; }
    }
            public static float MWR2
    {
        get { return instance != null ? instance.MWrong2 : 0f; }
    }
            public static float MWR3
    {
        get { return instance != null ? instance.MWrong3 : 0f; }
    }
            public static float HWR1
    {
        get { return instance != null ? instance.HWrong1 : 0f; }
    }
            public static float HWR2
    {
        get { return instance != null ? instance.HWrong2 : 0f; }
    }
            public static float HWR3
    {
        get { return instance != null ? instance.HWrong3 : 0f; }
    }
            public static float HWR4
    {
        get { return instance != null ? instance.HWrong4 : 0f; }
    }
            public static string RecordScore
    {
        get { return instance != null ? instance.ScoreForAnalyzeWind : null; }
    }

        private float GetTimeFromScene2()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock2 c = FindObjectOfType<Clock2>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene2()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock2 c = FindObjectOfType<Clock2>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }

        private float GetTimeFromScene3()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock3 c = FindObjectOfType<Clock3>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene3()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock3 c = FindObjectOfType<Clock3>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene4()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock4 c = FindObjectOfType<Clock4>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene4()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock4 c = FindObjectOfType<Clock4>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene5()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock5 c = FindObjectOfType<Clock5>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene5()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock5 c = FindObjectOfType<Clock5>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }

            private float GetTimeFromScene6()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock6 c = FindObjectOfType<Clock6>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene6()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock6 c = FindObjectOfType<Clock6>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene7()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock7 c = FindObjectOfType<Clock7>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene7()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock7 c = FindObjectOfType<Clock7>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene8()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock8 c = FindObjectOfType<Clock8>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene8()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock8 c = FindObjectOfType<Clock8>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene9()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock9 c = FindObjectOfType<Clock9>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene9()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock9 c = FindObjectOfType<Clock9>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
            private float GetTimeFromScene10()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock10 c = FindObjectOfType<Clock10>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetWrongNumFromScene10()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Clock10 c = FindObjectOfType<Clock10>();
        if (c != null)
    {
        return c.WrongNum;
    }
    else
    {
        return 0f;
    }
    }
}