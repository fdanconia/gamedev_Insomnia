using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;
    
        // Start is called before the first frame update
        void Start()
        {
                dialogBox.SetActive(false);
                timerDisplay = -1.0f;
        }
        public void DisplayDialog()
        {
            timerDisplay = displayTime;
            dialogBox.SetActive(true);
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.name.Equals("Player"))
            {
                timerDisplay = displayTime;
                dialogBox.SetActive(true);
                Debug.Log("collision");
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if(collision.gameObject.name.Equals("Player"))
            {
                    timerDisplay = displayTime;
                    dialogBox.SetActive(true);
                    Debug.Log("collision enter");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (timerDisplay >= 0)
            {
                timerDisplay -= Time.deltaTime;
                if (timerDisplay < 0)
                {
                    dialogBox.SetActive(false);
                }
            }
            
        }
}
