using UnityEngine;

public class CollectorBehavior : MonoBehaviour
{
    public AudioClip[] cherryPickSounds;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cherry"))
        {
            ScoreManager.Instance.ScoreUp();
            SoundManager.Instance.PlaySfx(cherryPickSounds);
                
            GameObject.Destroy(other.gameObject);
        }
    }
}