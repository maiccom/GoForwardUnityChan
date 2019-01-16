using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{

    public AudioClip sound;
    public float volume = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    //ブロックの効果音を鳴らす
    void OnCollisionEnter2D(Collision2D other)
    {
        //ブロックが床に、又はほかのブロックに衝突した場合、音を再生する
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position, volume);
        }
    }
}
