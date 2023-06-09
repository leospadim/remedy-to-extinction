using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    [Range(.1f, 3f)]public float pitch = 1;
    public bool loop = false;

    [HideInInspector] public AudioSource source;
}
