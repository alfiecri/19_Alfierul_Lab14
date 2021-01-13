﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpherePurple : MonoBehaviour
{
    public GameObject purpleText;
    private int purpleCounter;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            purpleCounter++;
            purpleText.GetComponent<Text>().text = "Purple: " + purpleCounter;
            audioSource.Play();
        }
    }
}
