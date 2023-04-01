using UnityEngine;

public class Movement : MonoBehaviour
{
    public Float speed;
    public Float rotationSpeed;
    void Update()
    {
        var translation = Input.GetAxis("Vertical") * speed.Value;
        var rotation = Input.GetAxis("Horizontal") * rotationSpeed.Value;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
