using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("基本能力"), Range(0, 10)]
    public float speed = 3.5f;
    public float attack = 100;
    public float hp = 350f;
    public float rangeTrack = 30;
    public Vector3 offsetTrack;

    [Header("掉落道具")]
    public GameObject prop;
    [Range(0,1)]
    public float probability = 1;
    [Header("音效資料")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;




    


}
