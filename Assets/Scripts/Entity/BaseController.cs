 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    [SerializeField] private SpriteRenderer chracterRenderer;

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; } }
    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    protected AnimationHandler animationHandler;
    
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    protected virtual void Start()
    {
        animationHandler = GetComponent<AnimationHandler>();
    }
    protected virtual void Update()
    {
        HandleAction();
        Rotate(lookDirection);
    }
    protected virtual void FixedUpdate()
    {
        Movement(movementDirection);
    }
    protected virtual void HandleAction()
    {

    }
    private void Movement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
        animationHandler.Move(direction);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bool isLeft = Mathf.Abs(rotZ) > 90f;

        chracterRenderer.flipX = isLeft;
    }

}