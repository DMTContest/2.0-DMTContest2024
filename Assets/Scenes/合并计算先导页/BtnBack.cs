using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnBack : MonoBehaviour
{
    [SerializeField] public GameObject ClosePanel;

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

    }
}
