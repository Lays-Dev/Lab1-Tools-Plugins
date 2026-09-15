using UnityEngine;

public class TransformMesh : MonoBehaviour
{
    public Mesh ExampleMesh;

    void Start()
    { 
        // Move, rotate, and scale
        Matrix4x4 matrix = new Matrix4x4(
            new Vector4(1, 0, 0, 0),
            new Vector4(0, 0, 5, 0),
            new Vector4(0, -1, 0, 0),
            new Vector4(5, 0, 0, 1));

        Vector3[] vertices = ExampleMesh.vertices;

        // Unknown vertices amount so I did a for loop

        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = matrix.MultiplyPoint3x4(vertices[i]);
        }

        ExampleMesh.vertices = vertices;
        
        // Assign the values back
        ExampleMesh.RecalculateBounds();
        ExampleMesh.RecalculateNormals();
    }
}