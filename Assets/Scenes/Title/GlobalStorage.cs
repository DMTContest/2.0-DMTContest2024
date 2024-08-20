
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalStorage : MonoBehaviour
{
    public static GlobalStorage instance;

    public Sprite Head;

    public string inputName;
    public string inputSlogan;

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
        if (SceneManager.GetActiveScene().name == "startyin")
        {
            Head = GetHeadImageFromYindao();
            if (GetHeadImageFromYindao() == null)
            {
                // Debug.Log("获取为空值");
            }

        }
    }

    private Sprite GetHeadImageFromYindao()
    {
        GameObject Button1 = GameObject.Find("Btn1");

        HeadImage Btn1 = Button1.GetComponent<HeadImage>();


        if (Btn1 != null)
        {
            //Debug.Log("实例化成功");

            return Btn1.HeadImageToGlobalStorage;
        }
        else
        {
            return null;
        }
    }

    public static Sprite HeadImage
    {
        get { return instance != null ? instance.Head : null; }
    }

    

}