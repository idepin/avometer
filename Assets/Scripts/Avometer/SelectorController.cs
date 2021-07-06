using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorController : MonoBehaviour
{
    public static SelectorController instance;
    AudioSource audioSource;
    [SerializeField]
    AudioClip soundFx;

    //110
    public enum RotationTarget
    {
        DCA = 110,
        DCV = 190
    }


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Rotate(RotationTarget rotationTarget)
    {
        LeanTween.rotateAround(gameObject, Vector3.forward, (int)rotationTarget, 0.4f);
        audioSource.PlayOneShot(soundFx);
    }

    public void Rotate(float target)
    {
        LeanTween.rotateAroundLocal(gameObject, Vector3.forward, target, 0.4f);
        audioSource.PlayOneShot(soundFx);
    }
}
