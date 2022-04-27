using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void WalkSound1()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }
    public void WalkSound2()
    {
        audioSource.PlayOneShot(audioClips[1]);
    }
}
