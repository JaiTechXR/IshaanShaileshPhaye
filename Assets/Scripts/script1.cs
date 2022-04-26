using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class script1 : MonoBehaviour
{
    public TextMeshProUGUI enemyNumber, moneyNumber, gameOver;
    public TextMeshProUGUI DeviceID;
    private int enemyCount, moneyCount;
    public AudioClip JumpSound, gameOverSound;

    void Start()
    {
        DeviceID.text = "System ID: " + SystemInfo.deviceUniqueIdentifier;
        enemyCount = 0;
        moneyCount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            AudioSource.PlayClipAtPoint(JumpSound, transform.position, .2f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
            enemyCount++;
            enemyNumber.text = "Enemies Defeated - " + enemyCount.ToString();
            moneyCount++;
            moneyNumber.text = "Money Secured - " + moneyCount.ToString();
        }
        if(enemyCount == 7)
        {
            gameOver.text = "Congratulations, all money Secured!";
            gameOver.gameObject.SetActive(true);
            AudioSource.PlayClipAtPoint(gameOverSound, transform.position, .2f);
        }
    }

}
