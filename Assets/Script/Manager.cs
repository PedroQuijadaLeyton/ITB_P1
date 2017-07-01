using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public AudioSource good;
    public AudioSource bad;

	// Use this for initialization
	void Start ()
    {
        bad = GetComponents<AudioSource>()[0];
        good = GetComponents<AudioSource>()[1];
    }
}
