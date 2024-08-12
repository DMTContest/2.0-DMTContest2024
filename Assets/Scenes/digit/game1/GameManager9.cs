using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager9 : MonoBehaviour
{
    private List<int> targetOrder = new List<int>() { 1,2,3 }; // 目标消除顺序
    private List<int> clickedOrder = new List<int>(); // 实际点击顺序
    [SerializeField]private string TargetScene;
    public float correct;
    public float wrong;
    public TimeMG9 timeMG11;


    private void Start()
    {
        clickedOrder.Clear();
    }

    public void OnCircleClicked(int number)
    {
        clickedOrder.Add(number);
         Debug.Log($"Target Order: {string.Join(", ", targetOrder)}");
        Debug.Log($"Clicked Order: {string.Join(", ", clickedOrder)}");

        if (clickedOrder.Count == 1 && clickedOrder[clickedOrder.Count - 1] == targetOrder[clickedOrder.Count - 1])
        {
            Debug.Log("没问题");
            
        }else if(clickedOrder.Count == 2 && clickedOrder[clickedOrder.Count - 1] == targetOrder[clickedOrder.Count - 1]){
            Debug.Log("没问题");
        }else if (clickedOrder.SequenceEqual(targetOrder))
            {
                Debug.Log("全对的");
                //if(SceneManager.GetActiveScene().name == "MathGame3"){
                correct = 1;
                SceneManager.LoadScene(TargetScene);
                
        //}
            }
        else
        {
            Debug.Log("有问题");
            wrong = 1;
            timeMG11.ReduceTime(10f);
            SceneManager.LoadScene(TargetScene);
            //clickedOrder.Clear(); // 清除已记录的点击
        }
    }
}