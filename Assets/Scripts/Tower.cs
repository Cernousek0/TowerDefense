using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tower : MonoBehaviour
{
    [SerializeField] 
    private int health = 100;
        [SerializeField] 

    private TMP_Text towerHealthText;
    // Start is called before the first frame update
    void Start()
    {
        health = 0;
        towerHealthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
