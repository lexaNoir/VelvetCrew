using UnityEngine;

namespace Trap
{

    public class FireTrap : Trap
    {

        private Animator _animator;
        private bool _isWorking;
        [SerializeField] private float _cooldown;
        private float _cooldownTimer;


        // Start is called before the first frame update
        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            _cooldownTimer -= Time.deltaTime;

            if (_cooldownTimer < 0)
            {
                _isWorking = !_isWorking;
                _cooldownTimer = _cooldown;
            }

            _animator.SetBool("isWorking", _isWorking);
        }

        protected override void OnTriggerEnter2D(Collider2D collision)
        {
            if (_isWorking)
            {
                base.OnTriggerEnter2D(collision);
            }
        }
    }
}
