using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeClear : MonoBehaviour
{
    [SerializeField] float dis;
    public GameObject cube1;
    public GameObject Player;
  
    public Image whiteFade;
    float showDistance;


    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(0.0f);
    }

    void Update()
    {

        showDistance = Vector3.Distance(cube1.transform.position, Player.transform.position);
        Debug.Log(showDistance);

        

        if (showDistance < dis)
        {
            Invoke("fadein", 0.8f);
            Invoke("GameClear", 2f);
        }

    }


    public void GameClear()
    {
        SceneManager.LoadScene(3);
    }



    void fadein()
    {
        whiteFade.CrossFadeAlpha(1, 2, false);
    }
}
