using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _rotationSencetivity;
    private float _xRotation;
    [SerializeField] private Transform _cameraTramsform;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;

    [SerializeField] private Animator _playerAnimator;

    private bool _isWalking = false;
    [SerializeField] private AudioSource _playerAudio;




    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            // _xRotation -= Input.GetAxis("Mouse Y") * _rotationSencetivity;
            //_xRotation = Mathf.Clamp(_xRotation, 10f, 30f);
            //_cameraTramsform.localEulerAngles = new Vector3(_xRotation, 0f, 0f);

            //transform.Rotate(0, Input.GetAxis("Mouse X") * _rotationSencetivity, 0);
        }
        transform.Rotate(0, Input.GetAxis("Mouse X") * _rotationSencetivity, 0);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _isWalking = true;


        }
        else
        {
            _isWalking = false;
        }
        if (_isWalking)
        {
            _playerAnimator.SetBool("Walk", true);

        }
        else
        {
            _playerAnimator.SetBool("Walk", false);
        }


        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            _playerAudio.Play();


        }
        if (Input.GetKeyUp(KeyCode.W))//|| Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.D))
        {
            _playerAudio.Stop();
        }
    }

    private void FixedUpdate()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 speedVector = inputVector * _speed;

        Vector3 speedVectorRelativeToPlayer = transform.TransformVector(speedVector);

        _rigidbody.velocity = new Vector3(speedVectorRelativeToPlayer.x, _rigidbody.velocity.y, speedVectorRelativeToPlayer.z);

    }




}
