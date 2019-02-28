using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Vector3 startPosition;

    public Slider difficultySlider;
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
        pointText.text = this.points.ToString() + "/" +this.endPoints;
    }

    public void openBrowserToGit()
    {
        Application.OpenURL("https://github.com/PosnicAntoine/TIA_Master2_ARProject");
    }

    public void restartScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void begin()
    {
        setDifficulty(difficultySlider.value);
        difficultySlider.transform.parent.gameObject.SetActive(false);

        this.updatePointText();

        player.GetComponent<Rigidbody>().isKinematic = false;
        player.GetComponent<Transform>().position = startPosition;
    }

    private void setDifficulty(float value)
    {
        if (value <= 0)
        {
            this.endPoints = 5;
        }
        else if(value <= 1)
        {
            this.endPoints = 8;
        }
        else if(value <= 2)
        {
            this.endPoints = 14;
        }
        else if(value <= 3)
        {
            this.endPoints = 19;
        }
        else
        {
            this.endPoints = 4;
        }
    }

    private void end()
    {
        endRocketAnimation.isFiring = true;
        endText.SetActive(true);
    }


}
