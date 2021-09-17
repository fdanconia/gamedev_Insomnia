using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
namespace Platformer.Mechanics
{
public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maTime = 280f;
    float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;         
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
        }
        else
        {
            Schedule<PlayerEnteredDeathZone>();
            timeLeft = 280f;
        }
        
    }
}
}
