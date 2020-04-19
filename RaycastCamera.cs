using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Starting variables.
    int damage = 20;
    int range = 100;
    Camera camera;

    // Assigns the Camera instance to the camera var.
    private void Start() => camera = GetComponent<Camera>();

    private void Update()
    {
        // Creating a Ray object to detect cubes/GameObjects from the camera to the mouse position.
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; // Var to hold the instance of the GameObject the raycast is colliding with.

        // Checking if the ray actually hit something.
        // If it hit something we assign it to the "hit" var.
        // We assign the range of the ray.
        if (Physics.Raycast(ray, out hit, range))
        {
            // Drawing the ray from the camera/origin to the point/colliding point as a green line.
            // For visual purposes ONLY. (Scene View)
            Debug.DrawLine(ray.origin, hit.point, Color.green);

            // Damaging the other GameObject if left-mouse button is pressed.
            if (Input.GetKeyDown(KeyCode.Mouse0))
                hit.transform.GetComponent<Damage>().TakeDamage(damage);
        }
        // If the ray didn't hit anything we draw a line from the camera/origin to -
        // the direction the ray is going multiplied with the range so it doesn't go to infinity.
        else
            Debug.DrawLine(ray.origin, ray.direction * range, Color.red);
    }
}
