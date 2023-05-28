using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public TMP_Text textLabel;
    private bool controller = false;

    void Update()
    {
        //begin the level count-down for ONCE
        if (!controller)
        {
            controller = true;
            StartCoroutine(CountdownRoutine()); // Coroutine başlatılıyor
        }
    }

    // Asynchronous operations for the countdown mechanic
    IEnumerator CountdownRoutine()
    {
        // countdown seconds
        int countdown = 30;

        // The counter and write to the text
        while (countdown > 0)
        {
            textLabel.text = countdown.ToString();
            yield return new WaitForSeconds(1);
            countdown--;
        }

        // When the counter is 0, DO SOMETHING
        yield return new WaitForSeconds(1);
    }
}