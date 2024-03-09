using UnityEngine;

public class WheelSpenScript : MonoBehaviour
{
    public float wheelSpinSpeed;
    public Vector3 spinVector;
    public Rigidbody wheelRB;

    private void Update() 
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            float randomFloat = Random.Range(1, 20);
            wheelRB.AddTorque(spinVector * randomFloat * wheelSpinSpeed, ForceMode.Impulse);
        } 
    }
}
