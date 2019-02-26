﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject endText;
    public RocketBehavior endRocketAnimation;
    public int endPoints;

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
        if (points >= endPoints)
        {
            this.end();
        }
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

    public void openBrowserToGit()
    {
        Application.OpenURL("https://github.com/PosnicAntoine/TIA_Master2_ARProject");
    }

    public void restartScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void end()
    {
        endRocketAnimation.isFiring = true;
        endText.SetActive(true);
    }


}
