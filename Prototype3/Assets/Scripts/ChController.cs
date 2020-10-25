using System;
using UnityEngine;
using UnityEngine.Analytics;

public class ChController : MonoBehaviour
{
private Rigidbody playerRb;
public float jumpForce=10;
public float gravityModifier;
public bool isOnGround = true;
public bool gameOver;
private Animator playerAnim;
private AudioSource playerAudio;
public ParticleSystem explosionParticle;
public ParticleSystem dirtParticle;
public AudioClip jumpSound;
public AudioClip crashSound;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent <Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent <AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle")) 

        {
            Debug.Log("GameOver");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int",1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
