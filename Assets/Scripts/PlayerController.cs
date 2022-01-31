using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpValue = 1.5f;

    private Player1Actions _playerActions;
    private Rigidbody2D _rb;
    private Vector2 _moveInput;
    private bool grounded = true;

    void Awake(){
        _playerActions = new Player1Actions();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable(){
        _playerActions.Player_Map.Enable();
    }

    private void OnDisable(){
        _playerActions.Player_Map.Disable();
    }

    void FixedUpdate(){
        if(this.name == "Player One"){
            _moveInput = _playerActions.Player_Map.Movement.ReadValue<Vector2>();
            _rb.AddForce(_moveInput * 3, ForceMode2D.Impulse);
        } 

        if(this.name == "Player 2"){
            _moveInput = _playerActions.Player_Map.Movement2.ReadValue<Vector2>();
            _rb.AddForce(_moveInput * 3, ForceMode2D.Impulse);
        }
    }

    void Jump(){
        if(grounded){
            Vector2 jumpVelocity = new Vector2(0f, jumpValue);
            _rb.AddForce(jumpVelocity * 3, ForceMode2D.Impulse);
        }
    }

    public void OnJump(){
        if(this.name == "Player One"){
            Debug.Log("P1");
            Jump();
        }
    }

    public void OnJump2()
    {
        if(this.name == "Player 2"){
            Debug.Log("P2");
            Jump();
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Platform"){
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == "Platform"){
            grounded = false;
        }
    }

}
