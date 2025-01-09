using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Rigidbody2D _body2D;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal"), yInput = Input.GetAxis("Vertical");
        _body2D.velocity = new Vector2 (xInput * _speed, yInput * _speed);

        if (Input.GetKeyDown(KeyCode.Space)) PlantSeed();
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft == 0) return;

        _numSeedsLeft--;
        _numSeedsPlanted++;
        Instantiate(_plantPrefab, new Vector2 (_playerTransform.position.x, _playerTransform.position.y), Quaternion.identity);

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
