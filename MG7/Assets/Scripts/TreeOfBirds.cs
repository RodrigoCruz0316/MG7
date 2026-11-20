using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
 [SerializeField] private GameObject[] _birds;
 [SerializeField] private float _interactionDistance = 1.0f;
 [SerializeField] private Transform _player;

 private void Update()
 {
    foreach (GameObject bird in _birds)
    {
        if (bird != null)
        {
            float distance = Vector3.Distance(_player.position, bird.transform.position);
            if (distance <= _interactionDistance)
            {
                bird.SetActive(true);
            }
        }
        
    }
 }
}