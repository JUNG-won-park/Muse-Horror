using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float wait_time;

    void Start()
    {
        StartCoroutine(Waitforme());
    }

    IEnumerator Waitforme()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);

    }
}
