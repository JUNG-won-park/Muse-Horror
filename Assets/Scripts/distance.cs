using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{

    [SerializeField] float dis;
    public GameObject cube1;
    public GameObject Player;
    public GameObject cover;
    public GameObject pcap1;
    public GameObject pcap2;
    float showDistance;

    void Start()
    {
    }

    void Update()
    {

        showDistance = Vector3.Distance(cube1.transform.position, Player.transform.position);
        Debug.Log(showDistance);

        if (showDistance < dis)
        {
            pcap1.SetActive(true);
            pcap2.SetActive(true);
        }
        else
        {
            pcap1.SetActive(false);
            pcap2.SetActive(false);
        }


    }
}



