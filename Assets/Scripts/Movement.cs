using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _layerMask;

    private Animator _animator;
    private SpriteRenderer _renderer;
    private Rigidbody2D _rigidBody;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", 0f);
        if (Input.GetKey(KeyCode.D))
        {
            Move(false, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(true, -1);
        }
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.velocity = Vector2.up * _jumpForce;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, 1f,_layerMask);
            return raycastHit.collider != null;
    }
    private void Move(bool xAnimationFlip, int direction)
    {
        _renderer.flipX = xAnimationFlip;
        _animator.SetFloat("Speed", 1f);
        transform.Translate(new Vector3(_speed * Time.deltaTime * direction, 0, 0));
    }
}
