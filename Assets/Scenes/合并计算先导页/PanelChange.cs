using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChange : MonoBehaviour
{
    [SerializeField] public GameObject ClosePanel;
    [SerializeField] public GameObject OpenPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelToNext()
    {
        ClosePanel.SetActive(false);
        OpenPanel.SetActive(true);

    }
}
