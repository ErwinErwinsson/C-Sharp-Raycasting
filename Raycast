using UnityEngine;

public class Raycast : MonoBehaviour
{
    // The damage for when we clich the left-mouse button on an object.
    int damage = 10;

    private void Update()
    {
        // Creating a Ray object from the GameObject of this script to the right.
        Ray ray = new Ray(transform.position, transform.right);
        RaycastHit hit; // Var to hold the instance of the GameObject the raycast is colliding with.

        // Checking if the ray actually hit something.
        // If it hit something we assign it to the "hit" var.
        // We assign the range of the ray to 100.
        if (Physics.Raycast(ray, out hit, 100))
        {
            // Drawing the ray from the camera/origin to the point/colliding point as a green line.
            // For visual purposes ONLY. (Scene View)
            Debug.DrawLine(transform.position, hit.point, Color.green);

            // Damaging the other GameObject if left-mouse button is pressed.
            if (Input.GetKeyDown(KeyCode.Mouse0))
                hit.collider.GetComponent<Damage>().TakeDamage(damage);
        }
        // If the ray didn't hit anything we draw a line from the camera/origin to -
        // the direction the ray is going multiplied by 100 so it doesn't go to infinity.
        else
            Debug.DrawLine(transform.position, ray.direction * 100, Color.red);
    }
}
