using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.transform.position + offset;
    }
}
