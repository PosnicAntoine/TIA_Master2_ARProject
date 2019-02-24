using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int points = 0;
    private TextMeshProUGUI pointText;


    // Start is called before the first frame update
    void Start()
    {
        pointText = GameObject.Find("PointText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addOnePoint()
    {
        this.points++;
        this.updatePointText();
    }

    public void setPoint(int i)
    {
        this.points=i;
        this.updatePointText();
    }

    public void updatePointText()
    {
        pointText.text = this.points.ToString();
    }
}
