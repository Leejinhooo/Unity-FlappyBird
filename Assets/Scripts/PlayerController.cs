using System;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float jumpForce = 5f;
    private GameManager _gameManager;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void OnCollisionEnter(Collision collision){
        Debug.Log("CollisionEnter");
        _gameManager.GameOver();
    }

    /*private void OnTriggerEnter(Collider other)
    {Debug.Log("OnTriggerEnter");}
    private void OnTriggerStay(Collider other)
    {Debug.Log("OnTriggerStay");}*/

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TO do :점수 증가");
        _gameManager.AddScore();
        
    }


                

    // Update is called once per frame
    void Update()
    {
    }

    void OnJump()
    {
        // 위로 이동에 대한 action
        Debug.Log("Jump");
        _rigidbody.linearVelocity = Vector3.up * jumpForce;
        // _rigidbody.AddForce(Vector3.up * 5f, ForceMode.VelocityChange);
    }
}
