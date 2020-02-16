using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal2 : MonoBehaviour
{

    public Mesh mesh;
    public Material material;

    public int maxDepth;
    private int depth;

    public float childScale;
    public float spawnProbability;
    public float maxTwist;

    public int[] random;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Random.Range(-maxTwist, maxTwist), 0f, 0f);

        gameObject.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.AddComponent<MeshRenderer>().material = material;
        if (depth < maxDepth)
        {
            for (int i = 0; i < childDirections.Length; i++)
            {
                if (Random.value < spawnProbability)
                {
                    new GameObject("Fractal Child").AddComponent<Fractal2>().Initialize(this, i);
                }
            }
        }
    }

    private static Vector3[] childDirections = {
        Vector3.up,
        Vector3.right,
        Vector3.left,
        Vector3.forward,
        Vector3.back
    };
    private static Quaternion[] childOrientations ={
        Quaternion.identity,
        Quaternion.Euler(0f, 0f, -90f),
        Quaternion.Euler(0f, 0f, 90f),
        Quaternion.Euler(90f, 0f, 0f),
        Quaternion.Euler(-90f, 0f, 0f)
    };

    private void Initialize(Fractal2 parent, int childIndex)
    {
        mesh = parent.mesh;
        material = parent.material;
        maxDepth = parent.maxDepth;
        depth = parent.depth + 1;
        childScale = parent.childScale;
        transform.parent = parent.transform;
        transform.localScale = Vector3.one * childScale;
        transform.localPosition = childDirections[childIndex] * (0.5f + 0.5f * childScale);
        transform.localRotation = childOrientations[childIndex];
        spawnProbability = parent.spawnProbability;
        maxTwist = parent.maxTwist;
    }
}
